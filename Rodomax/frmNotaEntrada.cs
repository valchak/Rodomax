using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Aplicacao;
using Ferramenta;
using Modelo;

namespace UI
{
    public partial class frmNotaEntrada : UI.ModelForm
    {
        Singleton instancia = Singleton.GetInstance;
        private NotaEntradaApp app;
        private NotaEntrada nota;
        private Fornecedor fornecedor;
        private OrdemCompra ordemCompra;

        private IDictionary<int, NotaEntradaItens> listaItem;
        private int numeroItens = 0;
        
        private Produto produto;
        private Filial filial;
        private NotaEntradaItens itemNF;

        public frmNotaEntrada()
        {
            InitializeComponent();
            app = new NotaEntradaApp();
            gridItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LimparCampos();
 //           Teste();
        }

        private void Salvar()
        {
            try
            {
                
                
                nota.Documento = txtDocumento.Text.Trim();
                nota.Serie = txtSerie.Text.Trim();
                if (cbFinanceiro.Items.Equals("Sim"))
                {
                    nota.Faturado = "S";
                }
                else
                {
                    nota.Faturado = "N";
                }
                nota.DataEmissao = txtDataEmissao.Value;
                nota.DataRecebimento = txtDataFaturamento.Value;
                nota.ValorDocumento = Formatacao.StringToDouble(txtValorDocumento.Text);
                nota.ValorDocumentoTotal = Formatacao.StringToDouble(txtValorTotalDocumento.Text);
                nota.AcresDesc = Formatacao.StringToDouble(txtValorTotalDocumento.Text) - Formatacao.StringToDouble(txtValorDocumento.Text);
                nota.NotaEntradaItens = new List<NotaEntradaItens>();

                foreach (var item in listaItem)
                {
                    nota.NotaEntradaItens.Add(item.Value);
                }

                if (this.operacao.Equals("NOVO"))
                {
                    nota.Fornecedor = fornecedor;
                    app.Adicionar(nota);
                    MessageBox.Show("Nota salva com sucesso: Código " + nota.Id);
                }
                else
                {
                    app.Atualizar(nota);
                    MessageBox.Show("Nota alterada com sucesso.");
                }
                this.LimparCampos();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro Salvar: " + erro.Message);
            }
        }

        private void LimparCampos()
        {
            numeroItens = 0;
            nota = new NotaEntrada();
            this.operacao = "NOVO";
            listaItem = new Dictionary<int, NotaEntradaItens>();
            this.AlteraBotoes(2);
            }

        private void LimparItem()
        {
            produto = null;
            itemNF = null;
            txtItemDescricao.Clear();
            txtItemQuantidade.Text = "1";
            txtItemVlUnitario.Text = "0,00";
            txtItemValorTotal.Text = "0,00";
            txtItemMultiplicador.Text = "1";
            btnItemEditar.Enabled = false;
            btnItemExcluir.Enabled = false;
            btnItemAdd.Enabled = true;

        }
        private void BuscaNotaEntrada()
        {
            if (!txtDocumento.Text.Equals("") && !txtSerie.Text.Equals(""))
            {
                
                IEnumerable<NotaEntrada> lista = app.Get(x => x.Fornecedor.Id == fornecedor.Id && x.Documento == txtDocumento.Text.Trim() && x.Serie == txtSerie.Text.Trim());

                if (lista.Count() > 0)
                {
                    nota = lista.First();
                    PopulaCampos(nota);

                    this.AlteraBotoes(3);
                    this.operacao = "ALTERAR";
                }
                else
                {
                    LimparCampos();
                }
            }
            
        }

        private void PopulaCampos(NotaEntrada nf)
        {
            if (nf.OrdemCompra != null)
            {
                txtOdemCompra.Text = nf.OrdemCompra.Id.ToString();
            }
            txtDataEmissao.Value = nf.DataEmissao;
            txtDataFaturamento.Value = nf.DataRecebimento;
            txtValorDocumento.Text = (nf.ValorDocumento*100).ToString();
            txtValorDocumento.Text = Formatacao.DoubleToString(nf.ValorDocumento);
            txtValorTotalDocumento.Text = Formatacao.DoubleToString(nf.ValorDocumentoTotal);
            txtAcresDesc.Text = Formatacao.DoubleToString(nf.AcresDesc);

            fornecedor = nf.Fornecedor;
            
            NotaEntradaItemApp itemNfApp = new NotaEntradaItemApp();
            

            foreach (var item in nf.NotaEntradaItens)
            {
                NotaEntradaItens novo = itemNfApp.Get(x => x.Id == item.Id).First();
                try
                {
                    listaItem.Add(++numeroItens, novo);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                
            }
            
            PopulaGrid();
        }

        private void PopulaGrid()
        {
 //           Invoke(new Action(() =>
 //           {
                gridItens.DataSource = null;
                gridItens.ResetBindings();
                gridItens.Rows.Clear();

                double total = 0;

                foreach (var item in listaItem)
                {
                    int n = this.gridItens.Rows.Add();
                    gridItens.Rows[n].Cells[0].Value = item.Key;
                    if (item.Value.Produto != null)
                    {
                        gridItens.Rows[n].Cells[1].Value = item.Value.Produto.Id;
                    }
                    gridItens.Rows[n].Cells[2].Value = item.Value.Descricao;
                    gridItens.Rows[n].Cells[3].Value = item.Value.QuantidadeNota;
                    gridItens.Rows[n].Cells[4].Value = item.Value.ValorUnitario;
                    gridItens.Rows[n].Cells[5].Value = item.Value.QuantidadeEstoque;
                    gridItens.Rows[n].Cells[6].Value = item.Value.ValorUnitarioEstoque;
                    gridItens.Rows[n].Cells[7].Value = item.Value.ValorTotal;
                    total = total + item.Value.ValorTotal;
                }
                gridItens.Refresh();
                SomaTotais(total);
//            }));
        }

        private void SomaTotais(double TotalItens)
        {
            txtSomaItens.Text = Formatacao.DoubleToString(TotalItens);
            txtDiferencaItensNota.Text = Formatacao.DoubleToString(double.Parse(txtValorTotalDocumento.Text) - TotalItens);
        }

        private void btnBuscaFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedorPesquisa tela = new frmFornecedorPesquisa();
            tela.ShowDialog();
            tela.Dispose();
            if (instancia.fornecedor != null)
            {
                fornecedor = instancia.fornecedor;
                instancia.fornecedor = null;
                txtFornecedor.Text = fornecedor.RazaoSocial;
            }
        }

        
        private void txtValorDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Formatacao.SoNumero(e);
        }

