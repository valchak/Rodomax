using System;
using System.Collections.Generic;
using Aplicacao;
using Modelo;
using System.Windows.Forms;
using MMLib.Extensions;
using System.Linq;

namespace Rodomax
{
    public partial class frmDespesa : UI.ModelForm
    {
        _Singleton instancia = _Singleton.GetInstance;


        private DespesaApp app;
        private Despesa despesa;
        private Dictionary<int, DespesaTipo> listaDepesaTipo;
        private Dictionary<int, TelefoneLinha> listaLinhas;
        private Dictionary<int, DespesaDetalhes> listaItens;
        private List<DespesaDetalhes> listaExcliur;
        private DespesaDetalhes item;
        private Funcionario funcionario;
        private Filial filial;
        private TelefoneCobranca telefone;
        private TelefoneLinha linha;
        private string filtro = "";
        private int sequencia = 0;
        private int editar = 0;
        private double lbValorDespesa = 0;
        private double lbValorDiferenca = 0;
        private double lbValorTotal = 0;

        public frmDespesa()
        {
            InitializeComponent();
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Limpar();
        }

        private void Limpar() {
            sequencia = 1;
            app = new DespesaApp();
            despesa = new Despesa();
            listaDepesaTipo = new Dictionary<int, DespesaTipo>();
            listaLinhas = new Dictionary<int, TelefoneLinha>();
            listaItens = new Dictionary<int, DespesaDetalhes>();
            listaExcliur = new List<DespesaDetalhes>();
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
            CarregarLinhas();

        }
        private void LimparItem()
        {
            editar = 0;
            item = new DespesaDetalhes();
            txtItemValorFinal.Text = "0,00";
            txtItemValorDespesa.Text = "0,00";
            txtQuantidade.Text = "1";
            txtFuncionario.Clear();
            txtObservacao.Clear();
            funcionario = null;
            if(telefone != null)
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
            AtualizarGrid();
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
                        funcionario = linha.Funcionario;
                        txtFuncionario.Text = funcionario.Nome;
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
            listaLinhas = new Dictionary<int, TelefoneLinha>();
            
            if(telefone != null)
            {
                TelefoneLinhasApp linhaApp = new TelefoneLinhasApp();
                IEnumerable<TelefoneLinha> listax = linhaApp.Get(x => x.TelefoneCobranca.Id == telefone.Id && x.Situacao.Equals("A"));

                foreach (var i in listax)
                {
                    listaLinhas.Add(i.Id, i);
                }
                cbLinhasTelefone.Enabled = true;
                btnAddLinha.Enabled = true;
            }
            else
            {
                cbLinhasTelefone.Enabled = false;
                btnAddLinha.Enabled = false;
            }

            Dictionary<string, string> lista = new Dictionary<string, string>();
            lista.Add("", "");

            foreach (var i in listaLinhas.Values)
            {
                lista.Add(i.Id.ToString(), i.Linha);
            }
            cbLinhasTelefone.DataSource = new BindingSource(lista, null);
        }
        private void AtualizarGrid()
        {
            grid.DataSource = null;
            grid.ResetBindings();
            grid.Rows.Clear();
            lbValorDespesa = 0;
            lbValorDiferenca = 0;
            lbValorTotal = 0;
            foreach (var i in listaItens)
            {
                int n = this.grid.Rows.Add();
                grid.Rows[n].Cells[0].Value = i.Key;
                grid.Rows[n].Cells[1].Value = i.Value.Filial.Nome;
                grid.Rows[n].Cells[2].Value = i.Value.DespesaTipo.Descircao;
                if (i.Value.TelefoneLinha != null)
                {
                    grid.Rows[n].Cells[3].Value = i.Value.TelefoneLinha.Linha;
                }
                if(i.Value.Funcionario != null)
                {
                    grid.Rows[n].Cells[4].Value = i.Value.Funcionario.Nome;
                }
                grid.Rows[n].Cells[5].Value = i.Value.ValorUnitario;
                grid.Rows[n].Cells[6].Value = i.Value.ValorTotal-i.Value.ValorUnitario;
                grid.Rows[n].Cells[7].Value = i.Value.ValorTotal;
                lbValorDespesa = lbValorDespesa + i.Value.ValorUnitario;
                lbValorDiferenca = lbValorDiferenca + (i.Value.ValorTotal - i.Value.ValorUnitario);
                lbValorTotal = lbValorTotal + i.Value.ValorTotal;
            }
            grid.Refresh();
            lbDespesa.Text = Formatacao.DoubleToString(lbValorDespesa);
            lbDiferenca.Text = Formatacao.DoubleToString(lbValorDiferenca);
            lbTotal.Text = Formatacao.DoubleToString(lbValorTotal);
        }

