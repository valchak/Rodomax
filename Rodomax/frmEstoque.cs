using Aplicacao;
using Modelo;
using System;
using System.Collections.Generic;
using MMLib.Extensions;
using System.Windows.Forms;
using System.Linq;
using UI;
using Ferramenta;

namespace Rodomax
{
    public partial class frmEstoque : UI.ModelForm
    {
        EstoqueApp app;
        Singleton instancia = Singleton.GetInstance;

        public frmEstoque()
        {
            InitializeComponent();
            gridPesquisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            limparCampos();
        }

        private void limparCampos()
        {
            
            app = new EstoqueApp();

            txtFilial.Clear();
            txtProduto.Clear();
            rdNovo.Checked = true;

        }

        public void PopulaGrid()
        {
           
            Func<Estoque, bool> predicate;
            predicate = x => x.Filial.Nome.Contains(txtFilial.Text.Trim().RemoveDiacritics().ToUpper()) && x.Produto.Nome.Contains(txtProduto.Text.Trim().RemoveDiacritics().ToUpper());
            if (rdNovo.Checked)
            {
                predicate =  x => x.Filial.Nome.Contains(txtFilial.Text.Trim().RemoveDiacritics().ToUpper()) 
                && x.Produto.Nome.Contains(txtProduto.Text.Trim().RemoveDiacritics().ToUpper())
                && x.QuantidadeNovo > 0;
            }
            if (rdUsado.Checked)
            {
                predicate = x => x.Filial.Nome.Contains(txtFilial.Text.Trim().RemoveDiacritics().ToUpper())
                && x.Produto.Nome.Contains(txtProduto.Text.Trim().RemoveDiacritics().ToUpper())
                && x.QuantidadeUsado > 0;
            }

            IEnumerable<Estoque> lista = app.Get(predicate);


            Invoke(new Action(() =>
            {
                gridPesquisa.DataSource = null;
                gridPesquisa.ResetBindings();
                gridPesquisa.Rows.Clear();
                if (lista.Count() > 0)
                {
                    foreach (var p in lista)
                    {
                        int n = this.gridPesquisa.Rows.Add();
                        gridPesquisa.Rows[n].Cells[0].Value = p.Filial.Nome;
                        gridPesquisa.Rows[n].Cells[1].Value = p.Produto.Nome;
                        gridPesquisa.Rows[n].Cells[2].Value = p.QuantidadeNovo;
                        gridPesquisa.Rows[n].Cells[3].Value = p.QuantidadeUsado;
                    }

                    gridPesquisa.Refresh();
                }
                else
                {
                    MessageBox.Show("Nenhum item encontrado.");
                }
            }));
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            app = new EstoqueApp();
            PopulaGrid();
        }

        private void btnFilial_Click(object sender, EventArgs e)
        {
            frmFilialPesquisa tela = new frmFilialPesquisa();
            tela.ShowDialog();
            tela.Dispose();
            if (instancia.filial != null)
            {
                txtFilial.Text = instancia.filial.Nome;
            }
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frmProdutoPesquisa tela = new frmProdutoPesquisa();
            tela.ShowDialog();
            tela.Dispose();
            if (instancia.produto != null)
            {
                txtProduto.Text = instancia.produto.Nome;
            }
        }
    }
}
