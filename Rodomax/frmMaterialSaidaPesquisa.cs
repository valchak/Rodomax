using Aplicacao;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Rodomax
{
    public partial class frmMaterialSaidaPesquisa : UI.ModelConsulta
    {

        private MaterialSaidaApp app;
        _Singleton instancia = _Singleton.GetInstance;
        private MaterialSaida Saida;
        private List<MaterialSaida> lista;

        public frmMaterialSaidaPesquisa()
        {
            InitializeComponent();
            gridPesquisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Limpar();

        }

        private void Limpar()
        {
            app = new MaterialSaidaApp();
            Saida = new MaterialSaida();
            DateTime primeiroDia = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime ultimoDia = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            txtDataFim.Value = ultimoDia;
            txtDataInicio.Value = primeiroDia;
            txtFilialDestino.Clear();
            txtFuncionario.Clear();
            txtPesquisa.Clear();
            lista = new List<MaterialSaida>();
        }

        private void Pesquisar()
        {

            DateTime dataInicio = txtDataInicio.Value;
            DateTime dataFim = txtDataFim.Value;
            IEnumerable<MaterialSaida> listaFiltro = app.Get(x => x.DataSaidaEstoque.Date >= dataInicio && x.DataSaidaEstoque.Date <= dataFim);

           

            foreach(var i in listaFiltro)
            {
                lista.Add(i);
                bool add = true;
                if(Saida.FilialSaida != null)
                {
                    if(i.FilialSaida.Id != Saida.FilialSaida.Id)
                    {
                        add = false;
                    }
                }
                if (Saida.FilialEntrada != null)
                {
                    if (i.FilialEntrada.Id != Saida.FilialEntrada.Id)
                    {
                        add = false;
                    }
                }
                if (Saida.ResponsavelRecebimento != null)
                {
                    if (i.ResponsavelRecebimento.Id != Saida.ResponsavelRecebimento.Id)
                    {
                        add = false;
                    }
                }
                if (!add)
                {
                    lista.Remove(i);
                }
            }


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
                        gridPesquisa.Rows[n].Cells[1].Value = p.DataSaidaEstoque;
                        gridPesquisa.Rows[n].Cells[2].Value = p.FilialSaida.Nome;
                        gridPesquisa.Rows[n].Cells[3].Value = p.FilialEntrada.Nome;
                        
                        if (p.ResponsavelRecebimento != null)
                        {
                            gridPesquisa.Rows[n].Cells[4].Value = p.ResponsavelRecebimento.Nome;
                        }
                        else
                        {
                            gridPesquisa.Rows[n].Cells[4].Value = "";
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
                instancia.materialSaida = app.Find(Convert.ToInt32(gridPesquisa.SelectedRows[0].Cells[0].Value.ToString()));
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro: " + exception.Message);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var th = new Thread(new ThreadStart(this.Pesquisar));
            th.Start();
        }
        private void btnSelecionarPesquisa_Click(object sender, EventArgs e)
        {
            SelecionarObjeto();
        }
        private void dataGridView1_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (gridPesquisa.Rows.Count > 0)
            {
                SelecionarObjeto();
            }
        }
        

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionarioPesquisa tela = new frmFuncionarioPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.funcionario != null)
            {
                Saida.ResponsavelRecebimento = instancia.funcionario;
                instancia.funcionario = null;
                txtFuncionario.Text = Saida.ResponsavelRecebimento.Nome;
            }
        }
        
        private void btnFilalDestino_Click(object sender, EventArgs e)
        {
            frmFilialPesquisa tela = new frmFilialPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.filial != null)
            {
                Saida.FilialEntrada = instancia.filial;
                instancia.filial = null;
                txtFilialDestino.Text = Saida.FilialSaida.Nome;
            }
        }

        private void btnFilialOrigem_Click_1(object sender, EventArgs e)
        {
            frmFilialPesquisa tela = new frmFilialPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.filial != null)
            {
                Saida.FilialSaida = instancia.filial;
                instancia.filial = null;
                txtPesquisa.Text = Saida.FilialSaida.Nome;
            }
        }

        private void txtPesquisa_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            Pesquisar();
        }

        private void txtFilialDestino_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

        }

        private void txtFuncionario_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

        }

        private void txtDataInicio_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

        }

        private void txtDataFim_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
