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
            NotaEntradaItens app = new NotaEntradaItens();
            return
                Banco.Set<NotaEntrada>()
                    .Include(x => x.NotaEntradaItens)
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
                    if (item.Produto != null)
                    {
                        item.Produto = Banco.Produtos.Find(item.Produto.Id);
                        item.EstoqueMovimento = AtualizarEstoque(item, EstoqueAcao.INSERT);
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
                NotaEntrada dbObj = new NotaEntrada();
                dbObj = Banco.NotasEntrada.Include(x => x.Fornecedor).Include(x => x.OrdemCompra).Where(x => x.Id == obj.Id).First();
                dbObj.DataEmissao = obj.DataEmissao;
                dbObj.DataRecebimento = obj.DataRecebimento;

                dbObj.Fornecedor = Banco.Fornecedores.Find(obj.Fornecedor.Id);

                if (obj.OrdemCompra != null)
                {
                    dbObj.OrdemCompra = Banco.OrdensCompra.Find(obj.OrdemCompra.Id);
                }
                dbObj.ValorDocumento = obj.ValorDocumento;
                dbObj.ValorDocumentoTotal = obj.ValorDocumentoTotal;
                dbObj.AcresDesc = obj.AcresDesc;
                dbObj.Faturado = dbObj.Faturado;
                IEnumerable<NotaEntradaItens> lista = obj.NotaEntradaItens;
                dbObj.NotaEntradaItens = null;
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
                    dbItem.QuantidadeEstoque = item.QuantidadeEstoque;
                    dbItem.ValorUnitarioEstoque = item.ValorUnitarioEstoque;

                    if (dbItem.EstoqueMovimento != null)
                    {
                      //  dbItem.EstoqueMovimento = Banco.EstoqueMovimentos.Find(item.EstoqueMovimento.Id);
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
                            dbItem.EstoqueMovimento = AtualizarEstoque(item, EstoqueAcao.INSERT);
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
                SalvarTodos();
            }

        }

        public void Excluir(Func<NotaEntrada, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void SalvarTodos()
        {
            try
            {
                Banco.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        private bool ValidarCampos(NotaEntrada obj)
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

    }
}
