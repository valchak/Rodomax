using System;
using System.Windows.Forms;
using Aplicacao;
using Modelo;
using MMLib.Extensions;
using Rodomax;

namespace UI
{
    public partial class frmCidade : UI.ModelForm
    {
        _Singleton instancia = _Singleton.GetInstance;
        private Cidade city;
        private CidadeApp app;

        public frmCidade()
        {
            InitializeComponent();
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtCidadeId.Clear();
            txtCidadeNome.Clear();
            txtCidadeId.Enabled = true;
            city = new Cidade();
            app = new CidadeApp();
            this.AlteraBotoes(1);
            this.operacao = "";
        }

        public void frmCidade_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "NOVO";
            this.AlteraBotoes(2);
            txtCidadeNome.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimparCampos();
            this.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
              
                city.Nome = txtCidadeNome.Text.Trim().RemoveDiacritics().ToUpper();
                
                if (this.operacao.Equals("NOVO"))
                {
                    app.Adicionar(city);
                    app.SalvarTodos();
                    MessageBox.Show("Cadastro efetuado com sucesso: Código "+city.Id);
                }
                else
                {
                    app.Atualizar(city);
                    MessageBox.Show("Cadastro" + city.Id + " alterado com sucesso.");
                }
                this.LimparCampos();
                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro Salvar: " + erro.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
           // Thread t = new Thread(new ThreadStart(abrirPesquisa));
           // t.Start();

            frmCidadePesquisa tela = new frmCidadePesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.cidade != null)
            {
                city = instancia.cidade;
                instancia.cidade = null;
                txtCidadeId.Text = Convert.ToString(city.Id);
                txtCidadeNome.Text = city.Nome;
                this.AlteraBotoes(3);
                this.operacao = "ALTERAR";
                txtCidadeId.Enabled = false;

            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (city != null)
                {
                    app.Excluir(x => x.Id == city.Id);
                    MessageBox.Show("Cadastro " + city.Id + " excluido com sucesso.");
                    this.LimparCampos();
                }
                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro Salvar: " + erro.Message);
            }
        }

        private void frmCidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        /* private void abrirPesquisa()
         {
             bool i = true;
             while (i)
             {
                 if (instancia.cidade != null)
                 {
                     frmCidade form = new frmCidade();
                     form.txtCidadeId.Text = Convert.ToString(instancia.cidade.Id);
                     form.txtCidadeId.Enabled = false;
                     form.txtCidadeNome.Text = instancia.cidade.Nome;
                     i = false;
                 }
             }
         }*/
    }

    
}
