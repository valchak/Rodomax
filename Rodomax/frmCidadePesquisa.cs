using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Aplicacao;
using Modelo;
using MMLib.Extensions;
using UI;

namespace Rodomax
{
    public partial class frmCidadePesquisa : UI.ModelConsulta
    {
        private CidadeApp app;
        _Singleton instancia = _Singleton.GetInstance;

        public frmCidadePesquisa()
        {
            InitializeComponent();
            app = new CidadeApp();
            gridPesquisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            IEnumerable<Cidade> lista = app.Get(x => x.Nome.Contains(txtPesquisa.Text.Trim().RemoveDiacritics().ToUpper()));

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

        private void btnSelecionarPesquisa_Click(object sender, EventArgs e)
        {
            Selecionar();
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
                Selecionar();
            }
        }

        public void Selecionar()
        {
            try
            {
                instancia.cidade = app.Find(Convert.ToInt32(gridPesquisa.SelectedRows[0].Cells[0].Value.ToString()));
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro: " + exception.Message);
            }
        }
    }
}
