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
        _Singleton instancia = _Singleton.GetInstance;
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
                UsuarioFilialApp filial = new UsuarioFilialApp();
                instancia.userFiliais = filial.Get(x => x.Usuario.Id == instancia.userLogado.Id);
                return true;
            }
            else
            {
                return false;
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
                Thread t = new Thread(new ThreadStart(Splash));
                t.Start();
                if (LogaUsuario(login, senha))
                {
                    t.Abort();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    t.Abort();
                    MessageBox.Show("Usuário ou senha Inválidos");
                    txtPassword.Focus();
                }
                t.Abort();


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
    }
}
