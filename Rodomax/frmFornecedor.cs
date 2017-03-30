using Aplicacao;
using MMLib.Extensions;
using Modelo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Rodomax
{
    public partial class frmFornecedor : UI.ModelForm
    {
        _Singleton instancia = _Singleton.GetInstance;
        Cidade cidade;
        Fornecedor fornecedor;
        FornecedorApp app;

        public frmFornecedor()
        {
            InitializeComponent();
        LimparCampos();
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtRazaoSocial.Clear();
            txtNomeFantasia.Clear();
            txtCNPJCPF.Clear();
            txtIE.Clear();
            txtEndereco.Clear();
            txtCEP.Clear();
            txtCidade.Clear();
            txtTelefone.Clear();
            txtContato.Clear();
            txtEmail.Clear();
            txtObservacao.Clear();

            rdCNPJ.Select();

            cidade = null;
            fornecedor = new Fornecedor();
            app = new FornecedorApp();
            this.AlteraBotoes(1);
            this.operacao = "";
        }

        private void Salvar()
        {
            try
            {
                fornecedor.RazaoSocial = txtRazaoSocial.Text.Trim().RemoveDiacritics().ToUpper();
                fornecedor.NomeFantasia=  txtNomeFantasia.Text.Trim().RemoveDiacritics().ToUpper();
                fornecedor.CnpjCpf =  txtCNPJCPF.Text.Trim().RemoveDiacritics();
                fornecedor.Ie = txtIE.Text.Trim().RemoveDiacritics();
                fornecedor.Endereco = txtEndereco.Text.Trim().RemoveDiacritics().ToUpper();
                fornecedor.Cep = txtCEP.Text.Trim().RemoveDiacritics();
                fornecedor.Cidade = cidade;
                fornecedor.Telefone = txtTelefone.Text.Trim().RemoveDiacritics();
                fornecedor.Contato = txtContato.Text.Trim().RemoveDiacritics().ToUpper();
                fornecedor.Email = txtEmail.Text.Trim().RemoveDiacritics();
                fornecedor.Observacao = txtObservacao.Text.Trim().RemoveDiacritics();


                if (fornecedor.Id == 0)
                {
                    app.Adicionar(fornecedor);
                    app.SalvarTodos();
                    MessageBox.Show("Cadastro efetuado com sucesso: Código " + fornecedor.Id);
                }
                else
                {
                    app.Atualizar(fornecedor);
                    MessageBox.Show("Cadastro " + fornecedor.Id + " alterado com sucesso.");
                }
                this.LimparCampos();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro Salvar: " + erro.Message);
            }
        }

        private void BuscarFornecedor()
        {
            frmFornecedorPesquisa tela = new frmFornecedorPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.fornecedor != null)
            {
                fornecedor = instancia.fornecedor;
                instancia.fornecedor = null;
                txtId.Text = fornecedor.Id.ToString();
                txtRazaoSocial.Text = fornecedor.RazaoSocial;
                txtCNPJCPF.Text = fornecedor.CnpjCpf;
                txtNomeFantasia.Text = fornecedor.NomeFantasia;
                txtIE.Text = fornecedor.Ie;
                txtEndereco.Text = fornecedor.Endereco;
                txtCEP.Text = fornecedor.Cep;
                txtTelefone.Text = fornecedor.Telefone;
                txtContato.Text = fornecedor.Contato;
                txtEmail.Text = fornecedor.Email;
                txtObservacao.Text = fornecedor.Observacao;
                txtCidade.Text = fornecedor.Cidade.Nome;
                cidade = fornecedor.Cidade;
                if (fornecedor.CnpjCpf.Replace("/", "").Replace(".", "").Replace("-", "").Count(char.IsUpper) > 10)
                {
                    rdCNPJ.Select();
                }
                else
                {
                    rdCPF.Select();
                }
                this.AlteraBotoes(3);
            }
        }

        private bool Validar()
        {
            if (txtRazaoSocial.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nome Inválido");
                return false;
            }
            if (txtCNPJCPF.Text.Trim().Equals(""))
            {
                MessageBox.Show("CNPJ ou CPF Inválido");
                return false;
            }
            if(cidade == null)
            {
                MessageBox.Show("Favor informar Cidade");
                return false;
            }
            return true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(2);
            txtRazaoSocial.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            BuscarFornecedor();
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
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            switch (Formatacao.MensagemExcluir())
            {
                case DialogResult.Yes:
                    app.Excluir(x => x.Id == fornecedor.Id);
                    MessageBox.Show("Item Excuido com sucesso:");
                    LimparCampos();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnCidade_Click(object sender, EventArgs e)
        {
            frmCidadePesquisa tela = new frmCidadePesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.cidade != null)
            {
                cidade = instancia.cidade;
                instancia.cidade = null;
                txtCidade.Text = cidade.Nome;
            }
        }
    }
}
