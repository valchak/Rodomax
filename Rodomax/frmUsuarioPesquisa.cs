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
    public partial class frmUsuarioPesquisa : UI.ModelConsulta
    {
        _Singleton instancia = _Singleton.GetInstance;
        private UsuarioApp app;

        public frmUsuarioPesquisa()
        {
            InitializeComponent();
            gridPesquisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            rdAtivo.Checked = true;
            app = new UsuarioApp();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var th = new Thread(new ThreadStart(this.BuscarNoBanco));
            th.Start();
        }

        private void btnCriarNovo_Click(object sender, EventArgs e)
        {
            frmUsuario tela = new frmUsuario();
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


        public void BuscarNoBanco()
        {

            Usuario usuario = new Usuario();

            if (rdAtivo.Checked)
            {
                usuario.Situacao = "A";
            }
            if (rdInativo.Checked)
            {
                usuario.Situacao = "I";
            }
            if (rdTodos.Checked)
            {
                usuario.Situacao = "";
            }
            usuario.Login = txtPesquisa.Text.Trim().RemoveDiacritics().ToUpper();
            
            IEnumerable<Usuario> lista = app.Get(x => (x.Login.Contains(usuario.Login)|| x.Funcionario.Nome.Contains(usuario.Login)) && x.Situacao.Contains(usuario.Situacao));


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
                        gridPesquisa.Rows[n].Cells[1].Value = p.Login;
                        if(usuario.Funcionario != null)
                        {
                            if(usuario.Funcionario.Id > 0)
                            {
                                gridPesquisa.Rows[n].Cells[2].Value = p.Funcionario.Nome;
                            } else
                            {
                                gridPesquisa.Rows[n].Cells[2].Value = "";
                            }
                        }
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
                instancia.usuario = app.Find(Convert.ToInt32(gridPesquisa.SelectedRows[0].Cells[0].Value.ToString()));
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro: " + exception.Message);
            }
        }
        
    }
}
