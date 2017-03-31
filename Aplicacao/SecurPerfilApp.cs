using System;
using System.Data.Entity;
using System.Linq;
using Modelo;
using Repositorio;

namespace Aplicacao
{
    public class SecurPerfilApp : App<SecurPerfil>
    {
        public ContextoDB Banco { get; set; }

        public SecurPerfilApp()
        {
            Banco = new ContextoDB();
        }

        public void Adicionar(SecurPerfil obj)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(SecurPerfil obj)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Func<SecurPerfil, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public SecurPerfil Find(params object[] key)
        {
            return Banco.Set<SecurPerfil>().Find(key);
        }

        public IQueryable<SecurPerfil> Get(Func<SecurPerfil, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public IQueryable<SecurPerfil> GetAll()
        {
            return Banco.Set<SecurPerfil>().Include(x => x.Formulario);
        }

        public void SalvarTodos()
        {
            Banco.SaveChanges();
        }
    }
}
