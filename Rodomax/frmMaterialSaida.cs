using Aplicacao;
using Modelo;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using MMLib.Extensions;
using Modelo.Reports;
using Rodomax.Reports;

namespace Rodomax
{
    public partial class frmMaterialSaida : UI.ModelForm
    {
        _Singleton instancia = _Singleton.GetInstance;
        Filial filialOrigem;
        Filial filialDestino;
        Funcionario solicitante;
        MaterialSolicitacao solicitacao;
        MaterialSaidaApp app;
        MaterialSaida saida;
        CentroCusto centroCusto;
        Produto produto;
        MaterialSaidaProdutos item;

        private int numeroItens = 0;
        private int numeroEditar = 0;

        private IDictionary<int, MaterialSaidaProdutos> listaItem;
        private IDictionary<int, CentroCusto> listaCentroCustos;
        private List<MaterialSaidaProdutos> listaExcluir;

        public frmMaterialSaida()
        {
            InitializeComponent();
            this.FechaTela("N");
            gridItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LimpaNovo();
        }

        private void Salvar()
        {
            saida.FilialSaida = filialOrigem;
            saida.FilialEntrada = filialDestino;
            saida.ResponsavelRecebimento = solicitante;
            saida.Solicitacao = solicitacao;
            saida.DataSaidaEstoque = txtDataSaida.Value;
            saida.Observacao = txtObservacao.Text.Trim().RemoveDiacritics();
            saida.MaterialSaidaProdutos = listaItem.Values.ToList();
            saida.listaExcluir = listaExcluir;
            

            if (ValidaNota())
            {
                try
                {
                    switch (Formatacao.MensagemInserir())
                    {
                        case DialogResult.Yes:
                            if (saida.Id == 0)
                            {
                                app.Adicionar(saida);
                                
                                if (MessageBox.Show("Saida de material salvo com sucesso: Código \n Desenha imprimir protocolo? " + saida.Id, "Imprimir Protocolo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    ImprimeProtocolo(saida);
                                }
                            }
                            else
                            {
                                app.Atualizar(saida);
                                if(MessageBox.Show("Saida de material alterada com sucesso. \n Desenha imprimir protocolo?","Imprimir Protocolo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    ImprimeProtocolo(saida);
                                }
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

        private void ImprimeProtocolo(MaterialSaida obj)
        {
            instancia.listaProtocoloMaterial = new List<DadosProtocoloMaterial>();
            foreach (var i in obj.MaterialSaidaProdutos)
            {
                DadosProtocoloMaterial dados = new DadosProtocoloMaterial();
                dados.Id = obj.Id;
                dados.FuncionarioEnvio = instancia.userLogado.Funcionario.Nome;
                dados.Produto = i.Produto.Nome;
                dados.DataEnvio = obj.DataSaidaEstoque;
                dados.FilialOrigem = obj.FilialSaida.Nome;
                dados.FilialDestino = obj.FilialEntrada.Nome;
                
                if(saida.ResponsavelRecebimento != null)
                {
                    dados.FuncionarioRecebimento = obj.ResponsavelRecebimento.Nome;
                }
                if (i.TipoProduto.Equals("N"))
                {
                    dados.TipoProduto = "NOVO";
                }
                else
                {
                    dados.TipoProduto = "USADO";
                }
                dados.CargoFuncao = obj.ResponsavelRecebimento.Funcao;
                dados.Quantidade = i.Quantidade;
                instancia.listaProtocoloMaterial.Add(dados);
            }

            RelProtocoloImpressao tela = new RelProtocoloImpressao();
            tela.ShowDialog();
            tela.Dispose();
            instancia.listaProtocoloMaterial = null;
        }

        public void LimpaNovo()
        {
            app = new MaterialSaidaApp();
            saida = new MaterialSaida();

            filialOrigem = new Filial();
            filialDestino = new Filial();
            solicitacao = new MaterialSolicitacao();

            listaItem = new Dictionary<int, MaterialSaidaProdutos>();
            listaCentroCustos = new Dictionary<int, CentroCusto>();
            listaExcluir = new List<MaterialSaidaProdutos>();

            txtCodigoSaida.Text = "0";
            txtFilialOrigem.Clear();
            txtFilialDestino.Clear();
            txtDataSaida.Value = DateTime.Now;
            txtSolicitacao.Clear();
            txtObservacao.Clear();
            txtFuncionarioSolicitante.Clear();

            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = true;
            btnNovo.Enabled = false;

            txtCodigoSaida.Enabled = true;
            this.AlteraBotoes(1);

            LimparItem();
        }
        // Limpa campos itens da nota
        private void LimparItem()
        {
            item = new MaterialSaidaProdutos();
            produto = null;
            txtProduto.Clear();
            txtQuantidade.Text = "1";
            btnItemEditar.Enabled = false;
            btnItemExcluir.Enabled = false;
            btnItemAdicionar.Enabled = true;
            rdNovo.Checked = true;
            rdUsado.Enabled = true;
            PopulaGrid();
        }

       
        private void PopulaCentroCusto()
        {
            if(filialDestino.Id > 0)
            {
                listaCentroCustos = new Dictionary<int, CentroCusto>();
                Dictionary<string, string> lista = new Dictionary<string, string>();
                FilialCentroCustoApp ct = new FilialCentroCustoApp();
                lista.Add("", "");
                foreach (var i in ct.Get(x => x.Filial.Id == filialDestino.Id))
                {
                    listaCentroCustos.Add(i.CentroCusto.Id, i.CentroCusto);
                    lista.Add(i.CentroCusto.Id.ToString(), i.CentroCusto.Nome);
                }
                if (lista.Count() > 1)
                {
                    cbCentroCusto.DataSource = new BindingSource(lista, null);
                }
            }
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
                gridItens.Rows[n].Cells[2].Value = item.Value.Produto.Nome;
                gridItens.Rows[n].Cells[3].Value = item.Value.CentroCusto.Nome;
                gridItens.Rows[n].Cells[4].Value = item.Value.Quantidade;
                gridItens.Rows[n].Cells[5].Value = item.Value.CustoUnitario;
                gridItens.Rows[n].Cells[6].Value = item.Value.Quantidade*item.Value.CustoUnitario;
            }
            gridItens.Refresh();
        }


       
        private void btnFilialDestino_Click(object sender, EventArgs e)
        {
            frmFilialPesquisa tela = new frmFilialPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.filial != null)
            {
                filialDestino = instancia.filial;
                instancia.filial = null;
                txtFilialDestino.Text = filialDestino.Nome;
                PopulaCentroCusto();
            }
        }

        private void btnFilialOrigem_Click(object sender, EventArgs e)
        {
            frmFilialPesquisa tela = new frmFilialPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.filial != null)
            {
                filialOrigem = instancia.filial;
                instancia.filial = null;
                txtFilialOrigem.Text = filialOrigem.Nome;
                PopulaCentroCusto();
            }
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionarioPesquisa tela = new frmFuncionarioPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.funcionario != null)
            {
                solicitante = instancia.funcionario;
                filialDestino = instancia.funcionario.Filial;
                txtFilialDestino.Text = filialDestino.Nome;
                txtFuncionarioSolicitante.Text = solicitante.Nome;
                instancia.funcionario = null;
            }
        }
        private void btnProduto_Click(object sender, EventArgs e)
        {
            frmProdutoPesquisa tela = new frmProdutoPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.produto != null)
            {
                produto = instancia.produto;
                instancia.produto = null;
                txtProduto.Text = produto.Nome;

                if (produto.EstoqueUsado.Equals("N"))
                {
                    rdUsado.Enabled = false;
                    rdNovo.Checked = true;
                }
            }
        }

        /*
            Validações dos campos no formulário 
        */
        public bool ValidaNota()
        {
            if (saida.FilialSaida.Id <= 0)
            {
                MessageBox.Show("Filial de saída do estoque inválida");
                return false;
            }

            if (saida.FilialEntrada.Id <= 0)
            {
                MessageBox.Show("Filial de destino dos materiais inválida");
                return false;
            }
            if (txtDataSaida.Text.Equals(""))
            {
                MessageBox.Show("Data Inválida");
                return false;
            }
            if (txtSolicitacao.Text.Trim().Equals(""))
            {
                saida.Solicitacao = null;
            }
            else
            {
                solicitacao.Id = int.Parse(txtSolicitacao.Text);
            }
            if (!saida.MaterialSaidaProdutos.Any())
            {
                MessageBox.Show("Nenhum produto informado para dar saída");
                return false;
            }

            foreach (var item in saida.MaterialSaidaProdutos)
            {
                if (item.Quantidade <= 0)
                {
                    MessageBox.Show("Quantidade inváida = Item: " + item.Produto.Nome);
                    return false;
                }

                if (item.CentroCusto.Id <= 0)
                {
                    MessageBox.Show("Centro de custo inválido: " + item.Produto.Nome);
                    return false;
                }
            }
            return true;
        }

        // Valida os campos do item da nota
        public bool ValidaItem()
        {
            if (produto == null || produto.Id <= 0)
            {
                MessageBox.Show("Produto Inválido");
                return false;
            }
            if (cbCentroCusto.Text.Equals(""))
            {
                MessageBox.Show("Centro de Custos Inválido;");
                return false;
            }
            else
            {
                centroCusto = listaCentroCustos[int.Parse(cbCentroCusto.SelectedValue.ToString())];
            }
            
            if (Formatacao.StringToDouble(txtQuantidade.Text.Trim()) <= 0)
            {
                MessageBox.Show("Quantidade Inválida;");
                return false;
            }
            if (item == null)
            {
                item = new MaterialSaidaProdutos();
            }
            return true;
        }

        private void btnItemAdicionar_Click(object sender, EventArgs e)
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
                item.CentroCusto = centroCusto;
                item.CustoUnitario = produto.CustoMedio;
                item.Quantidade = int.Parse(txtQuantidade.Text);
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
                item.CentroCusto = centroCusto;
                item.CustoUnitario = produto.CustoMedio;
                item.Quantidade = int.Parse(txtQuantidade.Text);
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

        private void btnItemLimpar_Click(object sender, EventArgs e)
        {
            LimparItem();
        }

        private void gridItens_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gridItens.Rows.Count > 0)
            {
                try
                {
                    numeroEditar = Convert.ToInt32(gridItens.SelectedRows[0].Cells[0].Value.ToString());
                    item = listaItem[numeroEditar];
                    produto = item.Produto;
                    txtProduto.Text = produto.Nome;
                    txtQuantidade.Text = item.Quantidade.ToString();
                    cbCentroCusto.SelectedValue = item.CentroCusto.Id.ToString();

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
                    btnItemAdicionar.Enabled = false;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Erro: " + exception.Message);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmMaterialSaidaPesquisa tela = new frmMaterialSaidaPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if(instancia.materialSaida != null)
            {
                txtCodigoSaida.Text = instancia.materialSaida.Id.ToString();
                instancia.materialSaida = null;
                BuscaMaterialSaida();
            }
            
            //this.AlteraBotoes(2);
        }

        private void BuscaMaterialSaida()
        {
            if (!txtCodigoSaida.Text.Trim().Equals("")){
                List<MaterialSaida> listaitem = app.Get(x => x.Id == int.Parse(txtCodigoSaida.Text.Trim())).ToList();
                if (listaitem.Any())
                {
                    saida = listaitem.First();
                    txtCodigoSaida.Text = saida.Id.ToString();
                    PopulaCampos(saida);
                    txtCodigoSaida.Enabled = false;
                    this.AlteraBotoes(3);
                    this.operacao = "ALTERAR";
                }
                else
                {
                    MessageBox.Show("Nenhuma saída com esse código foi encontrada");
                    LimpaNovo();
                }
            }
        }

        private void PopulaCampos(MaterialSaida saida)
        {

            filialOrigem = saida.FilialSaida;
            txtFilialOrigem.Text = filialOrigem.Nome;
            filialDestino = saida.FilialEntrada;
            txtFilialDestino.Text = filialDestino.Nome;
            if (saida.ResponsavelRecebimento != null)
            {
                solicitante = saida.ResponsavelRecebimento;
                txtFuncionarioSolicitante.Text = solicitante.Nome;
            }
            if(saida.Solicitacao != null)
            {
                solicitacao = saida.Solicitacao;
                txtSolicitacao.Text = solicitacao.Id.ToString();
            }
            
            txtDataSaida.Value = saida.DataSaidaEstoque;
            txtObservacao.Text = saida.Observacao;

            MaterialSaidaProdutosApp itemApp = new MaterialSaidaProdutosApp();


            foreach (var item in saida.MaterialSaidaProdutos)
            {
                MaterialSaidaProdutos novo = itemApp.Get(x => x.Id == item.Id).First();

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
            PopulaCentroCusto();
            LimparItem();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaNovo();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            switch (Formatacao.MensagemExcluir())
            {
                case DialogResult.Yes:
                    app.Excluir(x => x.Id == saida.Id);
                    MessageBox.Show("Item Excuido com sucesso:");
                    LimpaNovo();
                    break;
                case DialogResult.No:
                    break;
            }
        }
        
        private void frmMaterialSaida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show("Deseja realmente Sair do Formulário? ", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(2);
            txtCodigoSaida.Enabled = false;
        }

        private void txtCodigoSaida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               // BuscaMaterialSaida();
            }
        }
    }
}
