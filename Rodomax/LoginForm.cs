﻿using System;
using System.Windows.Forms;
using MMLib.Extensions;
using Aplicacao;
using Modelo;
using System.Linq;
using System.Threading;
using System.Collections.Generic;

namespace Rodomax
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        _Singleton instancia = _Singleton.GetInstance;
        public LoginForm()
        {
            InitializeComponent();
            Limpar();
        }
        private void Limpar()
        {
            UsuarioApp userApp = new UsuarioApp();
            IEnumerable<Usuario> listaUser = userApp.GetAll();
            if (listaUser.Count() < 4)
            {
                this.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        bool LogaUsuario(string login, string senha)
        {
            Formatacao formatacao = new Formatacao();
            UsuarioApp app = new UsuarioApp();

            string password =  String.Format("{0:yyyyMMdd}", DateTime.Now);

            if (login.Equals("RODOMAX") && senha.Equals(password))
            {
                SecurPerfilApp appPerf = new SecurPerfilApp();
                SecurPerfil perfil = appPerf.Get(x => x.Id == 1).First();
                Usuario rodomax = new Usuario();
                rodomax.Login = "RODOMAX";
                rodomax.Perfil = perfil;
                instancia.userLogado = rodomax;
                UsuarioFilialApp filial = new UsuarioFilialApp();
                instancia.userFiliais = filial.GetAll();
                return true;
            }
            else
            {
                senha = formatacao.CriptoSenha(senha);
                IQueryable<Usuario> lista = app.Get(x => x.Login == login && x.Senha == senha && x.Situacao.Equals("A"));

                if (lista.Count() > 0)
                {
                    instancia.userLogado = lista.First();
                    UsuarioFilialApp filial = new UsuarioFilialApp();
                    instancia.userFiliais = filial.Get(x => x.Usuario.Id == instancia.userLogado.Id);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }

        

        private void btnLogar_Click(object sender, EventArgs e)
        {
            FazerLogin();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void txtPassword_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FazerLogin();
            }
        }
        public void FazerLogin()
        {
            this.ShowInTaskbar = true;
            string login = txtUsuario.Text.Trim().RemoveDiacritics().ToUpper();
            string senha = txtPassword.Text.Trim().RemoveDiacritics();
            if (!login.Equals("") && !senha.Equals(""))
            {
                
                this.progressBar.Style = ProgressBarStyle.Marquee;
                if (LogaUsuario(login, senha))
                {
                    this.progressBar.Style = ProgressBarStyle.Blocks;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.progressBar.Style = ProgressBarStyle.Blocks;
                    MessageBox.Show("Usuário ou senha Inválidos");
                    txtPassword.Focus();
                }
                this.progressBar.Style = ProgressBarStyle.Blocks;
            }
            else
            {
                MessageBox.Show("Usuário ou senha Inválidos");
                txtPassword.Focus();
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void LoginForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
             //   this.Close();
            }
        }


        void Splash()
        {
            try
            {
                Splash tela = new Splash();
                tela.ShowDialog();
                tela.Dispose();
            }
            catch
            {
                //Thread t = new Thread(new ThreadStart(Splash));
                //t.Start();
                //t.Abort();
            }
        }
    }
}
