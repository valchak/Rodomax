using System;
using System.Linq;
using Repositorio;
using Modelo;

namespace Aplicacao
{
    public class MaterialSaidaApp : App<MaterialSaida>
    {
        public ContextoDB Banco { get; set; }

        public void Adicionar(MaterialSaida obj)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(MaterialSaida obj)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Func<MaterialSaida, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public MaterialSaida Find(params object[] key)
        {
            throw new NotImplementedException();
        }

        public IQueryable<MaterialSaida> Get(Func<MaterialSaida, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<MaterialSaida> GetAll()
        {
            throw new NotImplementedException();
        }

        public void SalvarTodos()
        {
            throw new NotImplementedException();
        }
    }    
}   
