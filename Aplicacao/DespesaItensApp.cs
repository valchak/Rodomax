﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Modelo;
using Repositorio;

namespace Aplicacao
{
    public class DespesaItensApp : App<DespesaDetalhes>
    {
        public ContextoDB Banco { get; set; }

        public DespesaItensApp()
        {
            Banco = new ContextoDB();
        }

        public void Adicionar(DespesaDetalhes obj)
        {/*
            obj.Fornecedor = Banco.Fornecedores.Find(obj.Fornecedor.Id);

            if (obj.TelefoneCobranca != null)
            {
                obj.TelefoneCobranca = Banco.TelefoneCobrancas.Find(obj.TelefoneCobranca.Id);
            }
            IEnumerable<DespesaDetalhes> lista = obj.DespesaDetalhes;
            obj.DespesaDetalhes = null;
            Banco.Despesas.Add(obj);
            foreach (var item in lista)
            {
                item.Despesa = obj;
                item.Filial = Banco.Filiais.Find(item.Filial.Id);
                item.DespesaTipo = Banco.DespesasTipo.Find(item.DespesaTipo.Id);

                if(item.TelefoneLinha != null)
                {
                    item.TelefoneLinha = Banco.TelefoneLinhas.Find(item.TelefoneLinha.Id);
                }
                if(item.Funcionario != null)
                {
                    item.Funcionario = Banco.Funcionarios.Find(item.Funcionario.Id);
                }
                Banco.DespesasDetalhe.Add(item);
            }
            SalvarTodos();
            */
        }

        public void Atualizar(DespesaDetalhes obj)
        {
            /*
            IEnumerable<DespesaDetalhes> lista = obj.DespesaDetalhes;
            List<DespesaDetalhes> excluir = obj.listaExcluir;
            Despesa dbObj = Banco.Despesas.Where(x => x.Id == obj.Id).First();
            dbObj.DespesaDetalhes = null;
            dbObj.Fornecedor = Banco.Fornecedores.Find(obj.Fornecedor.Id);
            dbObj.Documento = obj.Documento;
            dbObj.DataInicio = obj.DataInicio;
            dbObj.DataFim = obj.DataFim;
            dbObj.DataEmissao = obj.DataEmissao;
            dbObj.DataVencimento = obj.DataVencimento;
            dbObj.DataReferencia = obj.DataReferencia;
            if (obj.TelefoneCobranca != null)
            {
                dbObj.TelefoneCobranca = Banco.TelefoneCobrancas.Find(obj.TelefoneCobranca.Id);
            }
            dbObj.ValorTitulo = obj.ValorTitulo;
            dbObj.ValorTotal = obj.ValorTotal;
            Banco.Entry(dbObj).State = EntityState.Modified;

            foreach (var item in lista)
            {
                var dbItem = new DespesaDetalhes();

                if (item.Id > 0)
                {
                    dbItem = Banco.DespesasDetalhe.Include(x => x.DespesaTipo)
                            .Include(x => x.Filial)
                            .Include(x => x.TelefoneLinha)
                            .Include(x => x.Funcionario)
                            .Include(x => x.Despesa)
                            .Where(x => x.Id == item.Id)
                            .First();
                }

                dbItem.Despesa = dbObj;
                dbItem.Filial = Banco.Filiais.Find(item.Filial.Id);
                dbItem.DespesaTipo = Banco.DespesasTipo.Find(item.DespesaTipo.Id);
                

                if (item.Funcionario != null)
                {
                    dbItem.Funcionario = Banco.Funcionarios.Find(item.Funcionario.Id);
                }
                else
                {
                    dbItem.Funcionario = null;
                }
                if(item.TelefoneLinha != null)
                {
                    dbItem.TelefoneLinha = Banco.TelefoneLinhas.Find(item.TelefoneLinha.Id);
                }
                else
                {
                    dbItem.TelefoneLinha = null;
                }

                if (item.Id > 0)
                {
                    Banco.Entry(dbItem).State = EntityState.Modified;
                }
                else
                {
                    Banco.DespesasDetalhe.Add(dbItem);
                }

            }


            if (obj.listaExcluir != null)
            {
                foreach (var item in obj.listaExcluir)
                {
                    var dbItem = Banco.DespesasDetalhe.Include(x => x.DespesaTipo)
                            .Include(x => x.Filial)
                            .Include(x => x.TelefoneLinha)
                            .Include(x => x.Funcionario)
                            .Include(x => x.Despesa)
                            .Where(x => x.Id == item.Id)
                            .First();

                    Banco.DespesasDetalhe.Remove(dbItem);
                }
            }

            SalvarTodos();
            */
        }
    
        public void Excluir(Func<DespesaDetalhes, bool> predicate)
        {
            /*
            try
            {
                Banco.Set<Despesa>().Include(x => x.Fornecedor).Include(x => x.TelefoneCobranca).Include(x => x.DespesaDetalhes).Where(predicate).ToList().ForEach(del => Banco.Set<Despesa>().Remove(del));
                SalvarTodos();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao excluir Nota: " + e.Message);
            }
            */
        }

        public DespesaDetalhes Find(params object[] key)
        {
            return Banco.Set<DespesaDetalhes>().Find(key);
        }

        public IQueryable<DespesaDetalhes> Get(Func<DespesaDetalhes, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public IQueryable<DespesaDetalhes> GetAll()
        {
            return Banco.Set<DespesaDetalhes>()
                .Include(x => x.Filial)
                .Include(x => x.Despesa)
                .Include(x => x.DespesaTipo)
                .Include(x => x.Funcionario)
                .Include(x => x.TelefoneLinha);
        }

        public void SalvarTodos()
        {
            try
            {
                Banco.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao Salvar no Despesa: " + e.Message + " /n " + e.InnerException);
            }
        }
    }
}