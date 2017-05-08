using System.Collections.Generic;
using System.Windows.Forms;
using Aplicacao;
using Modelo;
using System;
using MMLib.Extensions;
using UI;

namespace Rodomax
{
    public partial class frmFilialPesquisa : UI.ModelConsulta
    {
        private UsuarioFilialApp app;
        _Singleton instancia = _Singleton.GetInstance;

        public frmFilialPesquisa()
        {
            InitializeComponent();
            app = new UsuarioFilialApp();
            gridPesquisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void Buscar()
        {
            IEnumerable<UsuarioFilial> lista = app.Get(x => x.Filial.Nome.Contains(txtPesquisa.Text.Trim().RemoveDiacritics().ToUpper()) &&x.Usuario.Id == instancia.userLogado.Id);

            gridPesquisa.DataSource = null;
            gridPesquisa.ResetBindings();
            gridPesquisa.Rows.Clear();


            foreach (var i in lista)
            {
                int n = gridPesquisa.Rows.Add();
                gridPesquisa.Rows[n].Cells[0].Value = i.Filial.Id;
                gridPesquisa.Rows[n].Cells[1].Value = i.Filial.Nome;
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
                int id = Convert.ToInt32(gridPesquisa.SelectedRows[0].Cells[0].Value.ToString());
                FilialApp filialApp = new FilialApp();
                instancia.filial = filialApp.Find(id);
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro: " + exception.Message);
            }
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar();
            }
        }
    }
}
