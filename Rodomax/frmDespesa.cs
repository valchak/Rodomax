using System;
using System.Collections.Generic;
using Aplicacao;
using Modelo;
using System.Windows.Forms;

namespace Rodomax
{
    public partial class frmDespesa : UI.ModelForm
    {
        _Singleton instancia = _Singleton.GetInstance;


        private DespesaApp app;
        private Dictionary<int, DespesaTipo> listaDepesaTipo;
        private Dictionary<int, TelefoneLinha> listaLinhas;
        private Dictionary<int, DespesaDetalhes> listaItens;
        private DespesaDetalhes item;
        private Funcionario funcionario;
        private Filial filial;
        private TelefoneCobranca telefone;
        private TelefoneLinha linha;
        private string filtro = "";
        private int sequencia = 0;
        private int editar = 0;

        public frmDespesa()
        {
            InitializeComponent();
            Limpar();
        }

        private void Limpar() {
            sequencia = 1;
            app = new DespesaApp();
            listaDepesaTipo = new Dictionary<int, DespesaTipo>();
            listaLinhas = new Dictionary<int, TelefoneLinha>();
            listaItens = new Dictionary<int, DespesaDetalhes>();
            linha = new TelefoneLinha();

            DateTime hoje = DateTime.Now;
            txtFornecedor.Clear();
            txtDocumento.Clear();
            txtReferencia.Clear();
            txtValorTitulo.Text = "0,00";
            txtValorTotal.Text = "0,00";
            CalculaDiferenca();
            txtLinhaContrato.Clear();
            txtDataFinal.Value = hoje;
            txtDataInicial.Value = hoje.AddMonths(-1).AddDays(1);
            
            if (hoje.Month != 12)
            {
                if(hoje.Day >= 15)
                {
                    txtReferencia.Text = string.Format("{0:00}", hoje.Month) + "/" + hoje.Year.ToString();
                }
                else
                {
                    txtReferencia.Text = string.Format("{0:00}", hoje.AddMonths(-1).Month) + "/" + hoje.Year.ToString();
                }
                
            } else
            {
                if (hoje.Day >= 15)
                {
                    txtReferencia.Text = string.Format("{0:00}", hoje.Month) + "/" + hoje.AddMonths(-1).Year.ToString();
                }
                else
                {
                    txtReferencia.Text = string.Format("{0:00}", hoje.AddMonths(-1).Month) + "/" + hoje.AddMonths(-1).Year.ToString();
                }
            }
            cbLinhasTelefone.Enabled = false;
            btnAddLinha.Enabled = false;
            LimparItem();
            CalculaDiferenca();
            CarregarDespesas();

        }
        private void LimparItem()
        {
            editar = 0;
            item = new DespesaDetalhes();
            txtItemValorFinal.Text = "0,00";
            txtItemValorDespesa.Text = "0,00";
            txtFuncionario.Clear();
            txtObservacao.Clear();
            funcionario = null;
            if (!txtLinhaContrato.Text.Equals(""))
            {
                cbLinhasTelefone.SelectedIndex = 0;
            }
            btnAddItem.Text = "Adicionar";
            btnExcluir.Enabled = false;
            if(listaItens.Count > 0)
            {
                btnLinhaContrato.Enabled = false;
            }
            else
            {
                btnLinhaContrato.Enabled = true;
            }
            filtro = "";
            CarregarLinhas();
        }
        private void CarregarDespesas()
        {
            DespesaTipoApp despesaTipoApp = new DespesaTipoApp();
            Dictionary<string, string> lista = new Dictionary<string, string>();
            lista.Add("", "");
            foreach (var i in despesaTipoApp.GetAll())
            {   listaDepesaTipo.Add(i.Id, i);
                lista.Add(i.Id.ToString(), i.Descircao);
            }
            cbTipoDespesa.DataSource = new BindingSource(lista, null);
        }
        private void CalculaDiferenca()
        {
            double diferenca = double.Parse(txtValorTotal.Text)-double.Parse(txtValorTitulo.Text);
            txtDiferenca.Visible = false;
            txtDiferencaValor.Visible = false;

            if (diferenca != 0)
            {
                txtDiferenca.Visible = true;
                txtDiferencaValor.Visible = true;
                if(diferenca < 0)
                {
                    txtDiferenca.Text = "Desconto";
                    txtDiferencaValor.Text = Formatacao.DoubleToString(diferenca);
                } else
                {
                    txtDiferenca.Text = "Acrescimo";
                    txtDiferencaValor.Text = Formatacao.DoubleToString(diferenca);
                }
            }
        }
        private void CarregaDadosLinha()
        {
            if (cbLinhasTelefone.SelectedIndex > 0)
            {
                if (listaLinhas.Count > 0)
                {
                    linha = listaLinhas[int.Parse(cbLinhasTelefone.SelectedValue.ToString())];

                    if (linha.Id > 0)
                    {
                        filial = linha.Filial;
                        txtFilial.Text = filial.Nome;
                    }
                    if (linha.Funcionario != null)
                    {
                        if (funcionario == null)
                        {
                            funcionario = linha.Funcionario;
                            txtFuncionario.Text = funcionario.Nome;
                        }
                    }
                    else
                    {
                        funcionario = null;
                        txtFuncionario.Clear();
                    }
                }
            }
           
        }
        private void CarregarLinhas()
        {
            Dictionary<string, string> lista = new Dictionary<string, string>();
            lista.Add("", "");

            foreach (var i in listaLinhas.Values)
            {
                lista.Add(i.Id.ToString(), i.Linha);
            }
            cbLinhasTelefone.DataSource = new BindingSource(lista, null);
        }

