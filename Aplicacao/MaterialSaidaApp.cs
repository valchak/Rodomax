using System;
using System.Data.Entity;
using System.Linq;
using Modelo;
using Repositorio;
using System.Collections.Generic;

namespace Aplicacao
{
    public class MaterialSaidaApp : App<MaterialSaida>
    {
        public ContextoDB Banco { get; set; }
        _Singleton instancia = _Singleton.GetInstance;

        public MaterialSaidaApp()
        {
            Banco = new ContextoDB();
        }

        public void Adicionar(MaterialSaida obj)
        {
            if (ValidarCampos(obj))
            {
                obj.FilialSaida = Banco.Filiais.Find(obj.FilialSaida.Id);
                obj.FilialEntrada = Banco.Filiais.Find(obj.FilialEntrada.Id);
                if (obj.ResponsavelRecebimento != null)
                {
                    obj.ResponsavelRecebimento = Banco.Funcionarios.Find(obj.ResponsavelRecebimento.Id);
                }
                if(obj.Solicitacao != null)
                {
                    obj.Solicitacao = Banco.MateriaisSolicitacao.Find(obj.Solicitacao.Id);
                }

                obj.DataEntradaEstoque = obj.DataSaidaEstoque;
                IEnumerable<MaterialSaidaProdutos> lista = obj.MaterialSaidaProdutos;
                obj.MaterialSaidaProdutos = null;
                Banco.MateriaisSaida.Add(obj);
                foreach (var item in lista)
                {
                    item.MaterialSaida = obj;
                    item.CentroCusto = Banco.CentroCustos.Find(item.CentroCusto.Id);
                    item.Produto = Banco.Produtos.Find(item.Produto.Id);
                    Banco.MateriaisSaidaProdutos.Add(item);
                    AtualizarEstoque(item, EstoqueAcao.INSERT);
                }
                SalvarTodos();
            }
        }

        public void Atualizar(MaterialSaida obj)
        {
            if (ValidarCampos(obj))
            {
                IEnumerable<MaterialSaidaProdutos> lista = obj.MaterialSaidaProdutos;
                List<MaterialSaidaProdutos> excluir = obj.listaExcluir;
                MaterialSaida dbObj = Banco.MateriaisSaida.Where(x => x.Id == obj.Id).First();
                dbObj.MaterialSaidaProdutos = null;
                dbObj.FilialEntrada = Banco.Filiais.Find(obj.FilialEntrada.Id);
                dbObj.FilialSaida = obj.FilialSaida;
                dbObj.DataSaidaEstoque = obj.DataSaidaEstoque;
                dbObj.DataEntradaEstoque = obj.DataSaidaEstoque;
                dbObj.Observacao = obj.Observacao;
                
                if (obj.ResponsavelRecebimento != null)
                {
                    dbObj.ResponsavelRecebimento = Banco.Funcionarios.Find(obj.ResponsavelRecebimento.Id);
                }
                if (obj.Solicitacao != null)
                {
                    dbObj.Solicitacao = Banco.MateriaisSolicitacao.Find(obj.Solicitacao.Id);
                }
               
                Banco.Entry(dbObj).State = EntityState.Modified;

                foreach (var item in lista)
                {
                    var dbItem = new MaterialSaidaProdutos();

                    if (item.Id > 0)
                    {
                        dbItem = Banco.MateriaisSaidaProdutos.Include(x => x.Produto)
                                .Include(x => x.CentroCusto)
                                .Include(x => x.Produto)
                                .Where(x => x.Id == item.Id)
                                .First();
                    }

                    dbItem.MaterialSaida = dbObj;
                    dbItem.CentroCusto = Banco.CentroCustos.Find(item.CentroCusto.Id);
                    dbItem.Produto = Banco.Produtos.Find(item.Produto.Id);
                    dbItem.Quantidade = item.Quantidade;
                    dbItem.CustoUnitario = dbItem.Produto.CustoMedio;
                    dbItem.TipoProduto = item.TipoProduto;
                    
                    if (item.Id > 0)
                    {
                        Banco.Entry(dbItem).State = EntityState.Modified;
                        AtualizarEstoque(dbItem, EstoqueAcao.UPDATE);
                    }
                    else
                    {
                        Banco.MateriaisSaidaProdutos.Add(dbItem);
                        AtualizarEstoque(dbItem, EstoqueAcao.INSERT);
                    }

                }


                if (obj.listaExcluir != null)
                {
                    foreach (var item in obj.listaExcluir)
                    {
                        var dbItem = Banco.MateriaisSaidaProdutos.Include(x => x.Produto)
                                .Include(x => x.CentroCusto)
                                .Include(x => x.Produto)
                                .Where(x => x.Id == item.Id)
                                .First();
                        AtualizarEstoque(dbItem, EstoqueAcao.DELETE);
                        Banco.MateriaisSaidaProdutos.Remove(dbItem);
                    }
                }

                SalvarTodos();

            }
        }

