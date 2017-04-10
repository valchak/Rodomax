using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Modelo;
using Repositorio;

namespace Aplicacao
{
    public class UsuarioApp : App<Usuario>
    {
        public ContextoDB Banco { get; set; }

        public UsuarioApp()
        {
            Banco = new ContextoDB();
        }

        public void Adicionar(Usuario obj)
        {
            if (ValidarCampos(obj))
            {
                List<Filial> lista = obj.ListaInserir;
                if (obj.Funcionario != null)
                {
                    obj.Funcionario = Banco.Funcionarios.Find(obj.Funcionario.Id);
                }
                Banco.Usuarios.Add(obj);

                foreach (var filial in lista)
                {
                    UsuarioFilial userfil = new UsuarioFilial();
                    userfil.Filial = Banco.Filiais.Find(filial.Id);
                    userfil.Usuario = obj;
                    Banco.UsuariosFilial.Add(userfil);
                }



                SalvarTodos();
            }
            else
            {
                throw new Exception("Login já cadastrado para outro usuário");
            }

        }

        public void Atualizar(Usuario obj)
        {

            try
            {

                Usuario dbObj = Banco.Usuarios.Find(obj.Id);
                dbObj.Login = obj.Login;
                dbObj.ListaUsuarioFilial = null;

                if (obj.Funcionario != null)
                {
                    dbObj.Funcionario = Banco.Funcionarios.Find(obj.Funcionario.Id);
                }
                else
                {
                    dbObj.Funcionario = null;
                }
                if (!obj.Senha.Equals(""))
                {
                    dbObj.Senha = obj.Senha;
                }

                Banco.Entry(dbObj).State = EntityState.Modified;

               

                UsuarioFilialApp app = new UsuarioFilialApp();
                foreach (var filial in obj.ListaInserir)
                {
                    IEnumerable<UsuarioFilial> lista = app.Get(x => x.Filial.Id == filial.Id && x.Usuario.Id == obj.Id);

                    if (!lista.Any())
                    {
                        UsuarioFilial novo = new UsuarioFilial();
                        novo.Filial = Banco.Filiais.Find(filial.Id);
                        novo.Usuario = Banco.Usuarios.Find(obj.Id);
                        Banco.UsuariosFilial.Add(novo);
                    }
                }
               
                foreach (var filial in obj.ListaExcluir)
                {
                    IEnumerable<UsuarioFilial> lista = app.Get(x => x.Filial.Id == filial.Id && x.Usuario.Id == obj.Id);
                    foreach (var i in lista)
                    {
                        UsuarioFilial novo = Banco.UsuariosFilial.Where(y => y.Usuario.Id == i.Usuario.Id && y.Filial.Id == i.Filial.Id).First();
                        Banco.UsuariosFilial.Remove(novo);
                    }
                }

                SalvarTodos();

            } catch (Exception e)
            {
                throw new Exception("erro ao atualziar : "+e.Message+" /n" +e.InnerException);
            }
           

        }

        public void TrocarSenha(Usuario obj)
        {

            try
            {
                Usuario dbObj = Banco.Usuarios.Find(obj.Id);
                dbObj.Senha = obj.Senha;
                Banco.Entry(dbObj).State = EntityState.Modified;
                SalvarTodos();
            }
            catch (Exception e)
            {
                throw new Exception("erro ao atualziar : " + e.Message + " /n" + e.InnerException);
            }


        }


        public void Excluir(Func<Usuario, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Usuario Find(params object[] key)
        {
            return Banco.Set<Usuario>().Find(key);
        }

        public IQueryable<Usuario> Get(Func<Usuario, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public IQueryable<Usuario> GetAll()
        {
            return Banco.Set<Usuario>().Include(x => x.Funcionario).Include(x => x.Perfil);
        }

        public void SalvarTodos()
        {
            Banco.SaveChanges();
        }

        public bool ValidarCampos(Usuario obj)
        {
            IEnumerable<Usuario> ListaUser = Get(x => x.Login.Equals(obj.Login));

            bool result = true;

            foreach (var i in ListaUser)
            {
                result = false;
            }
            
            return result;
        }
    }
}
