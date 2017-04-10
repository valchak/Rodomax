using System;
using System.Data.Entity;
using System.Linq;
using Modelo;
using Repositorio;
using System.Collections.Generic;

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
            List<CentroCusto> lista = obj.ListaInserir;
            obj.Empresa = Banco.Empresas.Find(obj.Empresa.Id);
            obj.Cidade = Banco.Cidades.Find(obj.Cidade.Id);
            
            Banco.Set<Filial>().Add(obj);

            foreach (var x in lista)
            {
                FilialCentroCusto novo = new FilialCentroCusto();
                novo.CentroCusto = Banco.CentroCustos.Find(x.Id);
                novo.Filial = obj;
                Banco.FilialCentroCustos.Add(novo);
            }

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


            FilialCentroCustoApp app = new FilialCentroCustoApp();
            foreach (var i in obj.ListaInserir)
            {
                IEnumerable<FilialCentroCusto> lista = app.Get(x => x.CentroCusto.Id == i.Id && x.Filial.Id == obj.Id);

                if (!lista.Any())
                {
                    FilialCentroCusto novo = new FilialCentroCusto();
                    novo.Filial = Banco.Filiais.Find(obj.Id);
                    novo.CentroCusto = Banco.CentroCustos.Find(i.Id);
                    Banco.FilialCentroCustos.Add(novo);
                }
            }

            foreach (var i in obj.ListaExcluir)
            {
                IEnumerable<FilialCentroCusto> lista = app.Get(x => x.CentroCusto.Id == i.Id && x.Filial.Id == obj.Id);
                foreach (var x in lista)
                {
                    FilialCentroCusto novo = Banco.FilialCentroCustos.Where(y => y.CentroCusto.Id == x.CentroCusto.Id && y.Filial.Id == x.Filial.Id).First();
                    Banco.FilialCentroCustos.Remove(novo);
                }
            }

            SalvarTodos();
        }

        public void Excluir(Func<Filial, bool> predicate)
        {
            Banco.Set<Filial>().Where(predicate).ToList().ForEach(del => Banco.Set<Filial>().Remove(del));
            SalvarTodos();
        }

        public Filial Find(params object[] key)
        {
            var result = Banco.Set<Filial>().Find(key);
            Banco.Entry(result).Reference<Cidade>(x => x.Cidade).Load();
            Banco.Entry(result).Reference<Empresa>(x => x.Empresa).Load();
            return result;
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
