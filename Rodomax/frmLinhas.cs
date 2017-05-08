using Aplicacao;
using MMLib.Extensions;
using Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Rodomax
{
    public partial class frmLinhas : UI.ModelForm
    {
        _Singleton instancia = _Singleton.GetInstance;
        private TelefoneApp app;
        TelefoneLinha linha;
        private TelefoneCobranca Obj;

        private int numeroItens = 0;
        private int numeroEditar = 0;

        private IDictionary<int, TelefoneLinha> listaItem;
        private List<TelefoneLinha> listaExcluir;
        
        public frmLinhas()
        {
            InitializeComponent();
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Limpar();
        }

        private void Salvar()
        {
            Obj.LinhaCobranca = txtLinhaCobranca.Text.Trim().RemoveDiacritics().ToUpper();
            Obj.Cnpj = txtCnpjCobranca.Text.Trim().RemoveDiacritics().ToUpper().Replace(",",".");
            Obj.DiaVencimento = int.Parse(cbDiaCobranca.Text);
            Obj.listaExcluir = listaExcluir;
            
            if (rdContratoAtivo.Checked)
            {
                Obj.Situacao = "A";
            }
            else
            {
                Obj.Situacao = "I";
            }

            if (ValidarContrato())
            {
                try
                {
                    switch (Formatacao.MensagemInserir())
                    {
                        case DialogResult.Yes:
                            if (Obj.Id == 0)
                            {
                                app.Adicionar(Obj);
                                MessageBox.Show("Contrato salvo com sucesso: Código " + Obj.Id);

                            }
                            else
                            {
                                app.Atualizar(Obj);
                                MessageBox.Show("Contrato alterado com sucesso.");
                            }
                            Limpar();
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro Salvar: " + erro.Message);
                }

            }

        }

        private bool ValidarContrato ()
        {
        
            if (Obj.FilialFatura.Id <= 0)
            {
                MessageBox.Show("Filial da Fatura inválida");
                return false;
            }

            if (Obj.Fornecedor.Id <= 0)
            {
                MessageBox.Show("Fornecedor Inválido");
                return false;
            }

            if (Obj.LinhasTelefone == null)
            {
                MessageBox.Show("Nenhuma Linha Cadastrada");
                return false;
            }
            return true;
    
        }

        private bool ValidarLinha()
        {

            if (txtLinhaCobranca.Text.Trim().Equals(""))
            {
                MessageBox.Show("Linha Informada Inválida");
                txtLinha.Focus();
                return false;
            }

            if (txtFilialLinha.Text.Trim().Equals(""))
            {
                MessageBox.Show("Filial Não Informada!");
                btnFilialLinha.Focus();
                return false;
            }
            return true;

        }

        private void Limpar()
        {
            app = new TelefoneApp();
            Obj = new TelefoneCobranca();
            listaItem = new Dictionary<int, TelefoneLinha>();
            listaExcluir = new List<TelefoneLinha>();
            Obj.LinhasTelefone = new List<TelefoneLinha>();

            txtLinhaCobranca.Clear();
            txtFornecedor.Clear();
            txtFilialCobranca.Clear();
            txtCnpjCobranca.Clear();
            cbDiaCobranca.SelectedIndex = 0;
            txtObservacao.Clear();
            rdContratoAtivo.Checked = true;
            tab.Enabled = false;
            this.AlteraBotoes(1);
            btnNovo.Enabled = true;
            LimparLinhas();
        }

        private void LimparLinhas()
        {
            linha = new TelefoneLinha();
            txtLinha.Clear();
            rdContratoAtivo.Checked = true;
            txtFilialLinha.Clear();
            txtFuncionario.Clear();
            btnExcluirLinha.Enabled = false;
            btnAddLinha.Text = "Adicionar";
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            grid.DataSource = null;
            grid.ResetBindings();
            grid.Rows.Clear();

            if (Obj.LinhasTelefone != null)
            {
                if (Obj.LinhasTelefone.Count > 0)
                {
                    TelefoneLinhasApp linhaApp = new TelefoneLinhasApp();

                    foreach (var i in Obj.LinhasTelefone)
                    {
                        int n = this.grid.Rows.Add();

                        IEnumerable<TelefoneLinha> lista = linhaApp.Get(x => x.Id == i.Id);
                        foreach (var y in lista)
                        {
                            i.Filial = y.Filial;
                            i.Funcionario = i.Funcionario;
                        }

                        grid.Rows[n].Cells[0].Value = i.Id;
                        grid.Rows[n].Cells[1].Value = i.Linha;

                        if (i.Filial != null)
                        {
                            grid.Rows[n].Cells[2].Value = i.Filial.Nome;
                        }
                        if(i.Funcionario != null)
                        {
                            grid.Rows[n].Cells[3].Value = i.Funcionario.Nome;
                        }
                        
                        switch (i.Situacao)
                        {
                            case "1":
                            case "A":
                                this.grid.Rows[n].Cells[4].Value = "Ativo";
                                break;
                            case "2":
                            case "I":
                                this.grid.Rows[n].Cells[4].Value = "Inativo";
                                break;
                            default:
                                this.grid.Rows[n].Cells[4].Value = "";
                                break;
                        }
                    }
                    grid.Refresh();
                }
            }
        }

        private void btnPesquisar_Click(object sender, System.EventArgs e)
        {
            frmLinhaCobrancaPesquisa tela = new frmLinhaCobrancaPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.TelefoneCobranca != null)
            {
                tab.Enabled = true;
                Obj = instancia.TelefoneCobranca;
                txtLinhaCobranca.Text = Obj.LinhaCobranca;
                txtFornecedor.Text = Obj.Fornecedor.RazaoSocial;
                txtFilialCobranca.Text = Obj.FilialFatura.Nome;
                txtCnpjCobranca.Text = Obj.Cnpj;
                cbDiaCobranca.SelectedText = Obj.DiaVencimento.ToString();
                if (Obj.Situacao.Equals("A"))
                {
                    rdContratoAtivo.Checked = true;
                }
                else
                {
                    rdContratoInativo.Checked = true;
                }
                txtObservacao.Text = Obj.Observacao;

                this.AlteraBotoes(3);
                
                instancia.TelefoneCobranca = null;

                /*   foreach (var i in Obj.LinhasTelefone)
                   {
                       listaLinhas.Add(i.Id, i);
                   }
                   PopularGrids();
                */
                AtualizaGrid();
            }
        }

        private void btnNovo_Click(object sender, System.EventArgs e)
        {
            Limpar();
            this.AlteraBotoes(2);
            tab.Enabled = true;
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            Limpar();
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            Salvar();
        }

        private void btnAddLinha_Click(object sender, EventArgs e)
        {
            if (ValidarLinha())
            {
                linha.Linha = txtLinha.Text.Trim().RemoveDiacritics().ToUpper();
                if (rdLinhaAtiva.Checked)
                {
                    linha.Situacao = "A";
                }
                if (rdLinhaBloqueada.Checked)
                {
                    linha.Situacao = "B";
                }
                if (rdLinhaCancelada.Checked)
                {
                    linha.Situacao = "C";
                }
                if (linha.Id == 0) {
                    Obj.LinhasTelefone.Add(linha);
                }
                else
                {
                    Obj.LinhasTelefone.Remove(linha);
                    Obj.LinhasTelefone.Add(linha);
                }

                LimparLinhas();
            }
        }

        private void grid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (grid.Rows.Count > 0)
            {
                try
                {
                    numeroEditar = Convert.ToInt32(grid.SelectedRows[0].Cells[0].Value.ToString());

                    foreach(var i in Obj.LinhasTelefone)
                    {
                        if(i.Id == numeroEditar)
                        {
                            linha = i;
                        }
                    }
                    
                    txtLinha.Text = linha.Linha;
                    txtFilialLinha.Text = linha.Filial.Nome;

                    if (linha.Situacao.Equals("A"))
                    {
                        rdLinhaAtiva.Checked = true;
                    }
                    if (linha.Situacao.Equals("B"))
                    {
                        rdLinhaBloqueada.Checked = true;
                    }
                    if (linha.Situacao.Equals("C"))
                    {
                        rdLinhaCancelada.Checked = true;
                    }

                    btnAddLinha.Text = "Editar";
                    btnExcluirLinha.Enabled = true;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Erro: " + exception.Message);
                }
            }
        }

        private void btnLimparLinha_Click(object sender, EventArgs e)
        {
            LimparLinhas();
        }

        private void btnExcluirLinha_Click(object sender, EventArgs e)
        {
           
            switch (Formatacao.MensagemExcluir())
            {
                case DialogResult.Yes:
                    Obj.LinhasTelefone.Remove(linha);
                    if (linha.Id > 0)
                    {
                        listaExcluir.Add(linha);
                    }
                    LimparLinhas();
                    break;
                case DialogResult.No:
                    break;
            }

            LimparLinhas();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedorPesquisa tela = new frmFornecedorPesquisa();
            tela.ShowDialog();
            tela.Dispose();
            if (instancia.fornecedor != null)
            {
                Obj.Fornecedor = instancia.fornecedor;
                txtFornecedor.Text = Obj.Fornecedor.RazaoSocial;
                instancia.fornecedor = null;
            }
        }

        private void btnFilialContrato_Click(object sender, EventArgs e)
        {
            frmFilialPesquisa tela = new frmFilialPesquisa();
            tela.ShowDialog();
            tela.Dispose();
            if (instancia.filial != null)
            {
                Obj.FilialFatura = instancia.filial;
                txtFilialCobranca.Text = Obj.FilialFatura.Nome;
                instancia.filial = null;
            }
        }

        private void btnFilialLinha_Click(object sender, EventArgs e)
        {
            frmFilialPesquisa tela = new frmFilialPesquisa();
            tela.ShowDialog();
            tela.Dispose();
            if (instancia.filial != null)
            {
                linha.Filial = instancia.filial;
                txtFilialLinha.Text = linha.Filial.Nome;
                instancia.filial = null;
            }

        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionarioPesquisa tela = new frmFuncionarioPesquisa();
            tela.ShowDialog();
            tela.Dispose();
            if (instancia.funcionario != null)
            {
                linha.Funcionario = instancia.funcionario;
                txtFuncionario.Text = linha.Funcionario.Nome;
                instancia.funcionario = null;
            }
        }

    }
}
