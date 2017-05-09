using Aplicacao;
using MMLib.Extensions;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Rodomax
{
    public partial class frmLinhaCobrancaPesquisa : UI.ModelConsulta
    {
        private TelefoneApp app;
        _Singleton instancia = _Singleton.GetInstance;

        public frmLinhaCobrancaPesquisa()
        {
            InitializeComponent();
            gridPesquisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            app = new TelefoneApp();
        }

        public void BuscarNoBanco()
        {
            TelefoneCobranca obj = new TelefoneCobranca();
            obj.LinhaCobranca = txtPesquisa.Text.Trim().RemoveDiacritics().ToUpper();
            IEnumerable<TelefoneCobranca> lista = app.Get(x => x.LinhaCobranca.Contains(obj.LinhaCobranca));

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
                        gridPesquisa.Rows[n].Cells[1].Value = p.LinhaCobranca;
                        gridPesquisa.Rows[n].Cells[2].Value = p.Fornecedor.RazaoSocial;
                        
                        switch (p.Situacao)
                        {
                            case "1":
                            case "A":
                                this.gridPesquisa.Rows[n].Cells[3].Value = "Ativo";
                                break;
                            case "2":
                            case "I":
                                this.gridPesquisa.Rows[n].Cells[3].Value = "Inativo";
                                break;
                            default:
                                this.gridPesquisa.Rows[n].Cells[3].Value = "";
                                break;
                        }
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
                instancia.TelefoneCobranca = app.Find(Convert.ToInt32(gridPesquisa.SelectedRows[0].Cells[0].Value.ToString()));
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
            frmLinhas tela = new frmLinhas();
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

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BuscarNoBanco();
            }
        }
    }
}
