using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Aplicacao;
using Modelo;
using System;
using Ferramenta;
using MMLib.Extensions;

namespace Rodomax
{
    public partial class frmFuncionarioPesquisa : UI.ModelConsulta
    {
        private FuncionarioApp app;
        Singleton instancia = Singleton.GetInstance;

        public frmFuncionarioPesquisa()
        {
            InitializeComponent();
            app = new FuncionarioApp();
            gridPesquisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void SelecionarObjeto()
        {
            try
            {
                instancia.funcionario = app.Find(Convert.ToInt32(gridPesquisa.SelectedRows[0].Cells[0].Value.ToString()));
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro: " + exception.Message);
            }
        }

        public void BuscarNoBanco()
        {
            gridPesquisa.DataSource = null;
            gridPesquisa.ResetBindings();
            gridPesquisa.Rows.Clear();

            Funcionario funcionario = new Funcionario();
            IEnumerable<Funcionario> lista;

            funcionario.Nome = txtPesquisa.Text.Trim().RemoveDiacritics().ToUpper();
            funcionario.CPF = txtPesquisa.Text.Trim().RemoveDiacritics().ToUpper();
            lista =
                app.Get(
                    x =>
                        x.Nome.Contains(funcionario.Nome) ||
                        x.CPF.Contains(funcionario.CPF));
            Invoke(new Action(() =>
            {

                if (lista.Count() > 0)
                {
                    foreach (var p in lista)
                    {
                        int n = this.gridPesquisa.Rows.Add();
                        gridPesquisa.Rows[n].Cells[0].Value = p.Id;
                        gridPesquisa.Rows[n].Cells[1].Value = p.Nome;
                        if (p.Situacao.Equals("A"))
                        {
                            gridPesquisa.Rows[n].Cells[2].Value = "Ativo";
                        }
                        else
                        {
                            gridPesquisa.Rows[n].Cells[2].Value = "Inativo";
                        }
                        gridPesquisa.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum item encontrado.");
                }
            }));
        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var th = new Thread(new ThreadStart(this.BuscarNoBanco));
            th.Start();
        }

        private void btnSelecionarPesquisa_Click(object sender, EventArgs e)
        {
            SelecionarObjeto();
        }

        private void btnCriarNovo_Click(object sender, EventArgs e)
        {

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
