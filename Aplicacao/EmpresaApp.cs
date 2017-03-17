using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Repositorio;

namespace Aplicacao
{
    public class EmpresaApp : App<Empresa>
    {
        public ContextoDB Banco { get; set; }

        public EmpresaApp()
        {
            Banco = new ContextoDB();
        }

        public IQueryable<Empresa> GetAll()
        {
            return Banco.Set<Empresa>();
        }

        public IQueryable<Empresa> Get(Func<Empresa, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public Empresa Find(params object[] key)
        {
            return Banco.Set<Empresa>().Find(key);
        }

        public void Adicionar(Empresa obj)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Empresa obj)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Func<Empresa, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void SalvarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
