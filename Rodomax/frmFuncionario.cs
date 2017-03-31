using Aplicacao;
using MMLib.Extensions;
using Modelo;
using System;
using System.Windows.Forms;

namespace Rodomax
{
    public partial class frmFuncionario : UI.ModelForm
    {
        _Singleton instancia = _Singleton.GetInstance;
        Filial filial;
        Funcionario funcionario;
        FuncionarioApp app;

        public frmFuncionario()
        {
            InitializeComponent();
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtId.Clear();
            txtCPF.Clear();
            txtFilial.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            rdAtivo.Select();

            filial = null;
            funcionario = new Funcionario();
            app = new FuncionarioApp();
            this.AlteraBotoes(1);

        }
        private void Salvar()
        {
            try
            {
                funcionario.CPF = txtCPF.Text;
                funcionario.Nome = txtNome.Text.Trim().RemoveDiacritics().ToUpper();
                funcionario.Filial = filial;
                funcionario.Email = txtEmail.Text.Trim().RemoveDiacritics();
                if (rdAtivo.Checked)
                {
                    funcionario.Situacao = "A";
                }
                else
                {
                    funcionario.Situacao = "I";
                }
                if (funcionario.Id == 0)
                {
                    app.Adicionar(funcionario);
                    app.SalvarTodos();
                    MessageBox.Show("Cadastro efetuado com sucesso: Código " + funcionario.Id);
                }
                else
                {
                    app.Atualizar(funcionario);
                    MessageBox.Show("Cadastro " + funcionario.Id + " alterado com sucesso.");
                }
                this.LimparCampos();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro Salvar: " + erro.Message);
            }
        }
            private void BuscarFuncionario()
        {
            frmFuncionarioPesquisa tela = new frmFuncionarioPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.funcionario != null)
            {
                funcionario = instancia.funcionario;
                instancia.funcionario = null;
                txtId.Text = funcionario.Id.ToString();
                txtCPF.Text = funcionario.CPF;
                txtNome.Text = funcionario.Nome;
                filial = funcionario.Filial;
                txtFilial.Text = filial.Nome;
                if (funcionario.Situacao.Equals("A"))
                {
                    rdAtivo.Select();
                }
                else
                {
                    rdInativo.Select();
                }
                this.AlteraBotoes(3);
            }
        }
        private bool Validar()
        {

            if (txtNome.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nome Inválido");
                return false;
            }
            if (!ValidarCPF())
            {
                MessageBox.Show("CPF Inválido");
                return false;
            }
            if (filial == null)
            {
                MessageBox.Show("Favor informar Filial");
                return false;
            }
            return true;
        }
        private bool ValidarCPF()
        {
            bool validacao = true;
            var novo = txtCPF.Text.Trim().Replace("-", "").Replace("/", "").Replace(".", "").Replace(",", "").ToCharArray();
            if (novo.Length == 11)
            {
                if (!Formatacao.IsCpf(txtCPF.Text))
                {
                    MessageBox.Show("CPF Informado é inválido");
                    txtCPF.Focus();
                    validacao = false;
                }
            }
            else
            {
                validacao = false;
            }
            return validacao;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(2);
            txtCPF.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            BuscarFuncionario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            switch (Formatacao.MensagemExcluir())
            {
                case DialogResult.Yes:
                    app.Excluir(x => x.Id == funcionario.Id);
                    MessageBox.Show("Item Excuido com sucesso:");
                    LimparCampos();
                    break;
                case DialogResult.No:
                    break;
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

        private void btnFilal_Click(object sender, EventArgs e)
        {
            frmFilialPesquisa tela = new frmFilialPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.filial != null)
            {
                filial = instancia.filial;
                instancia.filial = null;
                txtFilial.Text = filial.Nome;

            }
        }
    }
}
