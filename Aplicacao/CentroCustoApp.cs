using Modelo;
using System;
using System.Data.Entity;
using System.Linq;
using Repositorio;

namespace Aplicacao
{
    public class CentroCustoApp : App<CentroCusto>
    {
        public ContextoDB Banco { get; set; }

        public CentroCustoApp()
        {
            Banco = new ContextoDB();
        }

        public void Adicionar(CentroCusto obj)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(CentroCusto obj)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Func<CentroCusto, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public CentroCusto Find(params object[] key)
        {
            return Banco.Set<CentroCusto>().Find(key);
        }

        public IQueryable<CentroCusto> Get(Func<CentroCusto, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public IQueryable<CentroCusto> GetAll()
        {
            return Banco.Set<CentroCusto>().Include(x => x.Filiais);
        }

        public void SalvarTodos()
        {
            Banco.SaveChanges();
        }
    }
}
