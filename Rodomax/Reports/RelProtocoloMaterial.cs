using Aplicacao;
using MMLib.Extensions;
using Modelo;
using Modelo.Reports;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Rodomax.Reports
{
    public partial class RelProtocoloMaterial : Rodomax.Reports.ModelReport
    {
        _Singleton instancia = _Singleton.GetInstance;

        public RelProtocoloMaterial()
        {
            InitializeComponent();
            Limpar();
        }

        private void Limpar()
        {
            DateTime primeiroDia = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime ultimoDia = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            txtDataFinal.Value = ultimoDia;
            txtDataInicio.Value = primeiroDia;
            txtFilial.Clear();
            txtId.Clear();
        }

        private void RelProtocoloMaterial_Load(object sender, EventArgs e)
        {
            //this.reportViewer1.RefreshReport();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            using (var contexto = new ContextoDB())
            {
                DateTime dataInicio = txtDataInicio.Value;
                DateTime dataFim = txtDataFinal.Value;
                int Id = 0;
                if (!txtId.Text.Trim().Equals(""))
                {
                   Id = int.Parse(txtId.Text.Trim());
                }
                
                string filial = txtFilial.Text.Trim().RemoveDiacritics().ToUpper();

                MaterialSaidaApp app = new MaterialSaidaApp();
                MaterialSaidaProdutosApp appProd = new MaterialSaidaProdutosApp();

             
                IEnumerable<MaterialSaida> listaEDB = app.Get(x => x.Id == Id
                && x.DataSaidaEstoque.Date >= dataInicio
                && x.DataSaidaEstoque.Date <= dataFim
                && x.FilialEntrada.Nome.Contains(filial));

                List<DadosProtocoloMaterial> lista = new List<DadosProtocoloMaterial>();


                foreach (var i in listaEDB)
                {

                    foreach(var x in i.MaterialSaidaProdutos)
                    {
                        DadosProtocoloMaterial dados = new DadosProtocoloMaterial();
                        MaterialSaidaProdutos produto = appProd.Find(x.Id);

                        dados.Id = i.Id;
                        dados.Produto = produto.Produto.Nome;
                        dados.DataEnvio = i.DataSaidaEstoque;
                        dados.FilialOrigem = i.FilialSaida.Nome;
                        dados.FilialDestino = i.FilialEntrada.Nome;
                        dados.FuncionarioEnvio = instancia.userLogado.Funcionario.Nome;
                        if (x.TipoProduto.Equals("N"))
                        {
                            dados.TipoProduto = "NOVO";
                        }
                        else
                        {
                            dados.TipoProduto = "USADO";
                        }
                        if(i.ResponsavelRecebimento != null)
                        {
                            dados.FuncionarioRecebimento = i.ResponsavelRecebimento.Nome;
                            dados.CargoFuncao = i.ResponsavelRecebimento.Funcao;
                        }
                        dados.Quantidade = x.Quantidade;
                        lista.Add(dados);
                    }
                }
                

                var dadosRelatorio = lista.ToArray();

                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DadosRelatorio", dadosRelatorio));
            }

            this.reportViewer1.RefreshReport();
        }

        private void btnLimparFiltro_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void RelProtocoloMaterial_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