        private void txtAcresDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Formatacao.SoNumero(e);
        }

        private void txtValorTotalDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Formatacao.SoNumero(e);
        }

        private void txtItemQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            Formatacao.SoNumero(e);
        }

        private void txtItemVlUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Formatacao.SoNumero(e);
        }

        private void txtItemValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Formatacao.SoNumero(e);
        }

        private void txtAcresDesc_TextChanged(object sender, EventArgs e)
        {
            Formatacao.MoedaCampo(ref txtAcresDesc);
        }

        private void txtValorTotalDocumento_TextChanged(object sender, EventArgs e)
        {
            Formatacao.MoedaCampo(ref txtValorTotalDocumento);
        }

        private void txtItemVlUnitario_TextChanged(object sender, EventArgs e)
        {
            Formatacao.MoedaCampo(ref txtValorDocumento);
        }

        private void txtItemValorTotal_TextChanged(object sender, EventArgs e)
        {
            Formatacao.MoedaCampo(ref txtValorDocumento);
        }

        private void txtValorDocumento_TextChanged(object sender, EventArgs e)
        {
            Formatacao.MoedaCampo(ref txtValorDocumento);
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            BuscaNotaEntrada();
        }

        private void txtSerie_TextChanged(object sender, EventArgs e)
        {
            BuscaNotaEntrada();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(2);
            this.operacao = "NOVO";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmProdutoPesquisa tela = new frmProdutoPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.produto != null)
            {
                produto = instancia.produto;
                instancia.produto = null;
                txtItemDescricao.Text = produto.Nome;
                txtItemMultiplicador.Text = produto.Multiplicador.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmFilialPesquisa tela = new frmFilialPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.filial != null)
            {
                filial = instancia.filial;
                instancia.filial = null;
                txtItemFilial.Text = filial.Nome;
            }
        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {

            if (itemNF == null)
            {
                itemNF = new NotaEntradaItens();
            }
            if (filial == null)
            {
                MessageBox.Show("Deve ser informado a filial do item;");
                
            }
            else
            {
                itemNF.Produto = produto;
                itemNF.Filial = filial;
                itemNF.Descricao = txtItemDescricao.Text;
                itemNF.QuantidadeNota = int.Parse(txtItemQuantidade.Text);
                itemNF.ValorUnitario = double.Parse(txtItemVlUnitario.Text);
                itemNF.ValorTotal = double.Parse(txtItemValorTotal.Text);
                itemNF.ValorUnitarioEstoque = itemNF.ValorUnitario / int.Parse(txtItemMultiplicador.Text);
                itemNF.QuantidadeEstoque = itemNF.QuantidadeNota * int.Parse(txtItemMultiplicador.Text);
                itemNF.EstoqueMovimento = new EstoqueMovimento();
                itemNF.Multiplicador = int.Parse(txtItemMultiplicador.Text);
                listaItem.Add(++numeroItens,itemNF);
                LimparItem();
            }
            PopulaGrid();

        }

        private void btnItemEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnItemExcluir_Click(object sender, EventArgs e)
        {

        }

        private void gridItens_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gridItens.Rows.Count > 0)
            {
                SelecionarObjeto();
            }
        }
        private void SelecionarObjeto()
        {
            try
            {
                itemNF = listaItem[Convert.ToInt32(gridItens.SelectedRows[0].Cells[0].Value.ToString())];
                produto = itemNF.Produto;
                filial = itemNF.Filial;
                txtItemQuantidade.Text = itemNF.QuantidadeNota.ToString();
                

            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro: " + exception.Message);
            }
        }

        private void txtItemMultiplicador_KeyPress(object sender, KeyPressEventArgs e)
        {
            Formatacao.SoNumero(e);
        }


        public void Teste()
        {
            FornecedorApp fo = new FornecedorApp();
            FilialApp fi = new FilialApp();
            ProdutoApp pro = new ProdutoApp();
            fornecedor = fo.Find(5);
            filial = fi.Find(1);
            produto = pro.Find(10);
            txtFornecedor.Text = fornecedor.NomeFantasia;
            txtDocumento.Text = "1";
            txtSerie.Text = "1";
            txtValorDocumento.Text = "101,00";
            txtValorTotalDocumento.Text = "102,00";

            txtItemDescricao.Text = "Descricao: " + produto.Nome;
            txtItemQuantidade.Text = "10";
            txtItemVlUnitario.Text = "13";
            txtItemValorTotal.Text = "130";
            txtItemFilial.Text = filial.Nome;

        }

    }
}
