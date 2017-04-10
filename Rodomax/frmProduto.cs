using System;
using System.Globalization;
using System.Windows.Forms;
using Aplicacao;
using Modelo;
using MMLib.Extensions;
using Rodomax;

namespace UI
{
    public partial class frmProduto : UI.ModelForm
    {
        _Singleton instancia = _Singleton.GetInstance;
        private ProdutoApp app;

        private Produto produto;
        private ProdutoGrupo grupo;
        private Fornecedor ultimoFornecedor;

        public frmProduto()
        {
            InitializeComponent();
           
            limparCampos();
        }

        private void limparCampos()
        {
            produto = new Produto();
            app = new ProdutoApp();

            txtId.Clear();
            txtNome.Clear();
            txtGrupo.Clear();
            txtObservacao.Clear();
            txtCustoMedio.Text = "0,00";
            txtMultiplicador.Text = "1";
            txtUltimoFornecedor.Text = "";
            txtUltimaData.Text = "";
            txtUltimaNota.Text = "";
            txtUltimoValor.Text = "";

            produto.EstoqueFilial = "N";
            produto.EstoqueUsado = "N";
            produto.Situacao = "A";
            rdEstoqueFilialNao.Checked = true;
            rdUsadoNao.Checked = true;
            rdSituacaoAtivo.Checked = true;

            grupo = null;
            ultimoFornecedor = null;

            this.AlteraBotoes(1);
            this.operacao = "";

           

            

        }

        private void btnNovo_Click(object sender, System.EventArgs e)
        {
            this.operacao = "NOVO";
            this.AlteraBotoes(2);
            //txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                produto.Nome = txtNome.Text.RemoveDiacritics().ToUpper();
                string custo = txtCustoMedio.Text.Replace(".", "").Trim();
                produto.CustoMedio = double.Parse(custo.Replace(",", "."));
                produto.ProdutoGrupo = grupo;
                produto.Multiplicador = int.Parse(txtMultiplicador.Text);
                produto.Observacao = txtObservacao.Text.RemoveDiacritics();
                if (rdEstoqueFilialSim.Checked)
                {
                    produto.EstoqueFilial = "S";
                }
                else
                {
                    produto.EstoqueFilial = "N";
                }
                if (rdUsadoSim.Checked)
                {
                    produto.EstoqueUsado = "S";
                }
                else
                {
                    produto.EstoqueUsado = "N";
                }
                if (rdSituacaoInativo.Checked)
                {
                    produto.Situacao = "I";
                }
                else
                {
                    produto.Situacao = "A";
                }
                if (produto.Id == 0)
                {
                    app.Adicionar(produto);
                    MessageBox.Show("Cadastro efetuado com sucesso: Código " + produto.Id);
                }
                else
                {
                    app.Atualizar(produto);
                    MessageBox.Show("Cadastro " + produto.Id + " alterado com sucesso.");
                }
                this.limparCampos();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro Salvar: " + erro.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.limparCampos();
            this.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (produto != null)
                {
                    app.Excluir(x => x.Id == produto.Id);
                    MessageBox.Show("Cadastro " + produto.Id + " excluido com sucesso.");
                    this.limparCampos();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Excluir: " + erro.Message);
            }
        }

        private void btnBuscarGrupo_Click(object sender, EventArgs e)
        {
            frmProdutoGrupoPesquisa tela = new frmProdutoGrupoPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.produtoGrupo != null)
            {
                grupo = instancia.produtoGrupo;
                instancia.produtoGrupo = null;
                txtGrupo.Text = grupo.Nome;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            frmProdutoPesquisa tela = new frmProdutoPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.produto != null)
            {
                produto = instancia.produto;
                instancia.produto = null;

                grupo = produto.ProdutoGrupo;
                ultimoFornecedor = produto.UltimoFornecedor;

                txtNome.Text = produto.Nome;
                txtId.Text = produto.Id.ToString();
                txtGrupo.Text = grupo.Nome;
                txtCustoMedio.Text = Formatacao.DoubleToString(produto.CustoMedio);//String.Format(CultureInfo.InvariantCulture, "{0:0.0,0}", produto.CustoMedio);
                txtMultiplicador.Text = Formatacao.IntToString(produto.Multiplicador);
                txtObservacao.Text = produto.Observacao;
                if (produto.EstoqueFilial.Equals("S"))
                {
                    rdEstoqueFilialSim.Checked = true;
                }
                else
                {
                    rdEstoqueFilialNao.Checked = true;
                }
                if (produto.EstoqueUsado.Equals("S"))
                {
                    rdUsadoSim.Checked = true;
                }
                else
                {
                    rdUsadoNao.Enabled = true;
                }
                if (produto.Situacao.Equals("A"))
                {
                    rdSituacaoAtivo.Checked = true;
                }
                else
                {
                    rdSituacaoInativo.Checked = true;
                }
                // Ultima compra
                if (ultimoFornecedor != null)
                {
                    txtUltimoFornecedor.Text = ultimoFornecedor.RazaoSocial;
                    txtUltimaData.Text = produto.UltimaDataCompra.ToString("d");
                    txtUltimaNota.Text = produto.UltimaNotaCompra;
                    txtUltimoValor.Text = String.Format(CultureInfo.InvariantCulture, "{0:0.0}", produto.Multiplicador);
                }

                this.AlteraBotoes(3);
                this.operacao = "ALTERAR";
            }

            
        }

        private void txtCustoMedio_TextChanged(object sender, EventArgs e)
        {
            Formatacao.MoedaCampo(ref txtCustoMedio);
        }

        private void txtCustoMedio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Formatacao.SoNumero(e);
        }

        private void txtMultiplicador_KeyPress(object sender, KeyPressEventArgs e)
        {
            Formatacao.SoNumero(e);
        }

        private void frmProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