        private bool Validar()
        {
            return true;
        }

        private bool ValidaItem()
        {
            if (rdRateioNao.Checked)
            {
                if (Formatacao.StringToDouble(txtItemValorFinal.Text) == 0)
                {
                    MessageBox.Show("Valor do item da despesa está errado.");
                    txtItemValorFinal.Focus();
                    return false;
                }
            }
            if(filial == null)
            {
                MessageBox.Show("Filial não informada");
                btnFilial.Focus();
                return false;
            }
            
            if (cbTipoDespesa.SelectedIndex < 1)
            {
                MessageBox.Show("Selecionar tipo da despesa");
                cbTipoDespesa.Focus();
                return false;
            }

            return true;
        }
        private void BuscarDespesa()
        {
            if (despesa.Fornecedor != null && !txtDocumento.Text.Equals(""))
            {

                IEnumerable<Despesa> lista = app.Get(x => x.Fornecedor.Id == despesa.Fornecedor.Id && x.Documento == txtDocumento.Text.Trim().RemoveDiacritics().ToUpper());

                if (lista.Any())
                {
                    despesa = lista.First();
                    listaItens = new Dictionary<int, DespesaDetalhes>();
                    if (despesa.TelefoneCobranca != null)
                    {
                        txtLinhaContrato.Text = despesa.TelefoneCobranca.LinhaCobranca;
                        telefone = despesa.TelefoneCobranca;
                        CarregarLinhas();
                    }
                    txtValorTitulo.Text = Formatacao.DoubleToString(despesa.ValorTitulo);
                    txtValorTotal.Text = Formatacao.DoubleToString(despesa.ValorTotal);

                    txtDataEmissao.Value = despesa.DataEmissao;
                    txtDataVencimento.Value = despesa.DataVencimento;
                    txtDataInicial.Value = despesa.DataInicio;
                    txtDataFinal.Value = despesa.DataFim;
                    DespesaItensApp itemApp = new DespesaItensApp();
                    foreach (var i in despesa.DespesaDetalhes)
                    {
                        DespesaDetalhes novo = itemApp.Get(x => x.Id == i.Id).First();

                        try
                        {
                            listaItens.Add(sequencia++, novo);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            throw;
                        }

                    }
                    CalculaDiferenca();
                    AtualizarGrid();
                }
                else
                {
                    Limpar();
                    CalculaDiferenca();
                }
            }
        }

        private void CalcularRateio()
        {
            if (rdRateioIgual.Checked)
            {
                double valor = double.Parse(txtValorTotal.Text) / listaItens.Count;
                foreach (var i in listaItens.Values)
                {
                    i.Rateio = "I";
                    i.ValorUnitario = valor;
                    i.ValorTotal = valor;
                }
            }
            if (rdRateioProporcional.Checked)
            {
                int qtdeTotal = 0;
                foreach (var i in listaItens.Values)
                {
                    qtdeTotal = qtdeTotal + i.Quantidade;
                }
                double valorTitulo = double.Parse(txtValorTitulo.Text);
                double valorTotal = double.Parse(txtValorTotal.Text);
                foreach (var i in listaItens.Values)
                {
                    i.Rateio = "P";
                    i.ValorUnitario = (valorTitulo / qtdeTotal) * i.Quantidade;
                    i.ValorTotal = (valorTotal / qtdeTotal) * i.Quantidade;
                }
            }
        }

