using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Modelo;
using Repositorio;

namespace Aplicacao
{
    public class NotaEntradaApp: App<NotaEntrada>
    {
        public ContextoDB Banco { get; set; }

        public NotaEntradaApp()
        {
            Banco = new ContextoDB();
        }

        public IQueryable<NotaEntrada> GetAll()
        {
            return Banco.Set<NotaEntrada>()
                    .Include(x => x.NotaEntradaItens)
                    .Include(x => x.OrdemCompra)
                    .Include(x => x.Fornecedor);
        }

        public IQueryable<NotaEntrada> Get(Func<NotaEntrada, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public NotaEntrada Find(params object[] key)
        {
            return Banco.Set<NotaEntrada>().Find(key);
        }

        public void Adicionar(NotaEntrada obj)
        {
            if (ValidarCampos(obj))
            {
                obj.Fornecedor = Banco.Fornecedores.Find(obj.Fornecedor.Id);
                if (obj.OrdemCompra != null)
                {
                    obj.OrdemCompra = Banco.OrdensCompra.Find(obj.OrdemCompra.Id);
                }
                IEnumerable<NotaEntradaItens> lista = obj.NotaEntradaItens;
                obj.NotaEntradaItens = null;
                Banco.NotasEntrada.Add(obj);
                foreach (var item in lista)
                {
                    item.NotaEntrada = obj;
                    item.Filial = Banco.Filiais.Find(item.Filial.Id);
                    item.QuantidadeEstoque = item.QuantidadeNota * item.Multiplicador;
                    item.ValorUnitarioEstoque = item.ValorTotal / item.QuantidadeEstoque;
                    
                    if (item.Produto != null)
                    {
                        item.Produto = Banco.Produtos.Find(item.Produto.Id);
                        item.EstoqueMovimento = AtualizarEstoque(item, EstoqueAcao.INSERT);
                    }
                    else
                    {
                        item.EstoqueMovimento = null;
                    }
                    Banco.NotaEntradaItens.Add(item);
                }
                SalvarTodos();
            }
        }

        public void Atualizar(NotaEntrada obj)
        {
            if (ValidarCampos(obj))
            {
                IEnumerable<NotaEntradaItens> lista = obj.NotaEntradaItens;
                List<NotaEntradaItens> excluir = obj.listaExcluir;
                NotaEntrada dbObj = new NotaEntrada();
                dbObj = Banco.NotasEntrada.Where(x => x.Id == obj.Id).First();
                dbObj.NotaEntradaItens = null;
                dbObj.Fornecedor = Banco.Fornecedores.Find(obj.Fornecedor.Id);
                dbObj.DataEmissao = obj.DataEmissao;
                dbObj.DataRecebimento = obj.DataRecebimento;
                

                if (obj.OrdemCompra != null)
                {
                    dbObj.OrdemCompra = Banco.OrdensCompra.Find(obj.OrdemCompra.Id);
                }
                dbObj.ValorDocumento = obj.ValorDocumento;
                dbObj.ValorDocumentoTotal = obj.ValorDocumentoTotal;
                dbObj.AcresDesc = obj.AcresDesc;
                dbObj.Faturado = dbObj.Faturado;
                Banco.Entry(dbObj).State = EntityState.Modified;
                
                foreach (var item in lista)
                {
                    var dbItem = new NotaEntradaItens();

                    if (item.Id > 0)
                    {
                        dbItem = Banco.NotaEntradaItens.Include(x => x.Produto)
                                .Include(x => x.Filial)
                                .Include(x => x.EstoqueMovimento)
                                .Where(x => x.Id == item.Id)
                                .First();
                    }

                    dbItem.NotaEntrada = dbObj;
                    dbItem.Filial = Banco.Filiais.Find(item.Filial.Id);
                    dbItem.Descricao = item.Descricao;
                    dbItem.QuantidadeNota = item.QuantidadeNota;
                    dbItem.Multiplicador = item.Multiplicador;
                    dbItem.ValorUnitario = item.ValorUnitario;
                    dbItem.ValorTotal = item.ValorTotal;
                    dbItem.QuantidadeEstoque = item.QuantidadeNota * item.Multiplicador;
                    dbItem.ValorUnitarioEstoque = item.ValorTotal / item.QuantidadeEstoque;

                    if (dbItem.EstoqueMovimento != null)
                    {
                        if (item.Produto != null)
                        {
                            dbItem.Produto = Banco.Produtos.Find(item.Produto.Id);
                            dbItem.EstoqueMovimento = AtualizarEstoque(dbItem, EstoqueAcao.UPDATE);
                        }
                        else
                        {
                            dbItem.EstoqueMovimento = AtualizarEstoque(dbItem, EstoqueAcao.DELETE);
                        }
                    }
                    else
                    {
                        if (item.Produto != null)
                        {
                            dbItem.Produto = Banco.Produtos.Find(item.Produto.Id);
                            dbItem.EstoqueMovimento = AtualizarEstoque(dbItem, EstoqueAcao.INSERT);
                        }
                    }

                    if (item.Id > 0)
                    {
                        Banco.Entry(dbItem).State = EntityState.Modified;
                    }
                    else
                    {
                        Banco.NotaEntradaItens.Add(dbItem);
                    }
                    
                }


                if (obj.listaExcluir != null)
                {
                    foreach (var item in obj.listaExcluir)
                    {
                        var dbItem = Banco.NotaEntradaItens.Include(x => x.EstoqueMovimento).Where(x => x.Id ==item.Id).First();
                        
                        if (dbItem.EstoqueMovimento != null)
                        {
                            Banco.NotaEntradaItens.Remove(dbItem);
                            AtualizarEstoque(item, EstoqueAcao.DELETE);
                        }
                        else
                        {
                            Banco.NotaEntradaItens.Remove(dbItem);
                        }
                    }
                }

                SalvarTodos();
            }

        }

        public void Excluir(Func<NotaEntrada, bool> predicate)
        {
            try
            {
                IEnumerable<NotaEntradaItens> lista = Banco.NotasEntrada.Include(x => x.NotaEntradaItens).Where(predicate).First().NotaEntradaItens;
                List<EstoqueMovimento> excluir = new List<EstoqueMovimento>();
                foreach (var item in lista)
                {
                    if (item.EstoqueMovimento != null)
                    {
                        EstoqueMovimento movimento = new EstoqueMovimento();
                        movimento = item.EstoqueMovimento;
                        excluir.Add(movimento);
                    }
                }

                Banco.Set<NotaEntrada>().Include(x => x.Fornecedor).Include(x => x.OrdemCompra).Include(x => x.NotaEntradaItens).Where(predicate).ToList().ForEach(del => Banco.Set<NotaEntrada>().Remove(del));                
                foreach (var item in excluir)
                {
                    Banco.EstoqueMovimentos.Remove(item);
                }
                SalvarTodos();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao excluir Nota: "+e.Message);
            }
            
          
        }

        public void SalvarTodos()
        {
            try
            {
                Banco.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao Salvar no Banco Nota Entrada: " + e.Message+" /n "+ e.InnerException);
            }
            
        }

        public bool ValidarCampos(NotaEntrada obj)
        {
            if (obj.Fornecedor == null)
            {
                throw new Exception("Fornecedor não informado!");
            }
            if (obj.Documento.Equals(""))
            {
                throw new Exception("Documento Inválido");
            }
            if (obj.Serie.Equals(""))
            {
                throw new Exception("Série Inválida");
            }
            if (obj.ValorDocumento == 0.00)
            {
                throw new Exception("Valor do documento inválido");
            }
            if (obj.ValorDocumentoTotal == 0.00)
            {
                throw new Exception("Valor Total Inválido");
            }
            foreach (var item in obj.NotaEntradaItens)
            {
                if (item.Filial == null)
                    throw new Exception("Filial não pode ser nula = Item: "+item.Descricao);
                if (item.QuantidadeNota <= 0)
                    throw new Exception("Quantidade inváida = Item: " + item.Descricao);
                if (item.Multiplicador <= 0)
                    throw new Exception("Multiplicador inváida = Item: " + item.Descricao);
                if (item.ValorUnitario <= 0)
                    throw new Exception("Valor Unitário inváido = Item: " + item.Descricao);
                if (item.ValorTotal <= 0)
                    throw new Exception("Valor Unitário inváido = Item: " + item.Descricao);
            }

            return true;
        }

        private EstoqueMovimento AtualizarEstoque(NotaEntradaItens item, EstoqueAcao acao)
        {
            EstoqueMovimento movimento = new EstoqueMovimento();

            if (item.EstoqueMovimento != null)
            {
                movimento = Banco.EstoqueMovimentos.Find(item.EstoqueMovimento.Id);
            }

            
            movimento.Filial = Banco.Filiais.Find(item.Filial.Id);
            movimento.Produto = Banco.Produtos.Find(item.Produto.Id);
            movimento.DataMovimento = item.NotaEntrada.DataRecebimento;
            movimento.QuantidadeNovo = item.QuantidadeEstoque;
            movimento.QuantidadeUsado = 0;
            movimento.ValorUnitario = item.ValorUnitarioEstoque;
            movimento.TipoMovimento = "E";
            movimento.ObservacaoHistorico = "Nota de Entrada";


            if (acao == EstoqueAcao.INSERT)
            {
                AtualizarProduto(item);
                Banco.EstoqueMovimentos.Add(movimento);
            }
            if (acao == EstoqueAcao.UPDATE)
            {
                if (item.Produto == null)
                {
                    Banco.EstoqueMovimentos.Remove(movimento);
                    movimento = null;
                }
                else
                {
                    Banco.Entry(movimento).State = EntityState.Modified;
                }
            }
            if (acao == EstoqueAcao.DELETE)
            {
                Banco.EstoqueMovimentos.Remove(movimento);
                movimento = null;
            }

            return movimento;
        }

        private void AtualizarProduto(NotaEntradaItens item)
        {
            if(item.Produto.Id > 0){
                Produto produto = Banco.Produtos.Find(item.Produto.Id);
                produto.UltimaDataCompra = item.NotaEntrada.DataEmissao;
                produto.UltimaNotaCompra = item.NotaEntrada.Documento;
                produto.UltimoFornecedor = Banco.Fornecedores.Find(item.NotaEntrada.Fornecedor.Id);
                produto.UltimoValorCompra = item.ValorUnitario;

                EstoqueApp app = new EstoqueApp();
                List<Estoque> lista = app.Get(x => x.Produto.Id == item.Produto.Id).ToList();
                
                int quantidade = 0;
                foreach (var estoque in lista)
                {
                    quantidade = quantidade + estoque.QuantidadeNovo;
                }

                double custoTotal = item.ValorTotal + (quantidade * Banco.Produtos.Find(item.Produto.Id).CustoMedio);
                produto.CustoMedio = custoTotal / (quantidade + item.QuantidadeEstoque);
                Banco.Entry(produto).State = EntityState.Modified;
            }
        }
    }
}
