using Aplicacao;
using MMLib.Extensions;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rodomax
{
    public partial class frmPatrimonioGrupoPesquisa : UI.ModelConsulta
    {
        private PatrimonioGrupoApp app;
        _Singleton instancia = _Singleton.GetInstance;

        public frmPatrimonioGrupoPesquisa()
        {
            InitializeComponent();
            app = new PatrimonioGrupoApp();
            gridPesquisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void BuscarBanco()
        {
            IEnumerable<PatrimonioGrupo> lista = app.Get(x => x.Descricao.Contains(txtPesquisa.Text.Trim().RemoveDiacritics().ToUpper()));

            gridPesquisa.DataSource = null;
            gridPesquisa.ResetBindings();
            gridPesquisa.Rows.Clear();


            foreach (var i in lista)
            {
                int n = gridPesquisa.Rows.Add();
                gridPesquisa.Rows[n].Cells[0].Value = i.Id;
                gridPesquisa.Rows[n].Cells[1].Value = i.Descricao;
            }

            gridPesquisa.Refresh();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            BuscarBanco();
        }

        public void Selecionar()
        {
            try
            {
                instancia.patrimonioGrupo = app.Find(Convert.ToInt32(gridPesquisa.SelectedRows[0].Cells[0].Value.ToString()));
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
                Selecionar();
            }
        }

        private void btnSelecionarPesquisa_Click(object sender, EventArgs e)
        {
             Selecionar();
        }

        private void btnCriarNovo_Click(object sender, EventArgs e)
        {
            frmPatrimonioGrupo tela = new frmPatrimonioGrupo();
            tela.ShowDialog();
            tela.Dispose();
        }
        
    }
}
