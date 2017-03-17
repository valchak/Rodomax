using System;
using System.Data.Entity;
using System.Linq;
using Repositorio;

namespace Aplicacao
{
    interface IRepository<TEntity>   where TEntity : class
    {
        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> Get(Func<TEntity, bool> predicate);

        TEntity Find(params object[] key);

        void Atualizar(TEntity obj);

        void SalvarTodos();

        void Adicionar(TEntity obj);

        void Excluir(Func<TEntity, bool> predicate);
    }

    
    public abstract class Banco<TEntity> : IDisposable, IRepository<TEntity> where TEntity : class
    {
        ContextoDB ctx = new ContextoDB();
        public IQueryable<TEntity> GetAll()
        {
            return ctx.Set<TEntity>();
        }
        public IQueryable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
            //exemplo: IEnumerable<NotaEntrada> listaNF = app.Get(x => x.Fornecedor.Id == nf.Id && x.Documento == nf.Documento && x.Serie == nf.Serie);
        }
        public TEntity Find(params object[] key)
        {
            return ctx.Set<TEntity>().Find(key);
        }
        public void Atualizar(TEntity obj)
        {
            ctx.Entry(obj).State = EntityState.Modified;
        }
        public void SalvarTodos()
        {
            ctx.SaveChanges();
        }
        public void Adicionar(TEntity obj)
        {
            ctx.Set<TEntity>().Add(obj);
        }
        public void Excluir(Func<TEntity, bool> predicate)
        {
            ctx.Set<TEntity>().Where(predicate).ToList().ForEach(del => ctx.Set<TEntity>().Remove(del));
        }
        public void Dispose()
        {
            ctx.Dispose();
        }
        
    }
}
