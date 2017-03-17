using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using Modelo;
using Repositorio;

namespace Aplicacao
{
    public class ProdutoApp : App<Produto>
    {
        public ContextoDB Banco { get; set; }

        public ProdutoApp()
        {
            Banco = new ContextoDB();
        }
        public IQueryable<Produto> GetAll()
        {
            return Banco.Set<Produto>().Include(x => x.ProdutoGrupo).Include(x => x.UltimoFornecedor);
        }

        public IQueryable<Produto> Get(Func<Produto, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public Produto Find(params object[] key)
        {
            return Banco.Set<Produto>().Find(key);
        }

        public void Adicionar(Produto obj)
        {
            if (Validar(obj))
            {
                Banco.Set<Produto>().Add(obj);
                SalvarTodos();
            }
           
        }

        public void Atualizar(Produto obj)
        {
            if (Validar(obj))
            {
                Produto dbObj = new Produto();
                dbObj = Find(obj.Id);
                dbObj.ProdutoGrupo = Banco.ProdutoGrupos.Where(x => x.Id == obj.ProdutoGrupo.Id).First();
                dbObj.Nome = obj.Nome;
                dbObj.CustoMedio = obj.CustoMedio;
                dbObj.Multiplicador = obj.Multiplicador;
                dbObj.Observacao = obj.Observacao;
                dbObj.EstoqueFilial = obj.EstoqueFilial;
                dbObj.EstoqueUsado = obj.EstoqueUsado;
                dbObj.Situacao = obj.Situacao;

                Banco.Entry(dbObj).State = EntityState.Modified;
                SalvarTodos();
            }
                
        }

        public void AtualizarUltimaCompra(Produto obj)
        {

            Produto dbObj = new Produto();
            dbObj = Find(obj.Id);
            dbObj.UltimoFornecedor = obj.UltimoFornecedor;
            dbObj.UltimaDataCompra = obj.UltimaDataCompra;
            dbObj.UltimaNotaCompra = obj.UltimaNotaCompra;
            dbObj.UltimoValorCompra = obj.UltimoValorCompra;

            Banco.Entry(dbObj).State = EntityState.Modified;
            SalvarTodos();
        }
    
        public void Excluir(Func<Produto, bool> predicate)
        {
            Banco.Set<Produto>().Where(predicate).ToList().ForEach(del => Banco.Set<Produto>().Remove(del));
            SalvarTodos();
        }

        public void SalvarTodos()
        {
            Banco.SaveChanges();
        }


        private bool Validar(Produto obj)
        {
            if (obj.Nome.Equals(""))
            {
                throw new Exception("Nome Inválido");
            }
            if (obj.ProdutoGrupo == null)
            {
                throw new Exception("Grupo de Produto Inválido");
            }
            return true;
        }

    }
}
