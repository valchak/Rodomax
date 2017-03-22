using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.EntitySql;
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
        private List<NotaEntradaItens> listaExcluir;

        private int numeroItens = 0;

        private Produto produto;
        private Filial filial;
        private NotaEntradaItens item;

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
            nota.Fornecedor = fornecedor;
            nota.Documento = txtDocumento.Text.Trim();
            nota.Serie = txtSerie.Text.Trim();
            if (cbFinanceiro.Items.Equals("Sim"))
                nota.Faturado = "S";
            else
                nota.Faturado = "N";
            
            nota.DataEmissao = txtDataEmissao.Value;
            nota.DataRecebimento = txtDataFaturamento.Value;
            nota.ValorDocumento = Formatacao.StringToDouble(txtValorDocumento.Text);
            nota.ValorDocumentoTotal = Formatacao.StringToDouble(txtValorTotalDocumento.Text);
            nota.AcresDesc = Formatacao.StringToDouble(txtAcresDesc.Text);

            nota.NotaEntradaItens = new List<NotaEntradaItens>();
            foreach (var dado in listaItem)
            {
                nota.NotaEntradaItens.Add(dado.Value);
            }


            if (ValidaNota())
            {
                try
                {
                    
                    if (nota.Id == 0)
                    {
                        app.Adicionar(nota);
                        MessageBox.Show("Nota salva com sucesso: Código " + nota.Id);
                        MessageBox.Show() == DialogResult.Yes
                    }
                    else
                    {
                        app.Atualizar(nota);
                        MessageBox.Show("Nota alterada com sucesso.");
                    }
                    LimparCampos();

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro Salvar: " + erro.Message);
                }

            }
   
        }


        private void BuscaNotaEntrada()
        {
            if (fornecedor != null && !txtDocumento.Text.Equals("") && !txtSerie.Text.Equals(""))
            {
                IEnumerable<NotaEntrada> lista = app.Get(x => x.Fornecedor.Id == fornecedor.Id && x.Documento == txtDocumento.Text.Trim() && x.Serie == txtSerie.Text.Trim());

                if (lista.Any())
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
            txtValorDocumento.Text = (nf.ValorDocumento * 100).ToString();
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
            Formatacao.MoedaCampo(ref txtItemVlUnitario);
        }

        private void txtItemValorTotal_TextChanged(object sender, EventArgs e)
        {
            Formatacao.MoedaCampo(ref txtItemValorTotal);
        }

        private void txtValorDocumento_TextChanged(object sender, EventArgs e)
        {
            Formatacao.MoedaCampo(ref txtValorDocumento);
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
            if (ValidaItem())
            {
                item.Produto = produto;
                item.Filial = filial;
                item.Descricao = txtItemDescricao.Text;
                item.QuantidadeNota = int.Parse(txtItemQuantidade.Text);
                item.Multiplicador = int.Parse(txtItemMultiplicador.Text);
                item.ValorUnitario = double.Parse(txtItemVlUnitario.Text);
                item.ValorTotal = double.Parse(txtItemValorTotal.Text);
                listaItem.Add(++numeroItens, item);
                LimparItem();
            }
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
                item = listaItem[Convert.ToInt32(gridItens.SelectedRows[0].Cells[0].Value.ToString())];
                produto = item.Produto;
                filial = item.Filial;
                txtItemQuantidade.Text = item.QuantidadeNota.ToString();
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void txtItemQuantidade_Leave(object sender, EventArgs e)
        {
            ValidaQuantidadeMultiplicador(txtItemQuantidade);
        }

        private void txtItemMultiplicador_Leave(object sender, EventArgs e)
        {
            ValidaQuantidadeMultiplicador(txtItemQuantidade);
        }


        private void txtSerie_TextChanged(object sender, EventArgs e)
        {
            BuscaNotaEntrada();
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            BuscaNotaEntrada();
        }


        /*
            Validações dos campos no formulário 
        */



        public bool ValidaNota()
        {

            if (nota.Fornecedor == null)
                return false;
            foreach (var obj in nota.NotaEntradaItens)
            {
                if (obj.Filial == null)
                    return false;
                if (obj.QuantidadeNota <= 0)
                    return false;
                if (obj.Multiplicador <= 0)
                    return false;
                if (obj.ValorUnitario <= 0)
                    return false;
                if (obj.ValorTotal <= 0)
                    return false;
            }
            return true;
        }
   




    // Valida os campos do item da nota
        public bool ValidaItem()
        {
            if (txtItemDescricao.Text.Trim().Equals(""))
            {
                MessageBox.Show("Descrição informada inválida");
                return false;
            }
            if (filial == null)
            {
                MessageBox.Show("Deve ser informado a filial do item;");
                return false;
            }
            if (Formatacao.StringToDouble(txtItemQuantidade.Text.Trim()) <= 0)
            {
                MessageBox.Show("Quantidade Inválida;");
                return false;
            }
            if (Formatacao.StringToDouble(txtItemVlUnitario.Text.Trim()) <= 0)
            {
                MessageBox.Show("Valor Uitário Inválido;");
                return false;
            }
            if (Formatacao.StringToDouble(txtItemValorTotal.Text.Trim()) <= 0)
            {
                MessageBox.Show("Valor Total Inválido;");
                return false;
            }
            if (item == null)
            {
                item = new NotaEntradaItens();
            }
            return true;
        }

        // Se os campos Quantidade Multiplicador forem apagados, adicona a quantidade de 1 nos campos.
        public void ValidaQuantidadeMultiplicador(TextBox txt)
        {
            if (txt.Text.Trim().Equals(""))
            {
                txt.Text = "1";
            }
        }

        // Soma o total dos itens da nota e apresenta no final do formulário
        private void SomaTotais(double TotalItens)
        {
            txtSomaItens.Text = Formatacao.DoubleToString(TotalItens);
            txtDiferencaItensNota.Text = Formatacao.DoubleToString(double.Parse(txtValorTotalDocumento.Text) - TotalItens);
        }

        // Limpa Cabeçalho
        private void LimparCampos()
        {
            numeroItens = 0;
            nota = new NotaEntrada();
            nota.Id = 0;
            fornecedor = new Fornecedor();
            filial = new Filial();
            this.operacao = "NOVO";
            listaItem = new Dictionary<int, NotaEntradaItens>();
            listaExcluir = new List<NotaEntradaItens>();
            this.AlteraBotoes(2);
            txtValorDocumento.Clear();
            txtAcresDesc.Clear();
            txtValorTotalDocumento.Clear();
            txtDataEmissao.Value = DateTime.Now;
            txtDataFaturamento.Value = DateTime.Now;

            LimparItem();
        }

        // Limpa campos itens da nota
        private void LimparItem()
        {
            item = null;
            produto = null;
            txtItemDescricao.Clear();
            txtItemMultiplicador.Text = "1";
            txtItemValorTotal.Text = "0,00";
            txtItemVlUnitario.Text = "0,00";
            btnItemEditar.Enabled = false;
            btnItemExcluir.Enabled = false;
            btnItemAdd.Enabled = true;
            PopulaGrid();
        }


        public DialogResult MensagemInserir()
        {
            return MessageBox.Show("Deseja realmente salvar esse item?", "Confirmação", MessageBoxButtons.YesNoCancel);
        }
    }
}
