using Aplicacao;
using MMLib.Extensions;
using Modelo;
using System;
using System.Windows.Forms;

namespace Rodomax
{
    public partial class frmPatrimonioGrupo : UI.ModelForm
    {
        _Singleton instancia = _Singleton.GetInstance;
        private PatrimonioGrupo patrimonioGrupo;
        private PatrimonioGrupoApp app;

        public frmPatrimonioGrupo()
        {
            InitializeComponent();
            Limpar();
        }

        private void Limpar()
        {
            txtId.Clear();
            txtNome.Clear();
            this.AlteraBotoes(1);
            app = new PatrimonioGrupoApp();
            patrimonioGrupo = new PatrimonioGrupo();
        }

        private void Salvar()
        {
            try
            {
                Formatacao formatacao = new Formatacao();
                patrimonioGrupo.Descricao = txtNome.Text.Trim().RemoveDiacritics().ToUpper();

                if (patrimonioGrupo.Id == 0)
                {
                    app.Adicionar(patrimonioGrupo);
                    MessageBox.Show("Cadastro efetuado com sucesso: Código " + patrimonioGrupo.Id);
                }
                else
                {
                    app.Atualizar(patrimonioGrupo);
                    MessageBox.Show("Cadastro " + patrimonioGrupo.Id + " alterado com sucesso.");
                }
                this.Limpar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro Salvar: " + erro.Message);
            }
        }

        private bool Validar()
        {
            if (txtNome.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nome Inválido");
                return false;
            }
            return true;
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(2);
            txtNome.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPatrimonioGrupoPesquisa tela = new frmPatrimonioGrupoPesquisa();
            tela.ShowDialog();
            tela.Dispose();
            if (instancia.patrimonioGrupo != null)
            {
                patrimonioGrupo = instancia.patrimonioGrupo;
                txtId.Text = patrimonioGrupo.Id.ToString();
                txtNome.Text = patrimonioGrupo.Descricao;
                this.AlteraBotoes(3);
                instancia.patrimonioGrupo = null;
                
            }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        
    }
}
