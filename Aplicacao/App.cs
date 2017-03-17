using System;
using System.Linq;
using Repositorio;

namespace Aplicacao
{
    interface App<T>
    {
        /*
        ContextoDB Banco { get; set; }
        void Adicionar(T obj);
        IEnumerable<T> ListarTodos();
        IEnumerable<T> BuscarObjetoDB(T obj);
        T BuscarPorId(int id);
        void Alterar(T obj);
        void Excluir(int id);
        */

        ContextoDB Banco { get; set; }
        IQueryable<T> GetAll();
        IQueryable<T> Get(Func<T, bool> predicate);
        T Find(params object[] key);
        void Adicionar(T obj);
        void Atualizar(T obj);
        void Excluir(Func<T, bool> predicate);
        void SalvarTodos();
    }
}
