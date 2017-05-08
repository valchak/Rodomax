using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Modelo;
using Repositorio;

namespace Aplicacao
{
    public class PatrimonioApp : App<Patrimonio>
    {
        public ContextoDB Banco { get; set; }

        public PatrimonioApp()
        {
            Banco = new ContextoDB();
        }

        public IQueryable<Patrimonio> GetAll()
        {
            return Banco.Set<Patrimonio>()
                    .Include(x => x.PatrimonioGrupo)
                    .Include(x => x.Filial)
                    .Include(x => x.Funcionario)
                    .Include(x => x.ListaHistorico);
        }

        public IQueryable<Patrimonio> Get(Func<Patrimonio, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public Patrimonio Find(params object[] key)
        {
            return Banco.Set<Patrimonio>().Find(key);
        }

        public void Adicionar(Patrimonio obj)
        {
            if (JaExiste(obj))
            {
                if (ValidarCampos(obj))
                {

                    obj.Filial = Banco.Filiais.Find(obj.Filial.Id);
                    obj.CentroCusto = Banco.CentroCustos.Find(obj.CentroCusto.Id);
                    obj.PatrimonioGrupo = Banco.PatrimonioGrupos.Find(obj.PatrimonioGrupo.Id);
                    if (obj.Funcionario != null)
                    {
                        obj.Funcionario = Banco.Funcionarios.Find(obj.Funcionario.Id);
                    }

                    Banco.Patrimonios.Add(obj);
                    PatrimonioHistorico h = new PatrimonioHistorico();

                    h.Patrimonio = obj;
                    h.Data = DateTime.Now;
                    h.Valor = obj.ValorAquisicao;
                    h.Historico = GeraHistorico(obj, EstoqueAcao.INSERT);

                    Banco.PatrimonioHistoricos.Add(h);

                    SalvarTodos();
                }

            }
            else
            {
                throw new Exception("Número de patrimônio já cadastrado");
            }
            
        }

        public void Atualizar(Patrimonio obj)
        {
            if (ValidarCampos(obj))
            {
                string historico = GeraHistorico(obj, EstoqueAcao.UPDATE);

                Patrimonio dbObj = new Patrimonio();
                dbObj = Banco.Patrimonios.Where(x => x.Id == obj.Id).First();
                dbObj.Filial = Banco.Filiais.Find(obj.Filial.Id);
                dbObj.CentroCusto = Banco.CentroCustos.Find(obj.CentroCusto.Id);
                dbObj.PatrimonioGrupo = Banco.PatrimonioGrupos.Find(obj.PatrimonioGrupo.Id);
                dbObj.PatrimonioNumero = obj.PatrimonioNumero;
                dbObj.Descricao = obj.Descricao;
                dbObj.NumeroSerie = obj.NumeroSerie;
                dbObj.DataAquisicao = obj.DataAquisicao;
                dbObj.ValorAquisicao = obj.ValorAquisicao;
                dbObj.Situacao = obj.Situacao;
                dbObj.Observacao = obj.Observacao;
                
                if (obj.Funcionario != null)
                {
                    dbObj.Funcionario = Banco.Funcionarios.Find(obj.Funcionario.Id);
                }
                else
                {
                    dbObj.Funcionario = null;
                }

                Banco.Entry(dbObj).State = EntityState.Modified;

                if (!historico.Trim().Equals(""))
                {
                    PatrimonioHistorico h = new PatrimonioHistorico();
                    h.Historico = historico;
                    h.Patrimonio = dbObj;
                    h.Data = DateTime.Now;
                    h.Valor = 0;
                    Banco.PatrimonioHistoricos.Add(h);
                }

                
                SalvarTodos();
            }

        }

       
        public void SalvarTodos()
        {
            try
            {
                Banco.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao Salvar no Banco: " + e.Message+" /n "+ e.InnerException);
            }
            
        }

        public bool ValidarCampos(Patrimonio obj)
        {
            if (obj.Filial == null)
            {
                throw new Exception("Filial não informado!");
            }
            if (obj.PatrimonioGrupo == null)
            {
                throw new Exception("Grupo não informado!");
            }
            if (obj.CentroCusto == null)
            {
                throw new Exception("Centro de Custo não informado!");
            }
            if (obj.PatrimonioNumero.Equals(""))
            {
                throw new Exception("Número de Patrimônio Inválido");
            }
            
            return true;
        }

        private string GeraHistorico(Patrimonio obj, EstoqueAcao tipo)
        {
            string historico = "";
            if (tipo == EstoqueAcao.INSERT)
            {
                historico = "Patrimonio: " + obj.PatrimonioNumero + "\n"
                    + "Descrição: " + obj.Descricao + "\n"
                    + "Data Aquisicao: " + obj.DataAquisicao.ToString("dd/MM/yyyy") + "\n"
                    + "NúmeroSerie/IMEI: " + obj.NumeroSerie+ "\n"
                    + "Grupo: " + obj.PatrimonioGrupo.Descricao + "\n"
                    + "Filial: " + obj.Filial.Nome + "\n"
                    + "Centro de Custo: " + obj.CentroCusto.Nome + "\n"
                    + "Situação: " + obj.Situacao;
                if(obj.Funcionario != null)
                {
                    historico = historico + "\n" + "Funcionário:" + obj.Funcionario.Nome;
                }
            }
            if (tipo == EstoqueAcao.UPDATE)
            {
                Patrimonio dbObj = Get(x => x.Id == obj.Id).First();

                if (!obj.PatrimonioNumero.Equals(dbObj.PatrimonioNumero))
                {
                    historico = "Patrimonio: " + obj.PatrimonioNumero;
                }
                if (!obj.Descricao.Equals(dbObj.Descricao))
                {
                    historico = historico + "\n" + "Patrimonio: " + obj.Descricao;
                }
                if(obj.DataAquisicao != dbObj.DataAquisicao)
                {
                    historico = historico + "\n" + "Data Aquisicao: " + obj.DataAquisicao.ToString("dd/MM/yyyy");
                }
                if(!obj.NumeroSerie.Equals(dbObj.NumeroSerie))
                {
                    historico = historico + "\n" + "NúmeroSerie/IMEI: " + obj.NumeroSerie.ToString();
                }
                if (obj.PatrimonioGrupo.Id != dbObj.PatrimonioGrupo.Id)
                {
                    historico = historico + "\n" + "Grupo: " + obj.PatrimonioGrupo.Descricao;
                }
                if (obj.Filial.Id != dbObj.Filial.Id)
                {
                    historico = historico + "\n" + "Filial: " + obj.Filial.Nome;
                }
                if (obj.CentroCusto.Id != dbObj.CentroCusto.Id)
                {
                    historico = historico + "\n" + "Centro de Custo: " + obj.CentroCusto.Nome;
                }
                if (!obj.Situacao.Equals(dbObj.Situacao))
                {
                    historico = historico + "\n" + "Situação: " + obj.Situacao;
                }  
                if (obj.Funcionario != null || dbObj.Funcionario != null)
                {
                    if (obj.Funcionario != null)
                    {
                        if(dbObj.Funcionario != null)
                        {
                            if(dbObj.Funcionario.Id != obj.Funcionario.Id)
                            {
                                historico = historico + "\n" + "Funcionário:" + obj.Funcionario.Nome;
                            }
                        }
                        else
                        {
                            historico = historico + "\n" + "Funcionário:" + obj.Funcionario.Nome;
                        }
                    }
                    else
                    { 
                        historico = historico + "\n" + "Funcionário " + dbObj.Funcionario.Nome +" Removido";
                    }
                }
            }

            return historico;
        }

        public void Excluir(Func<Patrimonio, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public bool JaExiste(Patrimonio obj)
        {
            IEnumerable<Patrimonio> ListaUser = Get(x => x.PatrimonioNumero.Equals(obj.PatrimonioNumero));

            bool result = true;

            foreach (var i in ListaUser)
            {
                result = false;
            }

            return result;
        }
    }
}
