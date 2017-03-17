using Modelo;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aplicacao
{
    public class CidadeApp
    {
        public ContextoDB Banco { get; set; }

        public CidadeApp()
        {
            Banco = new ContextoDB();
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
