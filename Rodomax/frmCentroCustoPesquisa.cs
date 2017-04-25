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
using System.Threading;
using System.Windows.Forms;

namespace Rodomax
{
    public partial class frmCentroCustoPesquisa : UI.ModelConsulta
    {
        private CentroCustoApp app;
        _Singleton instancia = _Singleton.GetInstance;

        public frmCentroCustoPesquisa()
        {
            InitializeComponent();
            gridPesquisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            app = new CentroCustoApp();
        }


        public void BuscarNoBanco()
        {

            CentroCusto centroCusto = new CentroCusto();

            centroCusto.Nome = txtPesquisa.Text.Trim().RemoveDiacritics().ToUpper();


            IEnumerable<CentroCusto> lista = app.Get(x => x.Nome.Contains(centroCusto.Nome));


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
                        gridPesquisa.Rows[n].Cells[0].Value = p.Id;
                        gridPesquisa.Rows[n].Cells[1].Value = p.Nome;
                    }

                    gridPesquisa.Refresh();
                }
                else
                {
                    MessageBox.Show("Nenhum item encontrado.");
                }
            }));


        }

        private void SelecionarObjeto()
        {
            try
            {
                instancia.centroCusto = app.Find(Convert.ToInt32(gridPesquisa.SelectedRows[0].Cells[0].Value.ToString()));
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro: " + exception.Message);
            }
        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var th = new Thread(new ThreadStart(this.BuscarNoBanco));
            th.Start();
        }

        private void btnCriarNovo_Click(object sender, EventArgs e)
        {
            frmCentroCusto tela = new frmCentroCusto();
            tela.ShowDialog();
            tela.Dispose();
        }

        private void btnSelecionarPesquisa_Click(object sender, EventArgs e)
        {
            SelecionarObjeto();
        }

        private void gridPesquisa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gridPesquisa.Rows.Count > 0)
            {
                SelecionarObjeto();
            }
        }
        
    }
}
