using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Modelo;
using Repositorio;

namespace Aplicacao
{
    public class TelefoneLinhasApp : App<TelefoneLinha>
    {
        public ContextoDB Banco { get; set; }

        public TelefoneLinhasApp()
        {
            Banco = new ContextoDB();
        }

        public void Adicionar(TelefoneLinha obj)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(TelefoneLinha obj)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Func<TelefoneLinha, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public TelefoneLinha Find(params object[] key)
        {
            return Banco.Set<TelefoneLinha>().Find(key);
        }

        public IQueryable<TelefoneLinha> Get(Func<TelefoneLinha, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public IQueryable<TelefoneLinha> GetAll()
        {
            Banco.TelefoneLinhas.Load();
            return Banco.Set<TelefoneLinha>().Include(x => x.TelefoneCobranca).Include(x => x.Filial).Include(x => x.Funcionario).OrderBy(x => x.Linha);
        }

        public void SalvarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
