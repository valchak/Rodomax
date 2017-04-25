using Aplicacao;
using MMLib.Extensions;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rodomax
{
    public partial class frmPatrimonio : UI.ModelForm
    {
        _Singleton instancia = _Singleton.GetInstance;
        PatrimonioApp app;
        Patrimonio patrimonio;
        
        public frmPatrimonio()
        {
            InitializeComponent();
            gridPesquisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Limpar();
        }
        private void Limpar()
        {
            app = new PatrimonioApp();
            patrimonio = new Patrimonio();

            tab.Enabled = false;
            txtCentroCusto.Clear();
            txtData.Value = DateTime.Now;
            txtDescricao.Clear();
            txtFilial.Clear();
            txtFuncionario.Clear();
            txtGrupo.Clear();
            txtObservacao.Clear();
            txtPatrimonio.Clear();
            txtSerie.Clear();
            txtValor.Text = "0,00";
            rbAtivo.Checked = true;

            gridPesquisa.DataSource = null;
            gridPesquisa.ResetBindings();
            gridPesquisa.Rows.Clear();

        }
        private void Salvar()
        {
            patrimonio.PatrimonioNumero = txtPatrimonio.Text.Trim().RemoveDiacritics().ToUpper();
            patrimonio.Descricao = txtDescricao.Text.Trim().RemoveDiacritics().ToUpper();
            patrimonio.NumeroSerie = txtSerie.Text.Trim().RemoveDiacritics().ToUpper();
            patrimonio.Observacao = txtObservacao.Text.Trim().RemoveDiacritics();

            if (rbAtivo.Checked)
            {
                patrimonio.Situacao = "A";
            }
            else
            {
                patrimonio.Situacao = "I";
            }

            patrimonio.DataAquisicao = txtData.Value;
            patrimonio.ValorAquisicao =  Formatacao.StringToDouble(txtValor.Text);
           

            if (ValidaNota())
            {
                try
                {
                    switch (Formatacao.MensagemInserir())
                    {
                        case DialogResult.Yes:
                            if (patrimonio.Id == 0)
                            {
                                app.Adicionar(patrimonio);
                                MessageBox.Show("Patrimonio salva com sucesso: Código " + patrimonio.PatrimonioNumero);

                            }
                            else
                            {
                                app.Atualizar(patrimonio);
                                MessageBox.Show("Patrimonio alterada com sucesso.");
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

        public void BuscarPatrimonio()
        {
            IEnumerable<Patrimonio> lista =  app.Get(x => x.PatrimonioNumero == txtPatrimonio.Text.Trim().RemoveDiacritics().ToUpper());
            if (lista.Any())
            {
                patrimonio.Id = lista.First().Id;
                patrimonio.Filial = lista.First().Filial;
                patrimonio.CentroCusto = lista.First().CentroCusto;
                patrimonio.Funcionario = lista.First().Funcionario;
                patrimonio.PatrimonioGrupo = lista.First().PatrimonioGrupo;
                txtDescricao.Text = lista.First().Descricao;
                txtCentroCusto.Text = patrimonio.CentroCusto.Nome;
                txtData.Value = lista.First().DataAquisicao;
                txtFilial.Text = patrimonio.Filial.Nome;
                txtGrupo.Text = patrimonio.PatrimonioGrupo.Descricao;
                txtSerie.Text = lista.First().NumeroSerie;
                txtValor.Text = Formatacao.DoubleToString(lista.First().ValorAquisicao);

                if (patrimonio.Funcionario != null)
                {
                    txtFuncionario.Text = patrimonio.Funcionario.Nome;
                }
                if (lista.First().Situacao.Equals("A"))
                {
                    rbAtivo.Checked = true;
                }
                else
                {
                    rbInativo.Checked = true;
                }
                txtObservacao.Text = lista.First().Observacao;
                tab.Enabled = true;



                Invoke(new Action(() =>
                {
                    gridPesquisa.DataSource = null;
                    gridPesquisa.ResetBindings();
                    gridPesquisa.Rows.Clear();
                    if (lista.First().ListaHistorico.Count() > 0)
                    {
                        foreach (var p in lista.First().ListaHistorico)
                        {
                            int n = this.gridPesquisa.Rows.Add();
                            gridPesquisa.Rows[n].Cells[0].Value = p.Data;
                            gridPesquisa.Rows[n].Cells[1].Value = p.Historico;
                            gridPesquisa.Rows[n].Cells[2].Value = p.Valor;
                        }

                        gridPesquisa.Refresh();
                    }
                }));


            }
            else
            {
                switch (MessageBox.Show("Deseja cadastrar um novo item?", "Patrimônio Não Encontrado", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        tab.Enabled = true;
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }

        public bool ValidaNota()
        {
            if (patrimonio.Filial.Id <= 0)
            {
                MessageBox.Show("Filial inválido");
                return false;
            }

            if (patrimonio.CentroCusto.Id <= 0)
            {
                MessageBox.Show("Centro de Custo Inválido ");
                return false;
            }

            if (patrimonio.PatrimonioGrupo.Id <= 0)
            {
                MessageBox.Show("Grupo Inválida");
                return false;
            }
            if (txtDescricao.Text.Trim().Equals(""))
            {
                MessageBox.Show("Descrição do patrimônio inválida");
                return false;
            }
            if (txtPatrimonio.Text.Trim().Equals(""))
            {
                MessageBox.Show("Código do patrimônio inválido");
                return false;
            }
            return true;
        }
        
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
            tab.Enabled = true;
        }

        private void btnFilial_Click(object sender, EventArgs e)
        {
            frmFilialPesquisa tela = new frmFilialPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.filial != null)
            {
                patrimonio.Filial = instancia.filial;
                instancia.filial = null;
                txtFilial.Text = patrimonio.Filial.Nome;
            }
        }

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            frmPatrimonioGrupoPesquisa tela = new frmPatrimonioGrupoPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.patrimonioGrupo != null)
            {
                patrimonio.PatrimonioGrupo = instancia.patrimonioGrupo;
                instancia.patrimonioGrupo = null;
                txtGrupo.Text = patrimonio.PatrimonioGrupo.Descricao;
            }
        }

        private void btnCentroCusto_Click(object sender, EventArgs e)
        {
            frmCentroCustoPesquisa tela = new frmCentroCustoPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.centroCusto != null)
            {
                patrimonio.CentroCusto = instancia.centroCusto;
                instancia.centroCusto = null;
                txtCentroCusto.Text = patrimonio.CentroCusto.Nome;
            }
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionarioPesquisa tela = new frmFuncionarioPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.funcionario != null)
            {
                patrimonio.Funcionario = instancia.funcionario;
                instancia.funcionario = null;
                txtFuncionario.Text = patrimonio.Funcionario.Nome;
            }
        }

        private void btnRenoverFunc_Click(object sender, EventArgs e)
        {
            patrimonio.Funcionario = null;
            txtFuncionario.Clear();
        }
        
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!txtPatrimonio.Text.Trim().Equals(""))
            {
                BuscarPatrimonio();
            } else
            {
                MessageBox.Show("Informe o código do patrimonio para pesquisar", "Atenção");
            }
        }
        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            Formatacao.MoedaCampo(ref txtValor);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void gridPesquisa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gridPesquisa.Rows.Count > 0)
            {
                try
                {
                    MessageBox.Show(gridPesquisa.SelectedRows[0].Cells[1].Value.ToString());
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Erro: " + exception.Message);
                }
            }
        }
    }
}