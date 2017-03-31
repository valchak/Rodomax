using Aplicacao;
using Modelo;
using System;
using System.Collections.Generic;
using MMLib.Extensions;
using System.Windows.Forms;

namespace Rodomax
{
    public partial class frmUsuarioAlterarSenha : UI.ModelForm
    {

        _Singleton instancia = _Singleton.GetInstance;
        private UsuarioApp app;
        private Formatacao formatacao;

        public frmUsuarioAlterarSenha()
        {
            InitializeComponent();
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            switch (Formatacao.MensagemInserir())
            {
                case DialogResult.Yes:
                    if (Validar())
                    {
                        Salvar();
                    }
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private bool Validar()
        {
            if (txtSenhaAtual.Text.Trim().Equals(""))
            {
                MessageBox.Show("Informe a Senha Atual");
                return false;
            }
            else
            {
                if (!instancia.userLogado.Senha.Equals(formatacao.CriptoSenha(txtSenhaAtual.Text.Trim().RemoveDiacritics())))
                {
                    MessageBox.Show("Senha atual informada não confere");
                    return false;
                }

            }
            if (txtNovaSenha1.Text.Trim().Equals("") || txtNovaSenha2.Text.Trim().Equals(""))
            {
                MessageBox.Show("Informe a nova senha");
                return false;
            }
            else
            {
                if (!txtNovaSenha1.Text.Trim().Equals(txtNovaSenha2.Text.Trim()))
                {
                    MessageBox.Show("Nova senha não são iguais");
                    txtNovaSenha1.Focus();
                    return false;
                }
            }

           
            return true;
        }

        private void Salvar()
        {
            try
            {
             
                instancia.userLogado.Senha = formatacao.CriptoSenha(txtNovaSenha1.Text.Trim().RemoveDiacritics());
                app.TrocarSenha(instancia.userLogado);
                MessageBox.Show("Senha alterada com sucesso ");
                this.Limpar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro Salvar: " + erro.Message);
            }
        }

        private void Limpar()
        {
            app = new UsuarioApp();
            formatacao = new Formatacao();
            txtSenhaAtual.Clear();
            txtNovaSenha1.Clear();
            txtNovaSenha2.Clear();
            Buscar();

        }

        public void Buscar()
        {
            if (instancia.userLogado != null)
            {
                txtLogin.Text = instancia.userLogado.Login;
            }
        }
    }
}
