using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Aplicacao;
using Modelo;
using MMLib.Extensions;
using UI;

namespace Rodomax
{
    public partial class frmProdutoPesquisa : UI.ModelConsulta
    {
        private ProdutoApp app;
        _Singleton instancia = _Singleton.GetInstance;

        public frmProdutoPesquisa()
        {
            InitializeComponent();
            gridPesquisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            rdAtivo.Checked = true;
            app = new ProdutoApp();
        }

        public void BuscarNoBanco()
        {

            Produto produto = new Produto();

            if (rdAtivo.Checked)
            {
                produto.Situacao = "A";
            }
            if (rdInativo.Checked)
            {
                produto.Situacao = "I";
            }
            if (rdTodos.Checked)
            {
                produto.Situacao = "";
            }
            produto.Nome = txtPesquisa.Text.Trim().RemoveDiacritics().ToUpper();


            IEnumerable<Produto> lista = app.Get(x => x.Nome.Contains(produto.Nome) && x.Situacao.Contains(produto.Situacao));


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
                        gridPesquisa.Rows[n].Cells[2].Value = p.ProdutoGrupo.Nome;
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
                instancia.produto = app.Find(Convert.ToInt32(gridPesquisa.SelectedRows[0].Cells[0].Value.ToString()));
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
            frmProduto tela = new frmProduto();
            tela.ShowDialog();
            tela.Dispose();
        }

        private void gridPesquisa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gridPesquisa.Rows.Count > 0)
            {
                SelecionarObjeto();
            }
        }

        private void btnSelecionarPesquisa_Click(object sender, EventArgs e)
        {
            SelecionarObjeto();
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarNoBanco();
            }
        }
    }
}
