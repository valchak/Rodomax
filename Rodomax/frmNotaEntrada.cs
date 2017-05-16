using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Aplicacao;
using Modelo;
using MMLib.Extensions;
using Rodomax;

namespace UI
{
    public partial class frmNotaEntrada : UI.ModelForm
    {
        _Singleton instancia = _Singleton.GetInstance;
        private NotaEntradaApp app;
        private NotaEntrada nota;
        private Fornecedor fornecedor;
        private OrdemCompra ordemCompra;
        private IDictionary<int, NotaEntradaItens> listaItem;
        private List<NotaEntradaItens> listaExcluir;

        private int numeroItens = 0;
        private int numeroEditar = 0;

        private Produto produto;
        private Filial filial;
        private NotaEntradaItens item;

        public frmNotaEntrada()
        {
            InitializeComponent();
            this.FechaTela("N");
            app = new NotaEntradaApp();
            gridItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LimpaNovo();
        }



        private void Salvar()
        {
            nota.Fornecedor = fornecedor;
            nota.Documento = txtDocumento.Text.Trim().RemoveDiacritics().ToUpper(); ;
            nota.Serie = txtSerie.Text.Trim().RemoveDiacritics().ToUpper(); ;
            if (cbFinanceiro.Items.Equals("Sim"))
                nota.Faturado = "S";
            else
                nota.Faturado = "N";
            
            nota.DataEmissao = txtDataEmissao.Value;
            nota.DataRecebimento = txtDataFaturamento.Value;
            nota.ValorDocumento = Formatacao.StringToDouble(txtValorDocumento.Text);
            nota.ValorDocumentoTotal = Formatacao.StringToDouble(txtValorTotalDocumento.Text);
            nota.AcresDesc = Formatacao.StringToDouble(txtAcresDesc.Text);

            nota.NotaEntradaItens = listaItem.Values.ToList();
            nota.listaExcluir = listaExcluir;

            if (ValidaNota())
            {
                try
                {
                    switch (Formatacao.MensagemInserir())
                    {
                        case DialogResult.Yes:
                            if (nota.Id == 0)
                            {
                                app.Adicionar(nota);
                                MessageBox.Show("Nota salva com sucesso: Código " + nota.Id);

                            }
                            else
                            {
                                app.Atualizar(nota);
                                MessageBox.Show("Nota alterada com sucesso.");
                            }
                            LimpaNovo();
                            break;
                        case DialogResult.No:
                            break;
                    }
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
                
                IEnumerable<NotaEntrada> lista = app.Get(x => x.Fornecedor.Id == fornecedor.Id && x.Documento == txtDocumento.Text.Trim().RemoveDiacritics().ToUpper() && x.Serie == txtSerie.Text.Trim().RemoveDiacritics().ToUpper());

                if (lista.Any())
                {
                    nota = lista.First();
                    PopulaCampos(nota);

                    this.AlteraBotoes(3);
                    this.operacao = "ALTERAR";
                    grupoItens.Enabled = true;
                }
                else
                {
                    LimparCabecalho();
                    grupoItens.Enabled = true;
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
                item.Value.QuantidadeEstoque = item.Value.Multiplicador * item.Value.QuantidadeNota;
                item.Value.ValorUnitarioEstoque = item.Value.ValorTotal / item.Value.QuantidadeEstoque;
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
            if(!txtValorDocumento.Text.Trim().Equals("") && !txtValorTotalDocumento.Text.Trim().Equals(""))
            {
                double valorDoc = double.Parse(txtValorDocumento.Text);
                double valorTotal = double.Parse(txtValorTotalDocumento.Text);
                txtAcresDesc.Text = Formatacao.DoubleToString(valorTotal - valorDoc);
            }            
        }

        private void txtItemVlUnitario_TextChanged(object sender, EventArgs e)
        {
            Formatacao.MoedaCampo(ref txtItemVlUnitario);
            if (!txtItemVlUnitario.Text.Trim().Equals("") && !txtItemQuantidade.Text.Trim().Equals(""))
            {
                double valor = double.Parse(txtItemVlUnitario.Text);
                double quant = double.Parse(txtItemQuantidade.Text);
                txtItemValorTotal.Text = Formatacao.DoubleToString(quant * valor);
            }
        }

        private void txtItemValorTotal_TextChanged(object sender, EventArgs e)
        {
            Formatacao.MoedaCampo(ref txtItemValorTotal);
            
        }

        private void txtValorDocumento_TextChanged(object sender, EventArgs e)
        {
            Formatacao.MoedaCampo(ref txtValorDocumento);
            if(!txtValorDocumento.Text.Trim().Equals("") && !txtAcresDesc.Text.Trim().Equals(""))
            {
                double valor = double.Parse(txtValorDocumento.Text);
                double desc = double.Parse(txtAcresDesc.Text);
                txtValorTotalDocumento.Text = Formatacao.DoubleToString(valor+desc);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           LimpaNovo();
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

                if (produto.EstoqueUsado.Equals("N"))
                {
                    rdUsado.Enabled = false;
                    rdNovo.Checked = true;
                }
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
                if (rdNovo.Checked == true)
                {
                    item.TipoProduto = "N";
                }
                else
                {
                    item.TipoProduto = "U";
                }
                item.Produto = produto;
                item.Filial = filial;
                item.Descricao = txtItemDescricao.Text.RemoveDiacritics().ToUpper();
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
            if (ValidaItem())
            {
                if (rdNovo.Checked == true)
                {
                    item.TipoProduto = "N";
                }
                else
                {
                    item.TipoProduto = "U";
                }
                item.Produto = produto;
                item.Filial = filial;
                item.Descricao = txtItemDescricao.Text.RemoveDiacritics().ToUpper();
                item.QuantidadeNota = int.Parse(txtItemQuantidade.Text);
                item.Multiplicador = int.Parse(txtItemMultiplicador.Text);
                item.ValorUnitario = double.Parse(txtItemVlUnitario.Text);
                item.ValorTotal = double.Parse(txtItemValorTotal.Text);
                //listaItem.Add(numeroEditar, item);
                listaItem[numeroEditar] = item;
                LimparItem();
            }
        }
        
        private void btnItemExcluir_Click(object sender, EventArgs e)
        {

            switch (Formatacao.MensagemExcluir())
            {
                case DialogResult.Yes:
                    listaItem.Remove(numeroEditar);
                    if (item.Id > 0)
                    {
                        listaExcluir.Add(item);
                    }
                    LimparItem();
                    break;
                case DialogResult.No:
                    break;
            }
            
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
            switch (Formatacao.MensagemExcluir())
            {
                case DialogResult.Yes:
                    app.Excluir(x => x.Id == nota.Id);
                    MessageBox.Show("Item Excuido com sucesso:");
                    LimparCabecalho();
                    break;
                case DialogResult.No:
                    break;
            }
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
            if (nota.Fornecedor.Id <= 0)
            {
                MessageBox.Show("Fornecedor inválido");
                return false;
            }

            if (nota.Documento.Equals(""))
            {
                MessageBox.Show("Documento Inválido ");
                return false;
            }

            if (nota.Serie.Equals(""))
            {   MessageBox.Show("Série Inválida");
                return false;
            }   
            if (nota.ValorDocumento == 0.00)
            {
                MessageBox.Show("Valor do documento inválido");
                return false;
            }
                
            if (nota.ValorDocumentoTotal == 0.00)
            {
                MessageBox.Show("Valor Total Inválido");
                return false;
            }
            if (!nota.NotaEntradaItens.Any())
            {
                MessageBox.Show("Nenhum Item na Nota: ");
                return false;
            }
                
            foreach (var item in nota.NotaEntradaItens)
            {
                if (item.Filial == null)
                {
                    MessageBox.Show("Filial não pode ser nula = Item: " + item.Descricao);
                    return false;
                }

                if (item.QuantidadeNota <= 0)
                {
                    MessageBox.Show("Quantidade inváida = Item: " + item.Descricao);
                    return false;
                }
                    
                if (item.Multiplicador <= 0)
                {
                    MessageBox.Show("Multiplicador inváida = Item: " + item.Descricao);
                    return false;
                }
                    
                if (item.ValorUnitario <= 0)
                {
                    MessageBox.Show("Valor Unitário inváido = Item: " + item.Descricao);
                    return false;
                }   
                if (item.ValorTotal <= 0)
                {
                    MessageBox.Show("Valor Total inváido = Item: " + item.Descricao);
                    return false;
                }
                    
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
            if (filial == null || filial.Id <= 0)
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

        public void LimpaNovo()
        {
            nota = new NotaEntrada();
            fornecedor = new Fornecedor();
            txtFornecedor.Clear();
            txtDocumento.Clear();
            txtSerie.Clear();
            grupoItens.Enabled = false;
            LimparCabecalho();
        }

        // Limpa Cabeçalho
        private void LimparCabecalho()
        {
            numeroItens = 0;
            nota.Id = 0;
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
            txtItemFilial.Clear();
            LimparItem();
        }

        // Limpa campos itens da nota
        private void LimparItem()
        {
            item = null;
            produto = null;
            txtItemDescricao.Clear();
            txtItemMultiplicador.Text = "1";
            txtItemQuantidade.Text = "1";
            txtItemValorTotal.Text = "0,00";
            txtItemVlUnitario.Text = "0,00";
            btnItemEditar.Enabled = false;
            btnItemExcluir.Enabled = false;
            btnItemAdd.Enabled = true;
            rdNovo.Checked = true;
            rdUsado.Enabled = true;
            PopulaGrid();
        }

        private void gridItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridItens.Rows.Count > 0)
            {
                try
                {
                    numeroEditar = Convert.ToInt32(gridItens.SelectedRows[0].Cells[0].Value.ToString());
                    item = listaItem[numeroEditar];
                    filial = item.Filial;
                    txtItemFilial.Text = filial.Nome;
                    produto = item.Produto;
                    txtItemDescricao.Text = item.Descricao;
                    txtItemQuantidade.Text = item.QuantidadeNota.ToString();
                    txtItemMultiplicador.Text = item.Multiplicador.ToString();
                    txtItemVlUnitario.Text = Formatacao.DoubleToString(item.ValorUnitario);
                    txtItemVlUnitario.Text = Formatacao.DoubleToString(item.ValorUnitario);
                    txtItemValorTotal.Text = Formatacao.DoubleToString(item.ValorTotal);

                    if (item.TipoProduto.Equals("N"))
                    {
                        rdNovo.Checked = true;
                    }
                    else
                    {
                        rdUsado.Checked = true;
                    }

                    btnItemEditar.Enabled = true;
                    btnItemExcluir.Enabled = true;
                    btnItemAdd.Enabled = false;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Erro: " + exception.Message);
                }
            }
        }

        private void btnItemLimpar_Click(object sender, EventArgs e)
        {
            LimparItem();
        }

        private void txtItemVlUnitario_Enter(object sender, EventArgs e)
        {
            CalculaTotal();
        }

        private void CalculaTotal()
        {
            if(!txtItemVlUnitario.Text.Trim().Equals("") && !txtItemQuantidade.Text.Trim().Equals(""))
            {
                double quant = double.Parse(txtItemQuantidade.Text);
                double valorUn = double.Parse(txtItemVlUnitario.Text);
                txtItemValorTotal.Text = Formatacao.DoubleToString(quant * valorUn);
            }
        }

        private void txtItemQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (!txtItemVlUnitario.Text.Trim().Equals("") && !txtItemQuantidade.Text.Trim().Equals(""))
            {
                double valor = double.Parse(txtItemVlUnitario.Text);
                double quant = double.Parse(txtItemQuantidade.Text);
                txtItemValorTotal.Text = Formatacao.DoubleToString(quant * valor);
            }
        }

        private void frmNotaEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show("Deseja realmente Sair do Formulário? ", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
           
        }
    }
}
