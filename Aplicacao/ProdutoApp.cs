﻿using System;
using System.Data.Entity;
using System.Linq;
using Modelo;
using Repositorio;
using System.Collections.Generic;

namespace Aplicacao
{
    public class ProdutoApp : App<Produto>
    {
        public ContextoDB Banco { get; set; }
        _Singleton instancia = _Singleton.GetInstance;

        public ProdutoApp()
        {
            Banco = new ContextoDB();
        }
        public IQueryable<Produto> GetAll()
        {
            var lista = (from p in Banco.Produtos join 
                         g in Banco.ProdutosGrupoUsuario on p.ProdutoGrupo.Id equals g.ProdutoGrupo.Id
                         where g.Usuario.Id == instancia.userLogado.Id
                         select p);
                
                //Banco.Set<Produto>().Include(x => x.ProdutoGrupo).Include(x => x.UltimoFornecedor).Join(Banco.ProdutosGrupoUsuario, p => p.ProdutoGrupo.Id, g => g.ProdutoGrupo.Id,(p, g) => new { p, g });

            return lista.Include(x => x.ProdutoGrupo).Include(x => x.UltimoFornecedor);
        }

        public IQueryable<Produto> Get(Func<Produto, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public Produto Find(params object[] key)
        {
            return Banco.Set<Produto>().Find(key);
        }

        public void Adicionar(Produto obj)
        {
            if (Validar(obj))
            {
                obj.ProdutoGrupo = Banco.ProdutoGrupos.Find(obj.ProdutoGrupo.Id);
                Banco.Produtos.Add(obj);
                SalvarTodos();
            }
           
        }

        public void Atualizar(Produto obj)
        {
            if (Validar(obj))
            {
                Produto dbObj = new Produto();
                dbObj = Banco.Produtos.Find(obj.Id);
                dbObj.ProdutoGrupo = Banco.ProdutoGrupos.Find(obj.ProdutoGrupo.Id);
                dbObj.Nome = obj.Nome;
                dbObj.CustoMedio = obj.CustoMedio;
                dbObj.Multiplicador = obj.Multiplicador;
                dbObj.Observacao = obj.Observacao;
                dbObj.EstoqueFilial = obj.EstoqueFilial;
                dbObj.EstoqueUsado = obj.EstoqueUsado;
                dbObj.Situacao = obj.Situacao;

                Banco.Entry(dbObj).State = EntityState.Modified;
                SalvarTodos();
            }
                
        }

        public void AtualizarUltimaCompra(Produto obj)
        {

            Produto dbObj = new Produto();
            dbObj = Find(obj.Id);
            dbObj.UltimoFornecedor = obj.UltimoFornecedor;
            dbObj.UltimaDataCompra = obj.UltimaDataCompra;
            dbObj.UltimaNotaCompra = obj.UltimaNotaCompra;
            dbObj.UltimoValorCompra = obj.UltimoValorCompra;

            Banco.Entry(dbObj).State = EntityState.Modified;
            SalvarTodos();
        }
    
        public void Excluir(Func<Produto, bool> predicate)
        {
            Banco.Set<Produto>().Where(predicate).ToList().ForEach(del => Banco.Set<Produto>().Remove(del));
            SalvarTodos();
        }

        public void SalvarTodos()
        {
            Banco.SaveChanges();
        }


        private bool Validar(Produto obj)
        {
            if (obj.Nome.Equals(""))
            {
                throw new Exception("Nome Inválido");
            }
            if (obj.ProdutoGrupo == null)
            {
                throw new Exception("Grupo de Produto Inválido");
            }
            return true;
        }

    }
}