        private void Rateio()
        {
            if (rdRateioNao.Checked)
            {
                txtQuantidade.Enabled = true;
                txtItemValorDespesa.Enabled = true;
                txtItemValorFinal.Enabled = true;
            }
            if (rdRateioIgual.Checked)
            {
                txtQuantidade.Enabled = false;
                txtItemValorDespesa.Enabled = false;
                txtItemValorFinal.Enabled = false;
                txtQuantidade.Text = "1";
                txtItemValorDespesa.Text = "0,00";
                txtItemValorFinal.Text = "0,00";
            }
            if (rdRateioProporcional.Checked)
            {
                txtQuantidade.Enabled = true;
                txtItemValorDespesa.Enabled = false;
                txtItemValorFinal.Enabled = false;
                txtQuantidade.Text = "1";
                txtItemValorDespesa.Text = "0,00";
                txtItemValorFinal.Text = "0,00";
            }
        }

        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            despesa.DataEmissao = txtDataEmissao.Value;
            despesa.DataVencimento = txtDataVencimento.Value;
            despesa.DataInicio = txtDataInicial.Value;
            despesa.DataFim = txtDataFinal.Value;
            despesa.Documento = txtDocumento.Text.Trim().RemoveDiacritics().ToUpper();
            despesa.ValorTitulo = Formatacao.StringToDouble(txtValorTitulo.Text);
            despesa.ValorTotal = Formatacao.StringToDouble(txtValorTotal.Text);
            despesa.TelefoneCobranca = telefone;
            despesa.DespesaDetalhes = listaItens.Values;
            despesa.listaExcluir = listaExcliur;

            if (Validar())
            {
                try
                {
                    switch (Formatacao.MensagemInserir())
                    {
                        case DialogResult.Yes:
                            if (despesa.Id == 0)
                            {
                                app.Adicionar(despesa);
                                MessageBox.Show("Despesa salva com sucesso: Código " + despesa.Id);

                            }
                            else
                            {
                                app.Atualizar(despesa);
                                MessageBox.Show("Despesa alterada com sucesso.");
                            }
                            Limpar();
                            break;
                        case DialogResult.No:
                            break;
                    }
                    
                } catch (Exception erro)
                {
                    MessageBox.Show("Erro Salvar: " + erro.Message);
                }
                    
            }

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
                item.DespesaTipo = listaDepesaTipo[int.Parse(cbTipoDespesa.SelectedValue.ToString())];
                item.Filial = filial;
                item.Funcionario = funcionario;
                item.Observacao = txtObservacao.Text.Trim().RemoveDiacritics().ToUpper();
                if (rdRateioNao.Checked)
                {
                    item.Rateio = "N";
                    item.Quantidade = int.Parse(txtQuantidade.Text);
                    item.ValorUnitario = Formatacao.StringToDouble(txtItemValorDespesa.Text);
                    item.ValorTotal = Formatacao.StringToDouble(txtItemValorFinal.Text);
                }

                if(telefone != null)
                {
                    item.TelefoneLinha = listaLinhas[int.Parse(cbLinhasTelefone.SelectedValue.ToString())];
                }
                if (editar == 0)
                {
                    listaItens.Add(sequencia++, item);
                }
                else
                {
                    listaItens.Remove(editar);
                    listaItens.Add(editar, item);
                }
                if (!rdRateioNao.Checked)
                {
                    if(telefone != null)
                    {
                        if (MessageBox.Show("Deseja fazer um rateio para todas as contas de telefone? ", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            foreach (var i in listaLinhas.Values)
                            {
                                DespesaDetalhes x = new DespesaDetalhes();
                                x.DespesaTipo = item.DespesaTipo;
                                x.Filial = i.Filial;
                                x.TelefoneLinha = i;
                                x.Funcionario = i.Funcionario;
                                x.Rateio = "I";
                                listaItens.Add(sequencia++, x);
                            }
                        }
                    }

                    CalcularRateio();
                }
                LimparItem();
            }
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            if(item.Id > 0)
            {
                listaExcliur.Add(item);
            }
            listaItens.Remove(editar);
            LimparItem();
        }

