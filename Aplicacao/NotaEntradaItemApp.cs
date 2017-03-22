using System;
using System.Data.Entity;
using System.Linq;
using Modelo;
using Repositorio;

namespace Aplicacao
{
    public class NotaEntradaItemApp: App<NotaEntradaItens>
    {
        public ContextoDB Banco { get; set; }

        public NotaEntradaItemApp()
        {
            Banco = new ContextoDB();
        }

        public IQueryable<NotaEntradaItens> GetAll()
        {
            return
                Banco.Set<NotaEntradaItens>()
                    .Include(x => x.EstoqueMovimento)
                    .Include(x => x.Filial)
                    .Include(x => x.NotaEntrada)
                    .Include(x => x.Produto);
        }

        public IQueryable<NotaEntradaItens> Get(Func<NotaEntradaItens, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public NotaEntradaItens Find(params object[] key)
        {
            return Banco.Set<NotaEntradaItens>().Find(key);
        }

        public void Adicionar(NotaEntradaItens obj)
        {
            if (ValidarCampos(obj))
            {
                try
                {
  //                  obj.NotaEntrada = Banco.NotasEntrada.Find(obj.NotaEntrada.Id);
//                    obj.FilialEstoque = Banco.Filiais.Find(obj.FilialEstoque.Id);

                    if (obj.Produto != null)
                    {
                        obj.Produto = Banco.Produtos.Find(obj.Produto.Id);
                        obj.EstoqueMovimento = Banco.EstoqueMovimentos.Find(AtualizarEstoque(obj, EstoqueAcao.INSERT));

                    }
                    Banco.Set<NotaEntradaItens>().Add(obj);
                    SalvarTodos();
                }
                catch (Exception e)
                {
                    throw new Exception("Erro ao atualizar item nota: " + e.Message);
                }
            }
        }

        public void Atualizar(NotaEntradaItens obj)
        {
            if (ValidarCampos(obj))
            {
                try
                {
                    NotaEntradaItens dbObj = Banco.NotaEntradaItens.Where(x => x.Id == obj.Id).First();
//                    dbObj.NotaEntrada = Banco.NotasEntrada.Where(x => x.Id == obj.NotaEntrada.Id).First();
                    dbObj.Filial = Banco.Filiais.Where(x => x.Id == obj.Filial.Id).First();
                    dbObj.Produto = Banco.Produtos.Where(x => x.Id == obj.Produto.Id).First();
                    dbObj.EstoqueMovimento = Banco.EstoqueMovimentos.Where(x => x.Id == obj.EstoqueMovimento.Id).First();
                    dbObj.QuantidadeEstoque = obj.QuantidadeEstoque;
                    dbObj.QuantidadeNota = obj.QuantidadeNota;
                    dbObj.Descricao = obj.Descricao;
                    dbObj.Multiplicador = obj.Multiplicador;
                    dbObj.ValorUnitario = obj.ValorUnitario;
                    dbObj.ValorUnitarioEstoque = obj.ValorUnitarioEstoque;
                    dbObj.ValorTotal = obj.ValorTotal;

                    Banco.Entry(dbObj).State = EntityState.Modified;
                    SalvarTodos();

                }
                catch (Exception e)
                {
                    throw new Exception("Erro ao atualizar item nota: "+e.Message);
                }
            }
            
        }

        public void Excluir(Func<NotaEntradaItens, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void SalvarTodos()
        {
            Banco.SaveChanges();
        }

        private bool ValidarCampos(NotaEntradaItens obj)
        {
            if (obj.Filial == null)
            {
                throw new Exception("Filial do estoque não informado!");
            }
            if (obj.Descricao.Equals(""))
            {
                throw new Exception("Descrição Inválida");
            }
            if (obj.QuantidadeNota.Equals(""))
            {
                throw new Exception("Quantidade Inválida");
            }
            if (obj.ValorUnitario <= 0.00)
            {
                throw new Exception("Valor do unitário inválido");
            }
            if (obj.ValorTotal <= 0.00)
            {
                throw new Exception("Valor Total Inválido");
            }
            return true;
        }

        private int AtualizarEstoque(NotaEntradaItens item, EstoqueAcao acao)
        {
            EstoqueMovimentoApp app = new EstoqueMovimentoApp();
            EstoqueMovimento movimento = new EstoqueMovimento();
            movimento.Filial = item.Filial;
//            movimento.DataMovimento = item.NotaEntrada.DataRecebimento;

            movimento.Produto = item.Produto;
            movimento.QuantidadeNovo = item.QuantidadeEstoque;
            movimento.QuantidadeUsado = 0;
            movimento.ValorUnitario = item.ValorUnitarioEstoque;
            movimento.TipoMovimento = "E";
            movimento.ObservacaoHistorico = "Nota de Entrada";


            if (acao == EstoqueAcao.INSERT)
            {
                app.Adicionar(movimento);
            }
            if (acao == EstoqueAcao.UPDATE)
            {
                movimento.Id = item.EstoqueMovimento.Id;

                if (item.Produto == null)
                {
                    app.Excluir(x => x.Id == item.EstoqueMovimento.Id);
                }
                else
                {
                    app.Atualizar(movimento);
                }
            }
            if (acao == EstoqueAcao.DELETE)
            {
                app.Excluir(x => x.Id == item.EstoqueMovimento.Id);
            }

            return movimento.Id;
        }
    }
 
}
