using Modelo;
using System;
using System.Data.Entity;
using System.Linq;
using Repositorio;
using System.Collections.Generic;

namespace Aplicacao
{
    public class CentroCustoApp : App<CentroCusto>
    {
        public ContextoDB Banco { get; set; }

        public CentroCustoApp()
        {
            Banco = new ContextoDB();
        }

        public void Adicionar(CentroCusto obj)
        {
            try
            {
                List<Filial> lista = obj.ListaInserir;
                
                Banco.Set<CentroCusto>().Add(obj);

                foreach (var x in lista)
                {
                    FilialCentroCusto novo = new FilialCentroCusto();
                    novo.Filial = Banco.Filiais.Find(x.Id);
                    novo.CentroCusto = obj;
                    Banco.FilialCentroCustos.Add(novo);
                }

                SalvarTodos();


            }
            catch(Exception e)
            {

            }
        }

        public void Atualizar(CentroCusto obj)
        {
            List<Filial> inserir = obj.ListaInserir;
            List<Filial> excluir = obj.ListaExcluir;

            CentroCusto dbObj = Banco.CentroCustos.Find(obj.Id);
            dbObj.Nome = obj.Nome;
            Banco.Entry(dbObj).State = EntityState.Modified;


            FilialCentroCustoApp app = new FilialCentroCustoApp();
            foreach (var i in inserir)
            {
                IEnumerable<FilialCentroCusto> lista = app.Get(x => x.Filial.Id == i.Id && x.CentroCusto.Id == obj.Id);

                if (!lista.Any())
                {
                    FilialCentroCusto novo = new FilialCentroCusto();
                    novo.CentroCusto = Banco.CentroCustos.Find(obj.Id);
                    novo.Filial = Banco.Filiais.Find(i.Id);
                    Banco.FilialCentroCustos.Add(novo);
                }
            }

            foreach (var i in excluir)
            {
                IEnumerable<FilialCentroCusto> lista = app.Get(x => x.Filial.Id == i.Id && x.CentroCusto.Id == obj.Id);
                foreach (var x in lista)
                {
                    FilialCentroCusto novo = Banco.FilialCentroCustos.Where(y => y.CentroCusto.Id == x.CentroCusto.Id && y.Filial.Id == x.Filial.Id).First();
                    Banco.FilialCentroCustos.Remove(novo);
                }
            }

            SalvarTodos();
        }

        public void Excluir(Func<CentroCusto, bool> predicate)
        {
            Banco.Set<CentroCusto>().Where(predicate).ToList().ForEach(del => Banco.Set<CentroCusto>().Remove(del));
            SalvarTodos();
        }

        public CentroCusto Find(params object[] key)
        {
            return Banco.Set<CentroCusto>().Find(key);
        }

        public IQueryable<CentroCusto> Get(Func<CentroCusto, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public IQueryable<CentroCusto> GetAll()
        {
            return Banco.Set<CentroCusto>().Include(x => x.Filiais);
        }

        public void SalvarTodos()
        {
            Banco.SaveChanges();
        }
    }
}
