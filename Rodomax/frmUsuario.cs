using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Aplicacao;
using Modelo;
using MMLib.Extensions;
using Rodomax;

namespace Rodomax
{
    public partial class frmUsuario : UI.ModelForm
    {
        _Singleton instancia = _Singleton.GetInstance;
        private Usuario usuario;
        private IDictionary<int, Filial> listaNao;
        private IDictionary<int, Filial> listaSim;
        private FilialApp appFilial;
        private UsuarioFilialApp appUsuarioFilial;
        private UsuarioApp app;
        private Funcionario funcionario;


        public frmUsuario()
        {
            InitializeComponent();
            gridSim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridNao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Limpar();
        }


        private void Salvar()
        {
            try
            {
                Formatacao formatacao = new Formatacao();
                usuario.Funcionario = funcionario;
                usuario.Login = txtLogin.Text.Trim().RemoveDiacritics().ToUpper();
                usuario.Senha = formatacao.CriptoSenha(txtSenha.Text.Trim().RemoveDiacritics());
                if (rdAtivo.Checked)
                {
                    usuario.Situacao = "A";
                }
                else
                {
                    usuario.Situacao = "I";
                }

                usuario.ListaInserir = listaSim.Values.ToList();
                usuario.ListaExcluir = listaNao.Values.ToList();

                if (usuario.Id == 0)
                {
                    app.Adicionar(usuario);
                    MessageBox.Show("Cadastro efetuado com sucesso: Código " + usuario.Id);
                }
                else
                {
                    app.Atualizar(usuario);
                    MessageBox.Show("Cadastro " + usuario.Id + " alterado com sucesso.");
                }
                this.Limpar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro Salvar: " + erro.Message);
            }
        }

        private bool Validar()
        {
            if (txtLogin.Text.Trim().Equals(""))
            {
                MessageBox.Show("Login Inválido");
                return false;
            }
            if (txtSenha.Text.Trim().Equals(""))
            {
                if(usuario.Id == 0)
                {
                    MessageBox.Show("Senha Inválida");
                    return false;
                }
            }
            if (listaSim.Count() == 0)
            {
                MessageBox.Show("Nenhuma filial selecionada");
                return false;
            }
            return true;
        }


        private void Limpar()
        {
            app = new UsuarioApp();
            usuario = new Usuario();
            appUsuarioFilial = new UsuarioFilialApp();
            appFilial = new FilialApp();
            funcionario = null;
            
            listaNao = new Dictionary<int, Filial>();
            listaSim = new Dictionary<int, Filial>();
            txtId.Clear();
            txtFuncionario.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            rdAtivo.Select();
            PopularGrids();
            this.AlteraBotoes(1);

        }

        private void PopularGrids()
        {
            IEnumerable<Filial> lista = appFilial.GetAll();

            if (lista.Any())
            {
                listaNao = new Dictionary<int, Filial>();

                foreach (var filial in lista)
                {
                    bool adiciona = true;
                    foreach(var sim in listaSim)
                    {
                        if (filial.Id == sim.Value.Id)
                        {
                            adiciona = false;
                        }
                    }
                    if (adiciona)
                    {
                        listaNao.Add(filial.Id, filial);
                    }
                    
                }   
            }

            gridNao.DataSource = null;
            gridNao.ResetBindings();
            gridNao.Rows.Clear();

            foreach (var item in listaNao)
            {
                int n = this.gridNao.Rows.Add();
                gridNao.Rows[n].Cells[0].Value = item.Key;
                gridNao.Rows[n].Cells[1].Value = item.Value.Nome;
            }
            gridNao.Refresh();

            gridSim.DataSource = null;
            gridSim.ResetBindings();
            gridSim.Rows.Clear();

            foreach (var item in listaSim)
            {
                int n = this.gridSim.Rows.Add();
                gridSim.Rows[n].Cells[0].Value = item.Key;
                gridSim.Rows[n].Cells[1].Value = item.Value.Nome;
            }
            gridSim.Refresh();
        }



        private void btnAddSim1_Click(object sender, EventArgs e)
        {
            if (listaNao.Any())
            {
                int id = Convert.ToInt32(gridNao.SelectedRows[0].Cells[0].Value.ToString());
                Filial filial = appFilial.Find(id);
                listaSim.Add(filial.Id, filial);
                PopularGrids();
            }
                
        }

        private void btnAddTodos_Click(object sender, EventArgs e)
        {
            IDictionary<int, Filial> nova = listaNao;
            listaNao = new Dictionary<int, Filial>();
            foreach (var item in nova)
            {
                listaSim.Add(item);
            }
            PopularGrids();
        }

        private void btnRemoveTodos_Click(object sender, EventArgs e)
        {
            listaSim = new Dictionary<int, Filial>();
            PopularGrids();
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            if (listaSim.Any())
            {
                int id = Convert.ToInt32(gridSim.SelectedRows[0].Cells[0].Value.ToString());
                Filial filial = appFilial.Find(id);
                listaSim.Remove(filial.Id);
                PopularGrids();
            }
            
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionarioPesquisa tela = new frmFuncionarioPesquisa();
            tela.ShowDialog();
            tela.Dispose();
            if (instancia.funcionario != null)
            {
                funcionario = instancia.funcionario;
                instancia.funcionario = null;
                txtFuncionario.Text = funcionario.Nome;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(2);
            txtLogin.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            switch (Formatacao.MensagemExcluir())
            {
                case DialogResult.Yes:
                    if (Validar())
                    {
                        usuario.Situacao = "I";
                        app.Atualizar(usuario);
                        MessageBox.Show("Usuário Inativado com sucesso:");
                        Limpar();
                    }
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        public void Buscar()
        {
            frmUsuarioPesquisa tela = new frmUsuarioPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.usuario != null)
            {
                usuario = instancia.usuario;
                instancia.usuario = null;
                txtId.Text = usuario.Id.ToString();
                txtLogin.Text = usuario.Login;
                funcionario = usuario.Funcionario;

                if(funcionario != null)
                {
                    txtFuncionario.Text = funcionario.Nome;
                }
                
                IEnumerable<UsuarioFilial> lista = appUsuarioFilial.Get(x => x.Usuario.Id == usuario.Id);
                foreach (var i in lista)
                {
                    listaSim.Add(i.Filial.Id, i.Filial);
                }
                PopularGrids();


                this.AlteraBotoes(3);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            switch (Formatacao.MensagemInserir())
            {
                case DialogResult.Yes:
                    if (Validar())
                    {
                        Salvar();
                    }
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void frmUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
