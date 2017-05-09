using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Modelo;
using Repositorio;

namespace Aplicacao
{
    public class TelefoneApp : App<TelefoneCobranca>
    {
        public ContextoDB Banco { get; set; }

        public TelefoneApp()
        {
            Banco = new ContextoDB();
        }

        public IQueryable<TelefoneCobranca> GetAll()
        {
            return Banco.Set<TelefoneCobranca>()
                    .Include(x => x.FilialFatura)
                    .Include(x => x.Fornecedor)
                    .Include(x => x.LinhasTelefone);
        }

        public IQueryable<TelefoneCobranca> Get(Func<TelefoneCobranca, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public TelefoneCobranca Find(params object[] key)
        {
            return Banco.Set<TelefoneCobranca>().Find(key);
        }

        public void Adicionar(TelefoneCobranca obj)
        {
            if (JaExiste(obj))
            {
                if (ValidarCampos(obj))
                {

                    obj.FilialFatura = Banco.Filiais.Find(obj.FilialFatura.Id);
                    obj.Fornecedor = Banco.Fornecedores.Find(obj.Fornecedor.Id);
                    List<TelefoneLinha> lista = obj.LinhasTelefone.ToList();
                    obj.LinhasTelefone = null;
                    Banco.TelefoneCobrancas.Add(obj);

                    bool salvar = true;

                    foreach (var i in lista)
                    {
                        if(i.Id >= 1000)
                        {
                            i.Id = 0;
                        }

                        if (!JaExisteLinha(obj, i))
                        {
                            TelefoneLinha dbItem = new TelefoneLinha();
                            dbItem =  Banco.TelefoneLinhas.Where(x => x.Linha.Equals(i.Linha)).First();
                            dbItem.TelefoneCobranca = obj;
                            if (i.Filial != null)
                            {
                                dbItem.Filial = Banco.Filiais.Find(i.Filial.Id);
                            }
                            if (i.Funcionario != null)
                            {
                                dbItem.Funcionario = Banco.Funcionarios.Find(i.Funcionario.Id);
                            }
                            dbItem.Situacao = i.Situacao;
                            Banco.Entry(dbItem).State = EntityState.Modified;

                        }
                        else
                        {
                            TelefoneLinha item = i;
                            item.TelefoneCobranca = obj;
                            if (i.Filial != null)
                            {
                                item.Filial = Banco.Filiais.Find(i.Filial.Id);
                            }
                            if (i.Funcionario != null)
                            {
                                item.Funcionario = Banco.Funcionarios.Find(i.Funcionario.Id);
                            }
                            Banco.TelefoneLinhas.Add(item);
                        }
                        
                    }
                    
                    if (salvar)
                    {
                        SalvarTodos();
                    }
                }

            }
            else
            {
                throw new Exception("Numero da linha não pode ser salvo");
            }
            
        }

        public void Atualizar(TelefoneCobranca obj)
        {
            if (ValidarCampos(obj))
            {
                
                TelefoneCobranca dbObj = Banco.TelefoneCobrancas.Find(obj.Id);
                dbObj.FilialFatura = Banco.Filiais.Find(obj.FilialFatura.Id);
                dbObj.Fornecedor = Banco.Fornecedores.Find(obj.Fornecedor.Id);
                dbObj.LinhaCobranca = obj.LinhaCobranca;
                dbObj.DiaVencimento = obj.DiaVencimento;
                dbObj.Cnpj = obj.Cnpj.Replace(",",".");
                dbObj.Observacao = obj.Observacao;
                dbObj.Situacao = obj.Situacao;

                List<TelefoneLinha> lista = obj.LinhasTelefone.ToList();
                obj.LinhasTelefone = null;

                Banco.Entry(dbObj).State = EntityState.Modified;
                    
                foreach (var i in lista)
                {

                    TelefoneLinha dbItem = i;
                    
                    if(i.Id > 0 )
                    {
                        dbItem = Banco.TelefoneLinhas.Include(x => x.Filial)
                            .Include(x => x.Funcionario)
                            .Where(x => x.Id == i.Id)
                            .First();

                        dbItem.TelefoneCobranca = dbObj;
                        if (i.Filial != null)
                        {
                            dbItem.Filial = Banco.Filiais.Find(i.Filial.Id);
                        }
                        if (i.Funcionario != null)
                        {
                            dbItem.Funcionario = Banco.Funcionarios.Find(i.Funcionario.Id);
                        }
                        Banco.Entry(dbItem).State = EntityState.Modified;
                    } else
                    {
                        if (!JaExisteLinha(obj, i))
                        {
                            dbItem = Banco.TelefoneLinhas
                           .Where(x => x.Linha.Equals(i.Linha))
                           .First();

                            dbItem.TelefoneCobranca = dbObj;
                            if (i.Filial != null)
                            {
                                dbItem.Filial = Banco.Filiais.Find(i.Filial.Id);
                            }
                            if (i.Funcionario != null)
                            {
                                dbItem.Funcionario = Banco.Funcionarios.Find(i.Funcionario.Id);
                            }
                            dbItem.Situacao = i.Situacao;

                            Banco.Entry(dbItem).State = EntityState.Modified;

                        } else
                        {
                            dbItem.TelefoneCobranca = dbObj;
                            if (i.Filial != null)
                            {
                                dbItem.Filial = Banco.Filiais.Find(i.Filial.Id);
                            }
                            if (i.Funcionario != null)
                            {
                                dbItem.Funcionario = Banco.Funcionarios.Find(i.Funcionario.Id);
                            }
                            Banco.TelefoneLinhas.Add(dbItem);
                        }
                    }
                }
                if (obj.listaExcluir != null)
                {
                    foreach (var item in obj.listaExcluir)
                    {
                        var dbItem = Banco.TelefoneLinhas.Where(x => x.Id == item.Id).First();
                        dbItem.TelefoneCobranca = null;
                        dbItem.Filial = null;
                        dbItem.Funcionario = null;
                        Banco.Entry(dbItem).State = EntityState.Modified;
                    }
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

        public bool ValidarCampos(TelefoneCobranca obj)
        {
            if (obj.FilialFatura == null)
            {
                throw new Exception("Filial de cobrança não informado!");
            }
            if (obj.Fornecedor == null)
            {
                throw new Exception("Fornecedor não informado!");
            }
            return true;
        }
        

        public void Excluir(Func<TelefoneCobranca, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public bool JaExiste(TelefoneCobranca obj)
        {
            IEnumerable<TelefoneCobranca> lista = Get(x => x.LinhaCobranca.Equals(obj.LinhaCobranca));

            bool result = true;

            foreach (var i in lista)
            {
                result = false;
            }

            return result;
        }

        public bool JaExisteLinha(TelefoneCobranca Tel, TelefoneLinha linha)
        {
            IEnumerable<TelefoneLinha> lista = Banco.TelefoneLinhas.Where(x => x.Linha.Equals(linha.Linha));

            bool result = true;

            foreach (var i in lista)
            {
                if(linha.Linha.Equals(i.Linha))
                {
                    result = false;
                }
            }

            return result;
        }


        public Funcionario getFuncionario(TelefoneLinha linha)
        {
            if(linha.Id > 0)
            {
                var lista = (from p in Banco.Funcionarios
                             join g in Banco.TelefoneLinhas on p.Id equals g.Funcionario.Id
                             where g.Id == linha.Id
                             select p);
                if (lista.Any())
                {
                    return lista.First();
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

    }
}
