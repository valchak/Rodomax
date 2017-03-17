using Modelo;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Aplicacao
{
    public class CidadeApp : App<Cidade>
    {
        public ContextoDB Banco { get; set; }

        public CidadeApp()
        {
            Banco = new ContextoDB();
        }

        public IQueryable<Cidade> GetAll()
        {
            return Banco.Set<Cidade>();
        }
        public IQueryable<Cidade> Get(Func<Cidade, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
            //exemplo: IEnumerable<NotaEntrada> listaNF = app.Get(x => x.Fornecedor.Id == nf.Id && x.Documento == nf.Documento && x.Serie == nf.Serie);
        }
        public Cidade Find(params object[] key)
        {
            return Banco.Set<Cidade>().Find(key);
        }
        public void Atualizar(Cidade obj)
        {
            Banco.Entry(obj).State = EntityState.Modified;
            SalvarTodos();
        }
        public void SalvarTodos()
        {
            Banco.SaveChanges();
        }
        public void Adicionar(Cidade obj)
        {
            Banco.Set<Cidade>().Add(obj);
        }
        public void Excluir(Func<Cidade, bool> predicate)
        {
            Banco.Set<Cidade>().Where(predicate).ToList().ForEach(del => Banco.Set<Cidade>().Remove(del));
        }
        public void Dispose()
        {
            Banco.Dispose();
        }


        /*
        public void Adicionar(Cidade obj)
        {
            if (obj.Nome.Equals(""))
            {
                throw new Exception("Nome Inválido");
            }
            else
            {
                Banco.Cidades.Add(obj);
                Banco.SaveChanges();
            }
            
        }
        public IEnumerable<Cidade> ListarTodos()
        {
            return Banco.Cidades.ToList();
        }

        public IEnumerable<Cidade> BuscarPorNome(String nome)
        {
            return Banco.Cidades.Where(x => x.Nome.Contains(nome)).ToList();
        }

        public Cidade BuscarPorId(int id)
        {
            return Banco.Cidades.Where(x => x.Id == id).First();
        }

        public void Alterar(Cidade obj)
        {
            if (obj.Nome.Equals(""))
            {
                throw new Exception("Nome Inválido");
            }
            else
            {
                Cidade dbObj = Banco.Cidades.Where(x => x.Id == obj.Id).First();
                dbObj.Nome = obj.Nome;
                Banco.SaveChanges();
            }
            
        }
        public void Excluir(int id)
        {
            try
            {
                Cidade dbObj = Banco.Cidades.Where(x => x.Id == id).First();
                Banco.Set<Cidade>().Remove(dbObj);
                Banco.SaveChanges();
                
            }
            catch (Exception)
            {
                throw new Exception("Cadastro não localizado no banco de dados para excluir: ");
            }
            
        }

    */
    }
}
