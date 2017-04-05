using Repositorio;
using System;
using System.Collections.Generic;

namespace Rodomax.Reports
{
    public partial class RelProtocoloMaterial : Rodomax.Reports.ModelReport
    {
        public RelProtocoloMaterial()
        {
            InitializeComponent();
        }

        private void RelProtocoloMaterial_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            using (var contexto = new ContextoDB())
            {

               // EstoqueMovimentoApp app = new EstoqueMovimentoApp();
                List<DadosProtocoloMaterial> lista = new List<DadosProtocoloMaterial>();
                DadosProtocoloMaterial dados1;
                DadosProtocoloMaterial dados2;

                dados1 = new DadosProtocoloMaterial();

                dados1.CargoFuncao = "cargo";
                dados1.DataEnvio = DateTime.Now;
                dados1.FilialDestino = "PONTA GROSSA";
                dados1.FilialOrigem = "MATRIZ";
                dados1.FuncionarioEnvio = "MARCIO VALCHKA";
                dados1.FuncionarioRecebimento = "PEDRAO DA COSTA DE SOUSA SILVA";
                dados1.Produto = "CAMISA POLO VERMELHA MODELO A1 TAMANHO G";
                dados1.Quantidade = 3;

                lista.Add(dados1);

                dados2 = new DadosProtocoloMaterial();

                dados2.CargoFuncao = "cargo";
                dados2.DataEnvio = DateTime.Now;
                dados2.FilialDestino = "CURITIBA";
                dados2.FilialOrigem = "MATRIZ";
                dados2.FuncionarioEnvio = "MFADFAFDASF VALCHKA";
                dados2.FuncionarioRecebimento = "MARIA A COSTA DE SOUSA SILVA";
                dados2.Produto = "CAMISA POLO BRANCA MODELO A1 TAMANHO P";
                dados2.Quantidade = 2;
                lista.Add(dados2);


                
                var dadosRelatorio = lista.ToArray();

                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DadosRelatorio", dadosRelatorio));
            }

            this.reportViewer1.RefreshReport();
        }
    }
}
