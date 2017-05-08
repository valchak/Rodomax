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
                    
                    foreach(var i in obj.LinhasTelefone)
                    {
                        if (!JaExisteLinha(obj,i))
                        {
                            throw new Exception("Linha Telefonica: "+i.Linha+" Já está cadastrada em outro contrato");
                        }
                    }

                    Banco.TelefoneCobrancas.Add(obj);

                    SalvarTodos();
                }

            }
            else
            {
                throw new Exception("Número de patrimônio já cadastrado");
            }
            
        }

        public void Atualizar(TelefoneCobranca obj)
        {
            if (ValidarCampos(obj))
            {
                obj.FilialFatura = Banco.Filiais.Find(obj.FilialFatura.Id);
                obj.Fornecedor = Banco.Fornecedores.Find(obj.Fornecedor.Id);

                foreach (var i in obj.LinhasTelefone)
                {
                    if (!JaExisteLinha(obj, i))
                    {
                        throw new Exception("Linha Telefonica: " + i.Linha + " Já está cadastrada em outro contrato");
                    }
                }

              //  Banco.TelefoneCobrancas.Add(obj);
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
                if(Tel.Id != i.TelefoneCobranca.Id)
                {
                    result = false;
                }
            }

            return result;
        }
    }
}
