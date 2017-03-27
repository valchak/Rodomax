using System;
using System.Data.Entity;
using System.Linq;
using Modelo;
using Repositorio;


namespace Aplicacao
{
    public class MaterialSaidaProdutosApp : App<MaterialSaidaProdutos>
    {
        public ContextoDB Banco { get; set; }

        public MaterialSaidaProdutosApp()
        {
            Banco = new ContextoDB();
        }

        public void Adicionar(MaterialSaidaProdutos obj)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(MaterialSaidaProdutos obj)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Func<MaterialSaidaProdutos, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public MaterialSaidaProdutos Find(params object[] key)
        {
            return Banco.Set<MaterialSaidaProdutos>().Find(key);
        }

        public IQueryable<MaterialSaidaProdutos> Get(Func<MaterialSaidaProdutos, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public IQueryable<MaterialSaidaProdutos> GetAll()
        {
            return Banco.Set<MaterialSaidaProdutos>().Include(x => x.MaterialSaida).Include(x => x.CentroCusto).Include(x => x.Produto);
        }

        public void SalvarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