        private bool ValidaItem()
        {
            if(cbTipoDespesa.SelectedIndex < 1)
            {
                MessageBox.Show("Selecionar tipo da despesa");
                cbTipoDespesa.Focus();
                return false;
            }
            if(filial == null)
            {
                MessageBox.Show("Filial não informada");
                btnFilial.Focus();
                return false;
            }
            if (Formatacao.StringToDouble(txtItemValorFinal.Text) == 0)
            {
                MessageBox.Show("Valor do item da despesa está errado.");
                txtItemValorFinal.Focus();
                return false;
            }

            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (ValidaItem())
            {

            }
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {

        }

        private void btnLimparItem_Click(object sender, EventArgs e)
        {
            LimparItem();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {

        }

        private void btnLinhaContrato_Click(object sender, EventArgs e)
        {
            frmLinhaCobrancaPesquisa tela = new frmLinhaCobrancaPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.TelefoneCobranca != null)
            {
                telefone = instancia.TelefoneCobranca;
                instancia.TelefoneCobranca = null;
                txtLinhaContrato.Text = telefone.LinhaCobranca;
                TelefoneLinhasApp linhaApp = new TelefoneLinhasApp();
                IEnumerable<TelefoneLinha> lista = linhaApp.Get(x => x.TelefoneCobranca.Id == telefone.Id && x.Situacao.Equals("A"));

                foreach (var i in lista)
                {
                    listaLinhas.Add(i.Id, i);
                }
                cbLinhasTelefone.Enabled = true;
                btnAddLinha.Enabled = true;
                CarregarLinhas();

            }
            else
            {
                telefone = null;
                txtLinhaContrato.Clear();
                listaLinhas = new Dictionary<int, TelefoneLinha>();
                cbLinhasTelefone.Enabled = false;
                btnAddLinha.Enabled = false;
                CarregarLinhas();
            }
        }

        private void btnAddTipoDespesa_Click(object sender, EventArgs e)
        {
            frmDespesaTipo tela = new frmDespesaTipo();
            tela.ShowDialog();
            tela.Dispose();
            CarregarDespesas();
        }

        private void btnAddLinha_Click(object sender, EventArgs e)
        {
            frmLinhas tela = new frmLinhas();
            tela.ShowDialog();
            tela.Dispose();

            if (telefone != null)
            {
                TelefoneLinhasApp linhaApp = new TelefoneLinhasApp();
                IEnumerable<TelefoneLinha> lista = linhaApp.Get(x => x.TelefoneCobranca.Id == telefone.Id && x.Situacao.Equals("A"));
                listaLinhas = new Dictionary<int, TelefoneLinha>();
                foreach (var i in lista)
                {
                    listaLinhas.Add(i.Id, i);
                }
                CarregarLinhas();
            }
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionarioPesquisa tela = new frmFuncionarioPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.funcionario != null)
            {
                funcionario = instancia.funcionario;
                instancia.funcionario = null;
                txtFuncionario.Text = funcionario.Nome;
                filial = funcionario.Filial;
                txtFilial.Text = filial.Nome;

                foreach(var i in listaLinhas.Values)
                {
                    if(i.Funcionario != null)
                    {
                        if(i.Funcionario.Id == funcionario.Id)
                        {
                            if(cbLinhasTelefone.SelectedIndex < 1)
                            {
                                cbLinhasTelefone.SelectedValue = i.Id.ToString();
                            }
                        }
                    }
                }

            }
            else
            {
                funcionario = null;
                txtFuncionario.Clear();
            }
        }

