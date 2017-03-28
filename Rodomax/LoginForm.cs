using Ferramenta;
using System;
using System.Windows.Forms;
using MMLib.Extensions;
using Aplicacao;
using Modelo;
using System.Linq;
using System.Threading;

namespace Rodomax
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        Singleton instancia = Singleton.GetInstance;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        bool LogaUsuario(string login, string senha)
        {
            Formatacao formatacao = new Formatacao();
            UsuarioApp app = new UsuarioApp();

            senha = formatacao.CriptoSenha(senha);
            IQueryable<Usuario> lista = app.Get(x => x.Login == login && x.Senha == senha && x.Situacao.Equals("A"));

            if (lista.Count() > 0)
            {
                instancia.userLogado = lista.First();
                return true;
            }
            else
            {
                return false;
            }

        }

        void Splash()
        {
            SplashScreen.SplashForm frm = new SplashScreen.SplashForm();
            frm.AppName = "Fazendo Login";
            frm.ShowInTaskbar = true;
            Application.Run(frm);
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string login = txtUsuario.Text.Trim().RemoveDiacritics().ToUpper();
            string senha = txtPassword.Text.Trim().RemoveDiacritics();
            if (!login.Equals("") && !senha.Equals(""))
            {
                Thread t = new Thread(new ThreadStart(Splash));
                t.Start();

                this.Opacity = 0;

                if (LogaUsuario(login, senha))
                {
                    t.Abort();
                    Principal tela = new Principal();
                    tela.ShowDialog();
                    tela.Dispose();
                }
                else
                {
                    t.Abort();
                    MessageBox.Show("Usuário ou senha Inválidos");
                }
                t.Abort();
                this.Opacity = 100;

            }
            else
            {
                MessageBox.Show("Usuário ou senha Inválidos");
            }
        }
    }
}
