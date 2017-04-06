
using Aplicacao;

namespace Rodomax.Reports
{
    public partial class RelProtocoloImpressao : MetroFramework.Forms.MetroForm
    {
        _Singleton instancia = _Singleton.GetInstance;
        public RelProtocoloImpressao()
        {
            InitializeComponent();
        }

        private void RelProtocoloImpressao_Load(object sender, System.EventArgs e)
        {

            if(instancia.listaProtocoloMaterial != null)
            {
                var dadosRelatorio = instancia.listaProtocoloMaterial.ToArray();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DadosRelatorio", dadosRelatorio));
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
