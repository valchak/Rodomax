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
            if (Validar(obj))
            {
                obj.Filial = Banco.Filiais.Find(obj.Filial.Id);
                Banco.Funcionarios.Add(obj);
                SalvarTodos();
            }
            else
            {
                throw new Exception("Já existe esse funcionário cadastrado");
            }
        }

        public void Atualizar(Funcionario obj)
        {
            Funcionario dbObj = Banco.Funcionarios.Find(obj.Id);
            dbObj.Filial = Banco.Filiais.Find(obj.Filial.Id);
            dbObj.CPF = obj.CPF;
            dbObj.Nome = obj.Nome;
            dbObj.Email = obj.Email;
            dbObj.Funcao = obj.Funcao;
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
            var result = Banco.Set<Funcionario>().Find(key);
            Banco.Entry(result).Reference<Filial>(x => x.Filial).Load();
            return result;
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

        private bool Validar(Funcionario obj)
        {
            bool result = true;
            foreach (var i in Get(x => x.CPF.Equals(obj.CPF)))
            {
                result = false;
            }
            return result;
        }
    }
}
