using Aplicacao;
using Modelo;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Rodomax
{
    public partial class frmLinhas : UI.ModelForm
    {
        _Singleton instancia = _Singleton.GetInstance;
        private TelefoneApp app;
        private FilialCentroCustoApp appFilialCentroCusto;


        private TelefoneCobranca Obj;
        private IDictionary<int, Filial> listaNao;
        private IDictionary<int, Filial> listaSim;

        public frmLinhas()
        {
            InitializeComponent();
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Limpar();
        }
        private void Limpar()
        {
            app = new TelefoneApp();
            Obj = new TelefoneCobranca();
            txtLinhaCobranca.Clear();
            txtFornecedor.Clear();
            txtFilialCobranca.Clear();
            txtCnpjCobranca.Clear();
            cbDiaCobranca.SelectedIndex = 0;
            txtObservacao.Clear();
            rdContratoAtivo.Checked = true;
            LimparLinhas();
        }
        private void LimparLinhas()
        {
            txtLinha.Clear();
            rdContratoAtivo.Checked = true;
            txtFilialLinha.Clear();
            txtFuncionario.Clear();

            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            grid.DataSource = null;
            grid.ResetBindings();
            grid.Rows.Clear();
            if (Obj.LinhasTelefone != null)
            {
                if (Obj.LinhasTelefone.Count > 0)
                {
                    foreach (var i in Obj.LinhasTelefone)
                    {
                        int n = this.grid.Rows.Add();
                        grid.Rows[n].Cells[0].Value = i.Linha;
                        grid.Rows[n].Cells[1].Value = i.Filial.Nome;
                        grid.Rows[n].Cells[2].Value = i.Funcionario.Nome;
                        grid.Rows[n].Cells[3].Value = i.Situacao;
                    }
                    grid.Refresh();
                }
            }
        }


    }


}
