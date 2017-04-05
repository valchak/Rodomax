using Aplicacao;
using Modelo;
using Repositorio;
using System;
using System.Collections.Generic;
using MMLib.Extensions;
using System.Collections;

namespace Rodomax.Reports
{
    public partial class RelEstoqueMovimento : Rodomax.Reports.ModelReport
    {
        _Singleton instancia = _Singleton.GetInstance;
        ProdutoGrupo grupo;

        public RelEstoqueMovimento()
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
            txtProduto.Clear();
            txtGrupo.Clear();
            grupo = new ProdutoGrupo();
            rdTodos.Checked = true;
        }


        private void RelEstoqueMovimento_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            using (var contexto = new ContextoDB())
            {

                EstoqueMovimentoApp app = new EstoqueMovimentoApp();
                List<DadosEstoqueMovimento> lista = new List<DadosEstoqueMovimento>();
                DadosEstoqueMovimento dados;

                string filial = txtFilial.Text.Trim().RemoveDiacritics().ToUpper();
                string grupo = txtGrupo.Text.Trim().RemoveDiacritics().ToUpper();
                string produto = txtProduto.Text.Trim().RemoveDiacritics().ToUpper();
                string tipo = "";

                if (rdEntrada.Checked)
                {
                    tipo = "E";
                }
                if (rdSaida.Checked)
                {
                    tipo = "S";
                }

                

                DateTime dataInicio = txtDataInicio.Value;
                DateTime dataFim = txtDataFinal.Value;


                Dictionary<int, int> listaEstoque = new Dictionary<int, int>();

                IEnumerable<EstoqueMovimento> listaEDB = app.Get(x =>
                x.DataMovimento.Date < dataInicio
                && x.Produto.Nome.Contains(produto)
                && x.Filial.Nome.Contains(filial)
                && x.Produto.ProdutoGrupo.Nome.Contains(grupo)
                );

                foreach (var item in listaEDB)
                {
                    if (!listaEstoque.ContainsKey(item.Produto.Id))
                    {
                        listaEstoque.Add(item.Produto.Id, item.QuantidadeNovo + item.QuantidadeUsado);
                    }
                    else
                    {
                        listaEstoque[item.Produto.Id] = listaEstoque[item.Produto.Id] +item.QuantidadeNovo+item.QuantidadeUsado;
                    }
                }


                listaEDB = app.Get(x =>
                x.DataMovimento.Date >= dataInicio
                && x.DataMovimento.Date <= dataFim
                && x.TipoMovimento.Contains(tipo)
                && x.Produto.Nome.Contains(produto)
                && x.Filial.Nome.Contains(filial)
                && x.Produto.ProdutoGrupo.Nome.Contains(grupo)
                );
                foreach (var item in listaEDB)
                {
                    dados = new DadosEstoqueMovimento();
                    dados.FilialId = item.Filial.Id;
                    dados.FilialNome = item.Filial.Nome;
                    dados.ProdutoId = item.Produto.Id;
                    dados.DataMovimento = item.DataMovimento;
                    dados.ProdutoNome = item.Produto.Nome;
                    if (item.TipoMovimento.Equals("E"))
                    {
                        dados.QtdeEntrada = item.QuantidadeNovo+item.QuantidadeUsado;
                        dados.ValorTotal = dados.QtdeEntrada * item.ValorUnitario;

                        if (!listaEstoque.ContainsKey(item.Produto.Id))
                        {
                            listaEstoque.Add(item.Produto.Id, dados.QtdeEntrada);
                        }
                        else
                        {
                            listaEstoque[item.Produto.Id] = listaEstoque[item.Produto.Id] + dados.QtdeEntrada;
                        }
                        dados.QuantidadeEstoque = listaEstoque[item.Produto.Id];
                    }
                    else
                    {
                        dados.QtdeSaida = (item.QuantidadeNovo + item.QuantidadeUsado) * -1;
                        dados.ValorTotal = dados.QtdeSaida * item.ValorUnitario;

                        if (!listaEstoque.ContainsKey(item.Produto.Id))
                        {
                            listaEstoque.Add(item.Produto.Id, item.QuantidadeNovo + item.QuantidadeUsado);
                        }
                        else
                        {
                            listaEstoque[item.Produto.Id] = listaEstoque[item.Produto.Id] - dados.QtdeSaida;
                        }
                        
                    }



                    dados.QuantidadeEstoque = listaEstoque[item.Produto.Id];
                    dados.ValorUnitario = item.ValorUnitario;
                    dados.Tipo = item.TipoMovimento;
                    lista.Add(dados);
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

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            frmProdutoGrupoPesquisa tela = new frmProdutoGrupoPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.produtoGrupo != null)
            {
                grupo = instancia.produtoGrupo;
                instancia.produtoGrupo = null;
                txtGrupo.Text = grupo.Nome;
            }
        }

        private void btnFilial_Click(object sender, EventArgs e)
        {
            frmFilialPesquisa tela = new frmFilialPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.filial != null)
            {
                txtFilial.Text = instancia.filial.Nome;
                instancia.filial = null;
            }
        }
    }
}
