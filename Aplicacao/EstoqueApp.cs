using System;
using System.Data.Entity;
using System.Linq;
using Modelo;
using Repositorio;

namespace Aplicacao
{
    public class EstoqueApp : App<Estoque>
    {
        public ContextoDB Banco { get; set; }

        public EstoqueApp()
        {
            Banco = new ContextoDB();
        }

        public void Adicionar(Estoque obj)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Estoque obj)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Func<Estoque, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Estoque Find(params object[] key)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Estoque> Get(Func<Estoque, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public IQueryable<Estoque> GetAll()
        {
            return Banco.Set<Estoque>().Include(x => x.Filial).Include(x => x.Produto);
        }

        public void SalvarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
