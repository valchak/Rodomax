using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Modelo;
using Repositorio;

namespace Aplicacao
{
    public class UsuarioApp : App<Usuario>
    {
        public ContextoDB Banco { get; set; }

        public UsuarioApp()
        {
            Banco = new ContextoDB();
        }

        public void Adicionar(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Func<Usuario, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Usuario Find(params object[] key)
        {
            return Banco.Set<Usuario>().Find(key);
        }

        public IQueryable<Usuario> Get(Func<Usuario, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public IQueryable<Usuario> GetAll()
        {
            return Banco.Set<Usuario>()
                 .Include(x => x.Funcionario);
        }

        public void SalvarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
