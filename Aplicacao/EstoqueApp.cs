using System;
using System.Data.Entity;
using System.Linq;
using Modelo;
using Repositorio;

namespace Aplicacao
{
    public class EstoqueApp : App<Estoque>
    {
        _Singleton instancia = _Singleton.GetInstance;

        public ContextoDB Banco { get; set; }

        public EstoqueApp()
        {
            Banco = new ContextoDB();
        }

        public void Adicionar(Estoque obj)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Estoque obj)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Func<Estoque, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Estoque Find(params object[] key)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Estoque> Get(Func<Estoque, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public IQueryable<Estoque> GetAll()
        {
            var lista = (from e in Banco.Estoques join
                           f in Banco.Filiais on e.Filial.Id equals f.Id join
                           p in Banco.Produtos on e.Produto.Id equals p.Id join
                           g in Banco.ProdutosGrupoUsuario on p.ProdutoGrupo.Id equals g.ProdutoGrupo.Id
                         where g.Usuario.Id == instancia.userLogado.Id
                         select e);
            
            return lista.Include(x => x.Filial).Include(x => x.Produto);
        }

        public void SalvarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
