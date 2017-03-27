using Ferramenta;
using System;
using System.Windows.Forms;
using MMLib.Extensions;
using Aplicacao;
using Modelo;
using System.Linq;

namespace Rodomax
{
    public partial class LoginForm : Form
    {
        Singleton instancia = Singleton.GetInstance;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim().RemoveDiacritics().ToUpper();
            string senha = txtLogin.Text.Trim().RemoveDiacritics();
            if (!login.Equals("") && !senha.Equals(""))
            {
                Formatacao formatacao = new Formatacao();
                UsuarioApp app = new UsuarioApp();

                senha = formatacao.CriptoSenha(senha);
                IQueryable<Usuario> lista = app.Get(x => x.Login == login && x.Senha == senha && x.Situacao.Equals("A"));
                if (lista.Count() > 0)
                {
                    instancia.userLogado = lista.First();

                    MessageBox.Show("Logou");
                }
                else
                {
                    MessageBox.Show("Usuário ou senha Inválidos");
                }
            }
            else
            {
                MessageBox.Show("Usuário ou senha Inválidos");
            }
        }
    }
}
