using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Aplicacao;
using Ferramenta;
using Modelo;

namespace UI
{
    public partial class frmFilialPesquisa : UI.ModelConsulta
    {
        private FilialApp app;
        Singleton instancia = Singleton.GetInstance;

        public frmFilialPesquisa()
        {
            InitializeComponent();
            app = new FilialApp();
            gridPesquisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

       
        public void Buscar()
        {
            IEnumerable<Filial> lista = app.Get(x => x.Nome.Contains(txtPesquisa.Text.Trim()));

            gridPesquisa.DataSource = null;
            gridPesquisa.ResetBindings();
            gridPesquisa.Rows.Clear();


            foreach (var cidade in lista)
            {
                int n = gridPesquisa.Rows.Add();
                gridPesquisa.Rows[n].Cells[0].Value = cidade.Id;
                gridPesquisa.Rows[n].Cells[1].Value = cidade.Nome;
            }

            gridPesquisa.Refresh();
        }

       
        private void btnCriarNovo_Click(object sender, EventArgs e)
        {
            frmCidade tela = new frmCidade();
            tela.ShowDialog();
            tela.Dispose();
        }

        private void gridPesquisa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gridPesquisa.Rows.Count > 0)
            {
                try
                {
                    instancia.filial = app.Find(Convert.ToInt32(gridPesquisa.SelectedRows[0].Cells[0].Value.ToString()));
                    this.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Erro: "+exception.Message);
                }
               
            }
            
        }

        private void gridPesquisa_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (gridPesquisa.Rows.Count > 0)
            {
                try
                {
                    instancia.filial = app.Find(Convert.ToInt32(gridPesquisa.SelectedRows[0].Cells[0].Value.ToString()));
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
