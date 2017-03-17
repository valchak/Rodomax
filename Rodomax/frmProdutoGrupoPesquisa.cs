using System.Collections.Generic;
using System.Windows.Forms;
using Modelo;
using System;
using Aplicacao;
using Ferramenta;

namespace UI
{
    public partial class frmProdutoGrupoPesquisa : UI.ModelConsulta
    {
        private ProdutoGrupoApp app;
        Singleton instancia = Singleton.GetInstance;
        public frmProdutoGrupoPesquisa()
        {
            InitializeComponent();
            app = new ProdutoGrupoApp();
            gridPesquisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnFiltrar_Click(object sender, System.EventArgs e)
        {
            gridPesquisa.DataSource = null;
            gridPesquisa.ResetBindings();
            gridPesquisa.Rows.Clear();
            ProdutoGrupo grupo = new ProdutoGrupo();
            grupo.Nome = txtPesquisa.Text.Trim();
            IEnumerable<ProdutoGrupo> lista = app.Get(x => x.Nome.Contains(grupo.Nome));
            foreach (var g in lista)
            {
                int n = gridPesquisa.Rows.Add();
                gridPesquisa.Rows[n].Cells[0].Value = g.Id;
                gridPesquisa.Rows[n].Cells[1].Value = g.Nome;
                gridPesquisa.Refresh();
            }
        }

        private void btnCriarNovo_Click(object sender, System.EventArgs e)
        {

        }

        private void btnSelecionarPesquisa_Click(object sender, System.EventArgs e)
        {
            try
            {
                instancia.produtoGrupo = app.Find(Convert.ToInt32(gridPesquisa.SelectedRows[0].Cells[0].Value.ToString()));
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro: " + exception.Message);
            }
        }

        private void gridPesquisa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gridPesquisa.Rows.Count > 0)
            {
                try
                {
                    instancia.produtoGrupo = app.Find(Convert.ToInt32(gridPesquisa.SelectedRows[0].Cells[0].Value.ToString()));
                    this.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Erro: " + exception.Message);
                }

            }
        }
    }
}
