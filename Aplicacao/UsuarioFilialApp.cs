using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Modelo;
using Repositorio;

namespace Aplicacao
{
    public class UsuarioFilialApp : App<UsuarioFilial>
    {
        public ContextoDB Banco { get; set; }
        _Singleton instancia = _Singleton.GetInstance;

        public UsuarioFilialApp()
        {
            Banco = new ContextoDB();
        }

        public void Adicionar(UsuarioFilial obj)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(UsuarioFilial obj)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Func<UsuarioFilial, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public UsuarioFilial Find(params object[] key)
        {
            return Banco.Set<UsuarioFilial>().Find(key);
        }

        public IQueryable<UsuarioFilial> Get(Func<UsuarioFilial, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public IQueryable<UsuarioFilial> GetAll()
        {
            return Banco.Set<UsuarioFilial>()
                 .Include(x => x.Usuario)
                 .Include(x => x.Filial);
        }

        public void SalvarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
