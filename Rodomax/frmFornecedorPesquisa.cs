
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Aplicacao;
using Modelo;
using System;
using Ferramenta;

namespace UI
{
    public partial class frmFornecedorPesquisa : UI.ModelConsulta
    {
        private FornecedorApp app;
        Singleton instancia = Singleton.GetInstance;

        public frmFornecedorPesquisa()
        {
            InitializeComponent();
            app = new FornecedorApp();
            gridPesquisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }



        private void btnFiltrar_Click(object sender, System.EventArgs e)
        {
           BuscarNoBanco();
        }

        private void btnSelecionarPesquisa_Click(object sender, System.EventArgs e)
        {
            SelecionarObjeto();
        }

        private void btnCriarNovo_Click(object sender, System.EventArgs e)
        {

        }

        private void gridPesquisa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gridPesquisa.Rows.Count > 0)
            {
                SelecionarObjeto();
            }
        }

        public void BuscarNoBanco()
        {
            gridPesquisa.DataSource = null;
            gridPesquisa.ResetBindings();
            gridPesquisa.Rows.Clear();

            Fornecedor fornecedor = new Fornecedor();
            IEnumerable<Fornecedor> lista;
           
           fornecedor.NomeFantasia = txtPesquisa.Text.Trim();
           fornecedor.RazaoSocial = txtPesquisa.Text.Trim();
           lista = app.Get(x => x.RazaoSocial.Contains(fornecedor.RazaoSocial) || x.NomeFantasia.Contains(fornecedor.NomeFantasia));
           
            
            if (lista.Count() > 0)
            {
                foreach (var p in lista)
                {
                    int n = this.gridPesquisa.Rows.Add();
                    gridPesquisa.Rows[n].Cells[0].Value = p.Id;
                    gridPesquisa.Rows[n].Cells[1].Value = p.RazaoSocial;
                    gridPesquisa.Rows[n].Cells[2].Value = p.NomeFantasia;
                    gridPesquisa.Rows[n].Cells[3].Value = p.Telefone;
                    gridPesquisa.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Nenhum item encontrado.");
            }
        }

        private void SelecionarObjeto()
        {
            try
            {
                instancia.fornecedor = app.Find(Convert.ToInt32(gridPesquisa.SelectedRows[0].Cells[0].Value.ToString()));
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro: " + exception.Message);
            }
        }

    }
}