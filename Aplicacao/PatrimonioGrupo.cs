using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using Modelo;
using System.Linq;
using Repositorio;

namespace Aplicacao
{
    public class PatrimonioGrupoApp : App<PatrimonioGrupo>
    {
        
        public ContextoDB Banco { get; set; }

        public PatrimonioGrupoApp()
        {
            Banco = new ContextoDB();
        }

        public IQueryable<PatrimonioGrupo> GetAll()
        {
            return Banco.Set<PatrimonioGrupo>();
        }
        public IQueryable<PatrimonioGrupo> Get(Func<PatrimonioGrupo, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
            //exemplo: IEnumerable<NotaEntrada> listaNF = app.Get(x => x.Fornecedor.Id == nf.Id && x.Documento == nf.Documento && x.Serie == nf.Serie);
        }
        public PatrimonioGrupo Find(params object[] key)
        {
            return Banco.Set<PatrimonioGrupo>().Find(key);
        }
        public void Atualizar(PatrimonioGrupo obj)
        {
            PatrimonioGrupo dbObj = Banco.PatrimonioGrupos.Find(obj.Id);
            dbObj.Descricao = obj.Descricao;
            Banco.Entry(dbObj).State = EntityState.Modified;
            SalvarTodos();
        }
        public void SalvarTodos()
        {
            Banco.SaveChanges();
        }
        public void Adicionar(PatrimonioGrupo obj)
        {
            Banco.Set<PatrimonioGrupo>().AddOrUpdate(obj);
            SalvarTodos();
        }
        public void Excluir(Func<PatrimonioGrupo, bool> predicate)
        {
            Banco.Set<PatrimonioGrupo>().Where(predicate).ToList().ForEach(del => Banco.Set<PatrimonioGrupo>().Remove(del));
        }
        public void Dispose()
        {
            Banco.Dispose();
        }
    }
}