        public void Excluir(Func<MaterialSaida, bool> predicate)
        {
            IEnumerable<MaterialSaidaProdutos> lista = Get(predicate).First().MaterialSaidaProdutos;
            foreach (var item in lista.ToList())
            {
                AtualizarEstoque(item, EstoqueAcao.DELETE);
                Banco.MateriaisSaidaProdutos.Remove(Banco.MateriaisSaidaProdutos.Find(item.Id));
            }
            Banco.Set<MaterialSaida>().Include(x => x.MaterialSaidaProdutos).Where(predicate).ToList().ForEach(del => Banco.Set<MaterialSaida>().Remove(del));
            
            SalvarTodos();
        }

        public MaterialSaida Find(params object[] key)
        {
            return Banco.Set<MaterialSaida>().Find(key);
        }

        public IQueryable<MaterialSaida> Get(Func<MaterialSaida, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public IQueryable<MaterialSaida> GetAll()
        {
            return Banco.Set<MaterialSaida>()
                .Include(x => x.FilialSaida)
                .Include(x => x.FilialEntrada)
                .Include(x => x.ResponsavelRecebimento)
                .Include(x => x.MaterialSaidaProdutos)
                .Include(x => x.Solicitacao);
        }

        public void SalvarTodos()
        {
            Banco.SaveChanges();
        }


        public IQueryable<MaterialSaida> GetConsulta(Func<MaterialSaida, bool> predicate)
        {
            var lista = (from s in Banco.MateriaisSaida
                         join d in Banco.MateriaisSaidaProdutos on s.Id equals d.MaterialSaida.Id
                         join p in Banco.Produtos on d.Produto.Id equals p.Id
                         join g in Banco.ProdutosGrupoUsuario on p.ProdutoGrupo.Id equals g.ProdutoGrupo.Id
                         where g.Usuario.Id == instancia.userLogado.Id
                         select s);

             return lista.Include(x => x.FilialSaida)
                .Include(x => x.FilialEntrada)
                .Include(x => x.ResponsavelRecebimento)
                .Include(x => x.MaterialSaidaProdutos)
                .Include(x => x.Solicitacao)
                .Where(predicate).AsQueryable();
        }

        public bool ValidarCampos(MaterialSaida obj)
        {
            if (obj.FilialSaida == null || obj.FilialSaida.Id == 0)
            {
                throw new Exception("Filial do estoque não informado!");
            }
            if (obj.FilialEntrada == null || obj.FilialEntrada.Id == 0)
            {
                throw new Exception("Filial de destino do item não informada");
            }
            foreach (var item in obj.MaterialSaidaProdutos)
            {
                if (item.Produto == null || item.Produto.Id == 0)
                    throw new Exception("Produto não foi informado: ");
                if (item.Quantidade <= 0)
                    throw new Exception("Quantidade inváida");
                if (item.CentroCusto == null || item.CentroCusto.Id == 0)
                    throw new Exception("Centro de custo não informado");
            }

            return true;
        }

        private void AtualizarEstoque(MaterialSaidaProdutos item, EstoqueAcao acao)
        {
            if(acao == EstoqueAcao.UPDATE || acao == EstoqueAcao.DELETE)
            {
                List<EstoqueMovimento> lista = Banco.EstoqueMovimentos.Where(x => x.MaterialSaida.Id == item.Id).ToList();

                if (lista.Any())
                {
                    foreach (var mov in lista)
                    {
                        EstoqueMovimento dbMov = Banco.EstoqueMovimentos.Find(mov.Id);

                        if (acao != EstoqueAcao.DELETE)
                        {
                            dbMov.Filial = Banco.Filiais.Find(item.MaterialSaida.FilialSaida.Id);
                            dbMov.Produto = Banco.Produtos.Find(item.Produto.Id);
                            dbMov.DataMovimento = item.MaterialSaida.DataSaidaEstoque;
                            dbMov.MaterialSaida = item;
                            dbMov.QuantidadeUsado = 0;
                            dbMov.QuantidadeNovo = 0;
                            dbMov.ValorUnitario = item.CustoUnitario;
                            dbMov.ObservacaoHistorico = "Movimento de Saída";
                            
                            // Verifica se é tipo Saída ou Entrada 
                            if (dbMov.TipoMovimento.Equals("S"))
                            {
                                //Verifica se é item de estoque Novo ou Usado
                                if (item.TipoProduto.Equals("N"))
                                {
                                    dbMov.QuantidadeNovo = item.Quantidade * -1;
                                }
                                else
                                {
                                    dbMov.QuantidadeUsado = item.Quantidade * -1;
                                }
                            }
                            else
                            {
                                //Verifica se é item de estoque Novo ou Usado
                                if (item.TipoProduto.Equals("N"))
                                {
                                    dbMov.QuantidadeNovo = item.Quantidade;
                                }
                                else
                                {
                                    dbMov.QuantidadeUsado = item.Quantidade;
                                }
                                
                            }
                        }
                        AcaoMovimento(dbMov, acao);
                    }
                }
            }
            else
            {
                
                EstoqueMovimento saida = new EstoqueMovimento();
                if(item.MaterialSaida.FilialSaida.Id == item.MaterialSaida.FilialEntrada.Id || item.Produto.EstoqueFilial.Equals("N"))
                {
                    saida.DataMovimento = item.MaterialSaida.DataSaidaEstoque;
                    saida.MaterialSaida = item;
                    saida.TipoMovimento = "S";
                    saida.QuantidadeUsado = 0;
                    saida.QuantidadeNovo = 0;
                    if (item.TipoProduto.Equals("N"))
                    {
                        saida.QuantidadeNovo = item.Quantidade * -1;
                    }
                    else
                    {
                        saida.QuantidadeUsado  = item.Quantidade * -1;
                    }
                    
                    saida.ValorUnitario = item.CustoUnitario;
                    saida.ObservacaoHistorico = "Movimento de Saida";
                    saida.Filial = Banco.Filiais.Find(item.MaterialSaida.FilialSaida.Id);
                    saida.Produto = Banco.Produtos.Find(item.Produto.Id);
                    AcaoMovimento(saida, acao);
                }
                else
                {
                    saida.DataMovimento = item.MaterialSaida.DataSaidaEstoque;
                    saida.MaterialSaida = item;
                    saida.TipoMovimento = "S";
                    saida.QuantidadeNovo = 0;
                    saida.QuantidadeUsado = 0;

                    if (item.TipoProduto.Equals("N"))
                    {
                        saida.QuantidadeNovo = item.Quantidade * -1;
                    }
                    else
                    {
                        saida.QuantidadeUsado = item.Quantidade * -1;
                    }
                    saida.ValorUnitario = item.CustoUnitario;
                    saida.ObservacaoHistorico = "Movimento de Saida";
                    saida.Filial = Banco.Filiais.Find(item.MaterialSaida.FilialSaida.Id);
                    saida.Produto = Banco.Produtos.Find(item.Produto.Id);
                    AcaoMovimento(saida, acao);

                    EstoqueMovimento entrada = new EstoqueMovimento();

                    entrada.DataMovimento = item.MaterialSaida.DataSaidaEstoque;
                    saida.MaterialSaida = item;
                    entrada.TipoMovimento = "E";
                    entrada.QuantidadeNovo = 0;
                    entrada.QuantidadeUsado = 0;

                    // Verifica se o tipo do item do estqoue é Novo ou Usado
                    if (item.TipoProduto.Equals("N"))
                    {
                        entrada.QuantidadeNovo = item.Quantidade;
                    }
                    else
                    {
                        entrada.QuantidadeUsado = item.Quantidade;
                    }
                    
                    entrada.ValorUnitario = item.CustoUnitario;
                    entrada.ObservacaoHistorico = "Movimento de Saida";
                    entrada.Filial = Banco.Filiais.Find(item.MaterialSaida.FilialEntrada.Id);
                    entrada.Produto = Banco.Produtos.Find(item.Produto.Id);
                    AcaoMovimento(entrada, acao);
                }

            }
        }
        private void AcaoMovimento(EstoqueMovimento movimento, EstoqueAcao acao)
        {
            if (acao == EstoqueAcao.INSERT)
            {
                Banco.EstoqueMovimentos.Add(movimento);
            }
            if (acao == EstoqueAcao.UPDATE)
            {
                 Banco.Entry(movimento).State = EntityState.Modified;
             }
            if (acao == EstoqueAcao.DELETE)
            {
                Banco.EstoqueMovimentos.Remove(movimento);
            }
        }
    }    
}   
