using Modelo;
using System;
using System.Data.Entity;
using System.Linq;
using Repositorio;

namespace Aplicacao
{
    public class FilialCentroCustoApp : App<FilialCentroCusto>
    {
        public ContextoDB Banco { get; set; }
        public FilialCentroCustoApp()
        {
            Banco = new ContextoDB();
        }


        public void Adicionar(FilialCentroCusto obj)
        {
            obj.Filial = Banco.Filiais.Find(obj.Filial.Id);
            obj.CentroCusto = Banco.CentroCustos.Find(obj.CentroCusto.Id);

            Banco.Set<FilialCentroCusto>().Add(obj);
            SalvarTodos();
        }

        public void Atualizar(FilialCentroCusto obj)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Func<FilialCentroCusto, bool> predicate)
        {
            Banco.Set<FilialCentroCusto>().Where(predicate).ToList().ForEach(del => Banco.Set<FilialCentroCusto>().Remove(del));
            SalvarTodos();
        }

        public FilialCentroCusto Find(params object[] key)
        {
           return Banco.Set<FilialCentroCusto>().Find(key);
        }

        public IQueryable<FilialCentroCusto> Get(Func<FilialCentroCusto, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public IQueryable<FilialCentroCusto> GetAll()
        {
            return Banco.Set<FilialCentroCusto>().Include(x => x.Filial).Include(x => x.CentroCusto);
        }

        public void SalvarTodos()
        {
            Banco.SaveChanges();
        }
    }
}
