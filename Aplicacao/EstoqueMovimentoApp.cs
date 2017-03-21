using System;
using System.Data.Entity;
using System.Linq;
using Modelo;
using Repositorio;

namespace Aplicacao
{
    public class EstoqueMovimentoApp: App<EstoqueMovimento>
    {
        public ContextoDB Banco { get; set; }

        public EstoqueMovimentoApp()
        {
            Banco = new ContextoDB();
        }

        public IQueryable<EstoqueMovimento> GetAll()
        {
            return Banco.Set<EstoqueMovimento>().Include(x => x.Filial).Include(x => x.Produto);
        }

        public IQueryable<EstoqueMovimento> Get(Func<EstoqueMovimento, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public EstoqueMovimento Find(params object[] key)
        {
            return Banco.Set<EstoqueMovimento>().Find(key);
        }

        public void Adicionar(EstoqueMovimento obj)
        {
            try
            {
                obj.Produto = Banco.Produtos.Find(obj.Produto.Id);
                obj.Filial = Banco.Filiais.Find(obj.Filial.Id);
                Banco.Set<EstoqueMovimento>().Add(obj);
                SalvarTodos();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao adicionar movimento ao estoque: " + e.Message);
            }
        }

        public void Atualizar(EstoqueMovimento obj)
        {
            try
            {
                EstoqueMovimento dbObj = Banco.EstoqueMovimentos.Find(obj.Id);
                if (dbObj != null)
                {
                    dbObj.Produto = Banco.Produtos.Find(obj.Produto.Id);
                    dbObj.Filial = Banco.Filiais.Find(obj.Filial.Id);
                    dbObj.DataMovimento = obj.DataMovimento;
                    dbObj.QuantidadeNovo = obj.QuantidadeNovo;
                    dbObj.QuantidadeUsado = obj.QuantidadeUsado;
                    dbObj.ValorUnitario = obj.ValorUnitario;
                    dbObj.TipoMovimento = obj.TipoMovimento;
                    dbObj.ObservacaoHistorico = obj.ObservacaoHistorico;

                    Banco.Entry(dbObj).State = EntityState.Modified;
                    SalvarTodos();
                }
                
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao atualizar movimento do estoque: " + e.Message);
            }
        }

        public void Excluir(Func<EstoqueMovimento, bool> predicate)
        {
            Banco.Set<EstoqueMovimento>().Where(predicate).ToList().ForEach(del => Banco.Set<EstoqueMovimento>().Remove(del));
            SalvarTodos();
        }

        public void SalvarTodos()
        {
            Banco.SaveChanges();
        }
    }
}
