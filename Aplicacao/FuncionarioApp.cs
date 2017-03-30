using System;
using System.Data.Entity;
using System.Linq;
using Modelo;
using Repositorio;

namespace Aplicacao
{
    public class FuncionarioApp : App<Funcionario>
    {
        public ContextoDB Banco { get; set; }

        public FuncionarioApp()
        {
            Banco = new ContextoDB();
        }

        public void Adicionar(Funcionario obj)
        {
            obj.Filial = Banco.Filiais.Find(obj.Filial.Id);
            Banco.Funcionarios.Add(obj);
            SalvarTodos();
        }

        public void Atualizar(Funcionario obj)
        {
            Funcionario dbObj = Banco.Funcionarios.Find(obj.Id);
            dbObj.Filial = Banco.Filiais.Find(obj.Filial.Id);
            dbObj.CPF = obj.CPF;
            dbObj.Nome = obj.Nome;
            dbObj.Email = obj.Email;
            dbObj.Situacao = obj.Situacao;

            Banco.Entry(dbObj).State = EntityState.Modified;
            SalvarTodos();
        }

        public void Excluir(Func<Funcionario, bool> predicate)
        {
            Banco.Set<Funcionario>().Where(predicate).ToList().ForEach(del => Banco.Set<Funcionario>().Remove(del));
            SalvarTodos();
        }

        public Funcionario Find(params object[] key)
        {
            return Banco.Set<Funcionario>().Find(key);
        }

        public IQueryable<Funcionario> Get(Func<Funcionario, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public IQueryable<Funcionario> GetAll()
        {
            return Banco.Set<Funcionario>().Include(x => x.Filial);
        }

        public void SalvarTodos()
        {
            Banco.SaveChanges();
        }
    }
}
