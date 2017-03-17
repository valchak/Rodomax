using System;
using System.Collections.Generic;
using System.Data.Entity;
using Modelo;
using System.Linq;
using Repositorio;

namespace Aplicacao
{
    public class ProdutoApp : App<Produto>
    {
        
        public ContextoDB Banco { get; set; }

        public ProdutoApp()
        {
            Banco = new ContextoDB();
        }

        public IQueryable<Produto> GetAll()
        {
            return Banco.Set<Produto>().Include(x => x.ProdutoGrupo);
        }
        public IQueryable<Produto> Get(Func<Produto, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
            //exemplo: IEnumerable<NotaEntrada> listaNF = app.Get(x => x.Fornecedor.Id == nf.Id && x.Documento == nf.Documento && x.Serie == nf.Serie);
        }
        public Produto Find(params object[] key)
        {
            return Banco.Set<Produto>().Find(key);
        }
        public void Atualizar(Produto obj)
        {
            Banco.Entry(obj).State = EntityState.Modified;
        }
        public void SalvarTodos()
        {
            Banco.SaveChanges();
        }
        public void Adicionar(Produto obj)
        {
            Banco.Set<Produto>().Add(obj);
        }
        public void Excluir(Func<Produto, bool> predicate)
        {
            Banco.Set<Produto>().Where(predicate).ToList().ForEach(del => Banco.Set<Produto>().Remove(del));
        }
        public void Dispose()
        {
            Banco.Dispose();
        }

        /*
        public void Adicionar(Produto obj)
        {
            if (obj.Nome.Equals(""))
            {
                throw new Exception("Nome Inválido");
            }
            if (obj.ProdutoGrupo == null)
            {
                throw new Exception("Grupo de Produto Inválido");
            }
            else
            {
                obj.ProdutoGrupo = Banco.ProdutoGrupos.Where(x => x.Id == obj.ProdutoGrupo.Id).First();
                Banco.Produtos.Add(obj);
                Banco.SaveChanges();
            }
        }

        public IEnumerable<Produto> ListarTodos()
        {
            return Banco.Produtos
                .Include(x => x.ProdutoGrupo)
                .Include(x => x.UltimoFornecedor)
                .ToList();
        }

        public IEnumerable<Produto> BuscarObjetoDB(Produto obj)
        {
            try
            {
                return Banco.Produtos
               .Include(x => x.ProdutoGrupo)
               .Include(x => x.UltimoFornecedor)
               .Where(x => x.Nome.Contains(obj.Nome))
               .Where(x => x.Situacao.Contains(obj.Situacao))
               .ToList();
            }
            catch (Exception e)
            {
                throw new Exception("Erro: "+e.Message);

            }
           
        }
       
        public Produto BuscarPorId(int id)
        {
            return Banco.Produtos
                 .Include(x => x.ProdutoGrupo)
                 .Include(x => x.UltimoFornecedor)
                 .Where(x => x.Id == id)
                 .First();
        }

        public void Alterar(Produto obj)
        {
            if (obj.Nome.Equals(""))
            {
                throw new Exception("Nome Inválido");
            }
            if (obj.ProdutoGrupo == null)
            {
                throw new Exception("Grupo de Produto Inválido");
            }
            else
            {
                Produto dbObj = Banco.Produtos.Where(x => x.Id == obj.Id).First();
                dbObj.Id = obj.Id;
                dbObj.Nome = obj.Nome;
                dbObj.ProdutoGrupo = Banco.ProdutoGrupos.Where(x => x.Id == obj.ProdutoGrupo.Id).First();
                dbObj.CustoMedio = obj.CustoMedio;
                dbObj.EstoqueFilial = obj.EstoqueFilial;
                dbObj.EstoqueUsado = obj.EstoqueUsado;
                dbObj.Multiplicador = obj.Multiplicador;
                dbObj.Situacao = obj.Situacao;
                dbObj.Observacao = obj.Observacao;
                if (obj.UltimoFornecedor != null)
                {
                    dbObj.UltimoFornecedor = Banco.Fornecedores.Where(x => x.Id == obj.UltimoFornecedor.Id).First();
                }
                dbObj.UltimaNotaCompra = obj.UltimaNotaCompra;
                dbObj.UltimaDataCompra = obj.UltimaDataCompra;
                dbObj.UltimoValorCompra = obj.UltimoValorCompra;
                Banco.SaveChanges();
            }
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void SalvarTodos()
        {
            throw new NotImplementedException();
        }

        */
    }
}
