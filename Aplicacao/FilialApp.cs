using System;
using System.Data.Entity;
using System.Linq;
using Modelo;
using Repositorio;

namespace Aplicacao
{
    public class FilialApp : App<Filial>
    {
        public ContextoDB Banco { get; set; }

        public FilialApp()
        {
            Banco = new ContextoDB();
        }

        public void Adicionar(Filial obj)
        {
            Banco.Set<Filial>().Add(obj);
            SalvarTodos();
        }

        public void Atualizar(Filial obj)
        {
            Banco.Entry(obj).State = EntityState.Modified;
            SalvarTodos();
        }

        public void Excluir(Func<Filial, bool> predicate)
        {
            Banco.Set<Filial>().Where(predicate).ToList().ForEach(del => Banco.Set<Filial>().Remove(del));
            SalvarTodos();
        }

        public Filial Find(params object[] key)
        {
            return Banco.Set<Filial>().Find(key);
        }

        public IQueryable<Filial> Get(Func<Filial, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public IQueryable<Filial> GetAll()
        {
            return Banco.Set<Filial>().Include(x => x.Empresa).Include(x => x.Cidade);
        }

        public void SalvarTodos()
        {
            Banco.SaveChanges();
        }
    }
}
