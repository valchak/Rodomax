using System.Collections.Generic;
using System.Windows.Forms;
using Aplicacao;
using Modelo;
using System;
using Ferramenta;
using MMLib.Extensions;
using UI;

namespace Rodomax
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

        public void Buscar()
        {
            IEnumerable<Filial> lista = app.Get(x => x.Nome.Contains(txtPesquisa.Text.Trim().RemoveDiacritics().ToUpper()));

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



        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void gridPesquisa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gridPesquisa.Rows.Count > 0)
            {
                Selecionar();
            }
        }

        private void btnSelecionarPesquisa_Click(object sender, EventArgs e)
        {
            Selecionar();
        }

        private void btnCriarNovo_Click(object sender, EventArgs e)
        {
            frmFilial tela = new frmFilial();
            tela.ShowDialog();
            tela.Dispose();
        }

        public void Selecionar()
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
