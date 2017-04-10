using Aplicacao;
using Modelo;
using System;
using System.Windows.Forms;
using MMLib.Extensions;
using Rodomax;
using System.Collections.Generic;
using System.Linq;

namespace UI
{
    public partial class frmFilial : UI.ModelForm
    {
        _Singleton instancia = _Singleton.GetInstance;
        private FilialApp app;
        private FilialCentroCustoApp appFilialCentroCusto;
        private CentroCustoApp appCentroCusto;

        private Filial filial;
        private Cidade cidade;
        private IDictionary<int, CentroCusto> listaNao;
        private IDictionary<int, CentroCusto> listaSim;
       
        public frmFilial()
        {
            InitializeComponent();
            limparCampos();
            gridSim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridNao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private void populaEmpresa()
        {
            EmpresaApp empApp = new EmpresaApp();
            foreach (var emp in empApp.GetAll())
            {
                cbEmpresa.Items.Add(emp.Nome);
            }
            cbEmpresa.SelectedIndex = 0;
        }

        private void limparCampos()
        {
            appCentroCusto = new CentroCustoApp();
            appFilialCentroCusto = new FilialCentroCustoApp();

            txtId.Clear();
            txtCep.Clear();
            txtComplemento.Clear();
            txtCidade.Clear();
            txtEndereco.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtBairro.Clear();
            txtEmail.Clear();
            
            cidade = null;
            this.AlteraBotoes(1);
            this.operacao = "";

            listaNao = new Dictionary<int, CentroCusto>();
            listaSim = new Dictionary<int, CentroCusto>();

            filial = new Filial();
            app = new FilialApp();
            populaEmpresa();
            cbEmpresa.SelectedIndex = 0;
            PopularGrids();

        }

        private void PopularGrids()
        {
            
            IEnumerable<CentroCusto> lista = appCentroCusto.GetAll();

            if (lista.Any())
            {
                listaNao = new Dictionary<int, CentroCusto>();

                foreach (var i in lista)
                {
                    bool adiciona = true;
                    foreach (var sim in listaSim)
                    {
                        if (i.Id == sim.Value.Id)
                        {
                            adiciona = false;
                        }
                    }
                    if (adiciona)
                    {
                        listaNao.Add(i.Id, i);
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


        private void btnBuscarCidade_Click(object sender, EventArgs e)
        {
            frmCidadePesquisa tela = new frmCidadePesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.cidade != null)
            {
                cidade = instancia.cidade;
                instancia.cidade = null;
                txtCidade.Text = cidade.Nome;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "NOVO";
            this.AlteraBotoes(2);
            txtNome.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmFilialPesquisa tela = new frmFilialPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.filial != null)
            {
                filial = instancia.filial;
                instancia.filial = null;
                cidade = filial.Cidade;
                txtId.Text = Convert.ToString(filial.Id);
                txtNome.Text = filial.Nome;
                txtCep.Text = filial.Cep;
                txtCidade.Text = cidade.Nome;
                txtComplemento.Text = filial.Complemento;
                txtEndereco.Text = filial.Endereco;
                txtBairro.Text = filial.Bairro;
                txtEmail.Text = filial.Email;
                txtTelefone.Text = filial.Telefone;

                cbEmpresa.SelectedItem = filial.Empresa.Nome;
                
                this.AlteraBotoes(3);
                this.operacao = "ALTERAR";

                IEnumerable<FilialCentroCusto> lista = appFilialCentroCusto.Get(x => x.Filial.Id == filial.Id);
                foreach (var i in lista)
                {
                    listaSim.Add(i.CentroCusto.Id, i.CentroCusto);
                }
                PopularGrids();


            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpresaApp empApp = new EmpresaApp();
                filial.Nome = txtNome.Text.Trim().RemoveDiacritics().ToUpper();
                filial.Cep = txtCep.Text.Trim().RemoveDiacritics().ToUpper();
                filial.Bairro = txtBairro.Text.Trim().RemoveDiacritics().ToUpper();
                filial.Cidade = cidade;
                filial.Complemento = txtComplemento.Text.Trim().RemoveDiacritics().ToUpper();
                filial.Endereco = txtEndereco.Text.Trim().RemoveDiacritics().ToUpper();
                filial.Email = txtEmail.Text.Trim().RemoveDiacritics();
                filial.Telefone = txtTelefone.Text.Trim();
                filial.FilialCentroCustos = null;

                filial.ListaInserir = listaSim.Values.ToList();
                filial.ListaExcluir = listaNao.Values.ToList();

                if (cbEmpresa.Text.Equals("RODOMAX"))
                {
                    filial.Empresa = empApp.Find(1);
                }
                else
                {
                    filial.Empresa = empApp.Find(2);
                }

                filial.Cidade = cidade;
                if (this.operacao.Equals("NOVO"))
                {
                    app.Adicionar(filial);
                    MessageBox.Show("Cadastro efetuado com sucesso: Código " + filial.Id);
                }
                else
                {
                    app.Atualizar(filial);
                    MessageBox.Show("Cadastro" + filial.Id + " alterado com sucesso.");
                }
                this.limparCampos();
                 
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro Salvar: " + erro.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.limparCampos();
            this.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                if (filial != null)
                {
                    app.Excluir(x => x.Id == filial.Id);
                    MessageBox.Show("Cadastro " + filial.Id + " excluido com sucesso.");
                    this.limparCampos();
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Excluir: " + erro.Message);
            }
        }

        private void frmFilial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnAddSim1_Click(object sender, EventArgs e)
        {
            if (listaNao.Any())
            {
                int id = Convert.ToInt32(gridNao.SelectedRows[0].Cells[0].Value.ToString());
                CentroCusto i = appCentroCusto.Find(id);
                listaSim.Add(i.Id, i);
                PopularGrids();
            }
        }

        private void btnAddTodos_Click(object sender, EventArgs e)
        {
            IDictionary<int, CentroCusto> nova = listaNao;
            listaNao = new Dictionary<int, CentroCusto>();
            foreach (var item in nova)
            {
                listaSim.Add(item);
            }
            PopularGrids();
        }

        private void btnRemoveTodos_Click(object sender, EventArgs e)
        {
            listaSim = new Dictionary<int, CentroCusto>();
            PopularGrids();
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            if (listaSim.Any())
            {
                int id = Convert.ToInt32(gridSim.SelectedRows[0].Cells[0].Value.ToString());
                CentroCusto i = appCentroCusto.Find(id);
                listaSim.Remove(i.Id);
                PopularGrids();
            }
        }
    }
}
