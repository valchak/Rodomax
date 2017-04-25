using Aplicacao;
using MMLib.Extensions;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rodomax
{
    public partial class frmCentroCusto : UI.ModelForm
    {
        _Singleton instancia = _Singleton.GetInstance;
        private FilialApp appFilial;
        private CentroCustoApp app;
        private FilialCentroCustoApp appFilialCentroCusto;
        

        private CentroCusto centrocusto;
        private IDictionary<int, Filial> listaNao;
        private IDictionary<int, Filial> listaSim;

        public frmCentroCusto()
        {
            InitializeComponent();
            gridSim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridNao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Limpar();
        }

        private void Limpar()
        {
            app = new CentroCustoApp();
            appFilialCentroCusto = new FilialCentroCustoApp();
            appFilial = new FilialApp();
            centrocusto = new CentroCusto();

            listaNao = new Dictionary<int, Filial>();
            listaSim = new Dictionary<int, Filial>();
            txtId.Clear();
            txtNome.Clear();
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
                    foreach (var sim in listaSim)
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


        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(2);
            txtNome.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmCentroCustoPesquisa tela = new frmCentroCustoPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.centroCusto != null)
            {
                centrocusto = instancia.centroCusto;
                txtId.Text = centrocusto.Id.ToString();
                txtNome.Text = centrocusto.Nome;
                this.AlteraBotoes(3);


                instancia.centroCusto = null;
                IEnumerable<FilialCentroCusto> lista = appFilialCentroCusto.Get(x => x.CentroCusto.Id == centrocusto.Id);
                foreach (var i in lista)
                {
                    listaSim.Add(i.Filial.Id, i.Filial);
                }
                PopularGrids();

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                if (centrocusto.Id > 0)
                {
                    app.Excluir(x => x.Id == centrocusto.Id);
                    MessageBox.Show("Cadastro " + centrocusto.Id + " excluido com sucesso.");
                    this.Limpar();
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Excluir: " + erro.Message);
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

        private void Salvar()
        {
            try
            {
                Formatacao formatacao = new Formatacao();
                centrocusto.Nome = txtNome.Text.Trim().RemoveDiacritics().ToUpper();
               

                centrocusto.ListaInserir = listaSim.Values.ToList();
                centrocusto.ListaExcluir = listaNao.Values.ToList();

                if (centrocusto.Id == 0)
                {
                    app.Adicionar(centrocusto);
                    MessageBox.Show("Cadastro efetuado com sucesso: Código " + centrocusto.Id);
                }
                else
                {
                    app.Atualizar(centrocusto);
                    MessageBox.Show("Cadastro " + centrocusto.Id + " alterado com sucesso.");
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
            if (txtNome.Text.Trim().Equals(""))
            {
                MessageBox.Show("Descrição Inválida");
                return false;
            }
            return true;
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
        
    }
}