        private void btnLimparItem_Click(object sender, EventArgs e)
        {
            LimparItem();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedorPesquisa tela = new frmFornecedorPesquisa();
            tela.ShowDialog();
            tela.Dispose();
            if(instancia.fornecedor != null)
            {
                despesa.Fornecedor = instancia.fornecedor;
                txtFornecedor.Text = despesa.Fornecedor.RazaoSocial;
                instancia.fornecedor = null;
                BuscarDespesa();
            }
            else
            {
                txtFornecedor.Clear();
                despesa.Fornecedor = null;
            }
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
        
        private void grid_CellMouseDoubleClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
            if (grid.Rows.Count > 0)
            {
                try
                {
                    editar = Convert.ToInt32(grid.SelectedRows[0].Cells[0].Value.ToString());
                    item = listaItens[editar];
                    filial = item.Filial;
                    txtFilial.Text = filial.Nome;
                    txtObservacao.Text = item.Observacao;
                    rdRateioNao.Checked = true;
                    txtQuantidade.Text = item.Quantidade.ToString();
                    txtItemValorDespesa.Text = Formatacao.DoubleToString(item.ValorUnitario);
                    txtItemValorFinal.Text = Formatacao.DoubleToString(item.ValorTotal);

                    if (item.Rateio.Equals("P"))
                    {
                        rdRateioProporcional.Checked = true;
                    }
                    if(item.Rateio.Equals("I"))
                    {
                        rdRateioIgual.Checked = true;
                    }
                    txtQuantidade.Text = item.Quantidade.ToString();
                    txtValorTitulo.Text = Formatacao.DoubleToString(item.ValorUnitario);
                    txtValorTotal.Text = Formatacao.DoubleToString(item.ValorTotal);
                    cbTipoDespesa.SelectedValue = item.DespesaTipo.Id.ToString();

                    if(item.TelefoneLinha != null)
                    {
                        cbLinhasTelefone.SelectedValue = item.TelefoneLinha.Id.ToString();
                    }
                    if(item.Funcionario != null)
                    {
                        funcionario = item.Funcionario;
                        txtFuncionario.Text = funcionario.Nome;
                    }
                    btnAddItem.Text = "Alterar";
                    btnItemExcluir.Enabled = true;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Erro: " + exception.Message);
                }
                Rateio();
            }
        }

        private void ckRateio_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            
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
        
        private void txtItemValorDespesa_TextChanged(object sender, EventArgs e)
        {
            Formatacao.MoedaCampo(ref txtItemValorDespesa);
            if (!txtValorTitulo.Text.Trim().Equals(""))
            {
                txtItemValorFinal.Text = Formatacao.DoubleToString(double.Parse(txtItemValorDespesa.Text)*int.Parse(txtQuantidade.Text));
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
            filtro = "";
            if (cbLinhasTelefone.Text.Equals(""))
            {
                CarregarLinhas();
            }
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

            if (!cbLinhasTelefone.Text.Equals(""))
            {
                CarregarLinhas();
                filtro = "";
            }
        }
        
        private void cbLinhasTelefone_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaDadosLinha();
        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            BuscarDespesa();
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            Formatacao.SoNumero(e);
            if (txtQuantidade.Text.Equals(""))
            {
                txtQuantidade.Text = "1";
            }
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (!txtValorTitulo.Text.Trim().Equals(""))
            {
                txtItemValorFinal.Text = Formatacao.DoubleToString(double.Parse(txtItemValorDespesa.Text) * int.Parse(txtQuantidade.Text));
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            Rateio();
        }

        private void rdRateioIgual_Click(object sender, EventArgs e)
        {
            Rateio();
        }

        private void rdRateioProporcional_Click(object sender, EventArgs e)
        {
            Rateio();
        }

        private void rdRateioNao_MouseClick(object sender, MouseEventArgs e)
        {
            Rateio();
        }

        private void rdRateioIgual_MouseClick(object sender, MouseEventArgs e)
        {
            Rateio();
        }

        private void rdRateioProporcional_MouseClick(object sender, MouseEventArgs e)
        {
            Rateio();
        }
    }
}
