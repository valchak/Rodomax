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
            obj.Empresa = Banco.Empresas.Find(obj.Empresa.Id);
            obj.Cidade = Banco.Cidades.Find(obj.Cidade.Id);
            
            Banco.Set<Filial>().Add(obj);
            SalvarTodos();
        }

        public void Atualizar(Filial obj)
        {
            Filial dbObj = Find(obj.Id);
            dbObj.Empresa = Banco.Empresas.Where(x => x.Id == obj.Empresa.Id).First();
            dbObj.Cidade = Banco.Cidades.Where(x => x.Id == obj.Cidade.Id).First();

            dbObj.Nome = obj.Nome;
            dbObj.Cep = obj.Cep;
            dbObj.Bairro = obj.Bairro;
            dbObj.Complemento = obj.Complemento;
            dbObj.Endereco = obj.Endereco;
            dbObj.Email = obj.Email;
            dbObj.Telefone = obj.Telefone;

            Banco.Entry(dbObj).State = EntityState.Modified;
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
            return Banco.Set<Filial>().Include(x => x.Empresa).Include(x => x.Cidade).Include(x => x.FilialCentroCustos).Include(x => x.ListaUsuarioFilial);
        }

        public void SalvarTodos()
        {
            Banco.SaveChanges();
        }
    }
}
