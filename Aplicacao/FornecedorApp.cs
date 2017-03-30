using System;
using System.Collections.Generic;
using System.Data.Entity;
using Modelo;
using System.Linq;
using Repositorio;

namespace Aplicacao
{
    public class FornecedorApp : App<Fornecedor>
    {
        
        public ContextoDB Banco { get; set; }

        public FornecedorApp()
        {
            Banco = new ContextoDB();
        }

        public IQueryable<Fornecedor> GetAll()
        {
            return Banco.Set<Fornecedor>().Include(x => x.Cidade);
        }
        public IQueryable<Fornecedor> Get(Func<Fornecedor, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
            //exemplo: IEnumerable<NotaEntrada> listaNF = app.Get(x => x.Fornecedor.Id == nf.Id && x.Documento == nf.Documento && x.Serie == nf.Serie);
        }
        public Fornecedor Find(params object[] key)
        {
            return Banco.Set<Fornecedor>().Find(key);
        }
        public void Atualizar(Fornecedor obj)
        {
            Fornecedor dbObj = Banco.Fornecedores.Find(obj.Id);
            dbObj.Cidade = Banco.Cidades.Find(obj.Cidade.Id);
                
            dbObj.RazaoSocial = obj.RazaoSocial;
            dbObj.CnpjCpf = obj.CnpjCpf;
            dbObj.NomeFantasia = obj.NomeFantasia;
            dbObj.Ie = obj.Ie;
            dbObj.Endereco = obj.Endereco;
            dbObj.Cep = obj.Cep;
            dbObj.Telefone = obj.Telefone;
            dbObj.Contato = obj.Contato;
            dbObj.Email = obj.Email;
            dbObj.Observacao = obj.Observacao;
            

            Banco.Entry(dbObj).State = EntityState.Modified;
            SalvarTodos();
        }
        public void SalvarTodos()
        {
            Banco.SaveChanges();
        }
        public void Adicionar(Fornecedor obj)
        {
            obj.Cidade = Banco.Cidades.Find(obj.Cidade.Id);
            Banco.Set<Fornecedor>().Add(obj);
            SalvarTodos();
        }
        public void Excluir(Func<Fornecedor, bool> predicate)
        {
            Banco.Set<Fornecedor>().Where(predicate).ToList().ForEach(del => Banco.Set<Fornecedor>().Remove(del));
        }
        public void Dispose()
        {
            Banco.Dispose();
        }

      
    }
}