        private void btnAddFilial_Click(object sender, EventArgs e)
        {

        }

        private void grid_CellMouseDoubleClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {

        }

        private void ckRateio_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (ckRateio.Checked)
            {
                txtItemRateiro.Clear();
                txtItemRateiro.Enabled = false;
            }
            else
            {
                txtItemRateiro.Enabled = true;
            }
        }

        private void txtDataInicial_Leave(object sender, EventArgs e)
        {   
            txtDataFinal.Value = txtDataInicial.Value.AddMonths(1).AddDays(-1);
        }

        private void txtValorTitulo_TextChanged(object sender, EventArgs e)
        {
            Formatacao.MoedaCampo(ref txtValorTitulo);
            if (!txtValorTitulo.Text.Trim().Equals(""))
            {
                txtValorTotal.Text = Formatacao.DoubleToString(double.Parse(txtValorTitulo.Text));
            }
        }

        private void txtValorTotal_TextChanged(object sender, EventArgs e)
        {
            Formatacao.MoedaCampo(ref txtValorTotal);
        }

        private void txtValorTitulo_Leave(object sender, EventArgs e)
        {
            CalculaDiferenca();
        }

        private void txtValorTotal_Leave(object sender, EventArgs e)
        {
            CalculaDiferenca();
        }

        private void txtValorTitulo_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            Formatacao.SoNumero(e);
        }

        private void txtValorTotal_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            Formatacao.SoNumero(e);
        }

        private void txtReferencia_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            Formatacao.SoNumero(e);
        }

        private void txtItemValorDespesa_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            Formatacao.SoNumero(e);
        }

        private void txtItemValorFinal_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            Formatacao.SoNumero(e);
        }

        private void txtItemRateiro_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            Formatacao.SoNumero(e);
        }

        private void txtItemValorDespesa_TextChanged(object sender, EventArgs e)
        {
            Formatacao.MoedaCampo(ref txtItemValorDespesa);
            if (!txtValorTitulo.Text.Trim().Equals(""))
            {
                txtItemValorFinal.Text = Formatacao.DoubleToString(double.Parse(txtItemValorDespesa.Text));
            }
        }

        private void txtItemValorFinal_TextChanged(object sender, EventArgs e)
        {
            Formatacao.MoedaCampo(ref txtItemValorFinal);
        }

        private void btnFilial_Click(object sender, EventArgs e)
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

        private void cbLinhasTelefone_Leave(object sender, EventArgs e)
        {
            CarregaDadosLinha();
            CarregarLinhas();
        }

        private void Buscar()
        {
            /*
            numeroEditar = Convert.ToInt32(gridItens.SelectedRows[0].Cells[0].Value.ToString());
            item = listaItem[numeroEditar];
            produto = item.Produto;
            txtProduto.Text = produto.Nome;
            txtQuantidade.Text = item.Quantidade.ToString();
            cbCentroCusto.SelectedValue = item.CentroCusto.Id.ToString();

            if (item.TipoProduto.Equals("N"))
            {
                rdNovo.Checked = true;
            }
            else
            {
                rdUsado.Checked = true;
            }


            btnItemEditar.Enabled = true;
            btnItemExcluir.Enabled = true;
            btnItemAdicionar.Enabled = false;
            */
        }

      
        private void cbLinhasTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtro = filtro + e.KeyChar.ToString();
            Dictionary<string, string> lista = new Dictionary<string, string>();

            lista.Add("", "");

            foreach (var i in listaLinhas.Values)
            {
                if (i.Linha.Contains(filtro))
                {
                    lista.Add(i.Id.ToString(), i.Linha);
                }
            }
            cbLinhasTelefone.DataSource = new BindingSource(lista, null);
        }

        
        private void cbLinhasTelefone_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaDadosLinha();
        }
    }
}
