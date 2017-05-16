namespace UI
{
    partial class frmNotaEntrada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtOdemCompra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscaFornecedor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFinanceiro = new System.Windows.Forms.ComboBox();
            this.btnContasPagar = new System.Windows.Forms.Button();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDataEmissao = new System.Windows.Forms.DateTimePicker();
            this.txtDataFaturamento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorDocumento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAcresDesc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValorTotalDocumento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grupoItens = new System.Windows.Forms.GroupBox();
            this.grpEstoqueUsado = new System.Windows.Forms.GroupBox();
            this.rdUsado = new System.Windows.Forms.RadioButton();
            this.rdNovo = new System.Windows.Forms.RadioButton();
            this.btnItemLimpar = new System.Windows.Forms.Button();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.btnItemExcluir = new System.Windows.Forms.Button();
            this.btnItemEditar = new System.Windows.Forms.Button();
            this.txtItemMultiplicador = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtItemValorTotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtItemVlUnitario = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtItemQuantidade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtItemFilial = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtItemDescricao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gridItens = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDiferencaItensNota = new System.Windows.Forms.Label();
            this.txtSomaItens = new System.Windows.Forms.Label();
            this.pnlBotoes.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.pnlDireita.SuspendLayout();
            this.grupoItens.SuspendLayout();
            this.grpEstoqueUsado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItens)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Size = new System.Drawing.Size(896, 94);
            // 
            // btnNovo
            // 
            this.btnNovo.Enabled = false;
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.txtDiferencaItensNota);
            this.pnlDados.Controls.Add(this.txtSomaItens);
            this.pnlDados.Controls.Add(this.label18);
            this.pnlDados.Controls.Add(this.label17);
            this.pnlDados.Controls.Add(this.grupoItens);
            this.pnlDados.Controls.Add(this.txtValorTotalDocumento);
            this.pnlDados.Controls.Add(this.label10);
            this.pnlDados.Controls.Add(this.txtAcresDesc);
            this.pnlDados.Controls.Add(this.label9);
            this.pnlDados.Controls.Add(this.txtValorDocumento);
            this.pnlDados.Controls.Add(this.label8);
            this.pnlDados.Controls.Add(this.txtDataFaturamento);
            this.pnlDados.Controls.Add(this.label7);
            this.pnlDados.Controls.Add(this.txtDataEmissao);
            this.pnlDados.Controls.Add(this.label6);
            this.pnlDados.Controls.Add(this.txtSerie);
            this.pnlDados.Controls.Add(this.label5);
            this.pnlDados.Controls.Add(this.txtDocumento);
            this.pnlDados.Controls.Add(this.label4);
            this.pnlDados.Controls.Add(this.btnContasPagar);
            this.pnlDados.Controls.Add(this.cbFinanceiro);
            this.pnlDados.Controls.Add(this.label3);
            this.pnlDados.Controls.Add(this.btnBuscaFornecedor);
            this.pnlDados.Controls.Add(this.txtOdemCompra);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.txtFornecedor);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Size = new System.Drawing.Size(896, 520);
            // 
            // pnlDireita
            // 
            this.pnlDireita.Location = new System.Drawing.Point(524, 3);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Enabled = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fornecedor";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Location = new System.Drawing.Point(11, 18);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(342, 20);
            this.txtFornecedor.TabIndex = 1;
            // 
            // txtOdemCompra
            // 
            this.txtOdemCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOdemCompra.Location = new System.Drawing.Point(500, 19);
            this.txtOdemCompra.Name = "txtOdemCompra";
            this.txtOdemCompra.Size = new System.Drawing.Size(117, 20);
            this.txtOdemCompra.TabIndex = 3;
            this.txtOdemCompra.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ordem de Compra";
            this.label2.Visible = false;
            // 
            // btnBuscaFornecedor
            // 
            this.btnBuscaFornecedor.Image = global::Rodomax.Properties.Resources._16_procurar;
            this.btnBuscaFornecedor.Location = new System.Drawing.Point(362, 17);
            this.btnBuscaFornecedor.Name = "btnBuscaFornecedor";
            this.btnBuscaFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btnBuscaFornecedor.TabIndex = 1;
            this.btnBuscaFornecedor.UseVisualStyleBackColor = true;
            this.btnBuscaFornecedor.Click += new System.EventHandler(this.btnBuscaFornecedor_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(629, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "A Faturar";
            this.label3.Visible = false;
            // 
            // cbFinanceiro
            // 
            this.cbFinanceiro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFinanceiro.FormattingEnabled = true;
            this.cbFinanceiro.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbFinanceiro.Location = new System.Drawing.Point(632, 18);
            this.cbFinanceiro.Name = "cbFinanceiro";
            this.cbFinanceiro.Size = new System.Drawing.Size(121, 21);
            this.cbFinanceiro.TabIndex = 6;
            this.cbFinanceiro.Visible = false;
            // 
            // btnContasPagar
            // 
            this.btnContasPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContasPagar.Location = new System.Drawing.Point(760, 17);
            this.btnContasPagar.Name = "btnContasPagar";
            this.btnContasPagar.Size = new System.Drawing.Size(127, 23);
            this.btnContasPagar.TabIndex = 7;
            this.btnContasPagar.Text = "Contas a Pagar";
            this.btnContasPagar.UseVisualStyleBackColor = true;
            this.btnContasPagar.Visible = false;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(11, 52);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(342, 20);
            this.txtDocumento.TabIndex = 2;
            this.txtDocumento.TextChanged += new System.EventHandler(this.txtDocumento_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nº Documento/Nota Fiscal";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(362, 53);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(75, 20);
            this.txtSerie.TabIndex = 3;
            this.txtSerie.TextChanged += new System.EventHandler(this.txtSerie_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Série";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data Emissão";
            // 
            // txtDataEmissao
            // 
            this.txtDataEmissao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataEmissao.Location = new System.Drawing.Point(500, 53);
            this.txtDataEmissao.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.txtDataEmissao.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.txtDataEmissao.Name = "txtDataEmissao";
            this.txtDataEmissao.Size = new System.Drawing.Size(117, 20);
            this.txtDataEmissao.TabIndex = 7;
            this.txtDataEmissao.Value = new System.DateTime(2017, 3, 10, 11, 34, 28, 0);
            // 
            // txtDataFaturamento
            // 
            this.txtDataFaturamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataFaturamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataFaturamento.Location = new System.Drawing.Point(632, 53);
            this.txtDataFaturamento.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.txtDataFaturamento.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.txtDataFaturamento.Name = "txtDataFaturamento";
            this.txtDataFaturamento.Size = new System.Drawing.Size(121, 20);
            this.txtDataFaturamento.TabIndex = 8;
            this.txtDataFaturamento.Value = new System.DateTime(2017, 3, 10, 11, 34, 28, 0);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(629, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Dara Recebimento";
            // 
            // txtValorDocumento
            // 
            this.txtValorDocumento.Location = new System.Drawing.Point(11, 88);
            this.txtValorDocumento.Name = "txtValorDocumento";
            this.txtValorDocumento.Size = new System.Drawing.Size(96, 20);
            this.txtValorDocumento.TabIndex = 4;
            this.txtValorDocumento.Text = "0,00";
            this.txtValorDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorDocumento.TextChanged += new System.EventHandler(this.txtValorDocumento_TextChanged);
            this.txtValorDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorDocumento_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Valor Documento";
            // 
            // txtAcresDesc
            // 
            this.txtAcresDesc.Location = new System.Drawing.Point(178, 88);
            this.txtAcresDesc.Name = "txtAcresDesc";
            this.txtAcresDesc.Size = new System.Drawing.Size(96, 20);
            this.txtAcresDesc.TabIndex = 5;
            this.txtAcresDesc.Text = "0,00";
            this.txtAcresDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAcresDesc.TextChanged += new System.EventHandler(this.txtAcresDesc_TextChanged);
            this.txtAcresDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAcresDesc_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Acres/Desconto";
            // 
            // txtValorTotalDocumento
            // 
            this.txtValorTotalDocumento.Location = new System.Drawing.Point(341, 88);
            this.txtValorTotalDocumento.Name = "txtValorTotalDocumento";
            this.txtValorTotalDocumento.Size = new System.Drawing.Size(96, 20);
            this.txtValorTotalDocumento.TabIndex = 6;
            this.txtValorTotalDocumento.Text = "0,00";
            this.txtValorTotalDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorTotalDocumento.TextChanged += new System.EventHandler(this.txtValorTotalDocumento_TextChanged);
            this.txtValorTotalDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorTotalDocumento_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(341, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Valor Total Doc.";
            // 
            // grupoItens
            // 
            this.grupoItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoItens.Controls.Add(this.grpEstoqueUsado);
            this.grupoItens.Controls.Add(this.btnItemLimpar);
            this.grupoItens.Controls.Add(this.btnItemAdd);
            this.grupoItens.Controls.Add(this.btnItemExcluir);
            this.grupoItens.Controls.Add(this.btnItemEditar);
            this.grupoItens.Controls.Add(this.txtItemMultiplicador);
            this.grupoItens.Controls.Add(this.label16);
            this.grupoItens.Controls.Add(this.txtItemValorTotal);
            this.grupoItens.Controls.Add(this.label15);
            this.grupoItens.Controls.Add(this.txtItemVlUnitario);
            this.grupoItens.Controls.Add(this.label14);
            this.grupoItens.Controls.Add(this.txtItemQuantidade);
            this.grupoItens.Controls.Add(this.label13);
            this.grupoItens.Controls.Add(this.button3);
            this.grupoItens.Controls.Add(this.txtItemFilial);
            this.grupoItens.Controls.Add(this.label12);
            this.grupoItens.Controls.Add(this.button2);
            this.grupoItens.Controls.Add(this.txtItemDescricao);
            this.grupoItens.Controls.Add(this.label11);
            this.grupoItens.Controls.Add(this.gridItens);
            this.grupoItens.Location = new System.Drawing.Point(4, 113);
            this.grupoItens.Name = "grupoItens";
            this.grupoItens.Size = new System.Drawing.Size(888, 368);
            this.grupoItens.TabIndex = 24;
            this.grupoItens.TabStop = false;
            this.grupoItens.Text = "Itens da Nota";
            // 
            // grpEstoqueUsado
            // 
            this.grpEstoqueUsado.Controls.Add(this.rdUsado);
            this.grpEstoqueUsado.Controls.Add(this.rdNovo);
            this.grpEstoqueUsado.Location = new System.Drawing.Point(352, 55);
            this.grpEstoqueUsado.Name = "grpEstoqueUsado";
            this.grpEstoqueUsado.Size = new System.Drawing.Size(132, 36);
            this.grpEstoqueUsado.TabIndex = 144;
            this.grpEstoqueUsado.TabStop = false;
            this.grpEstoqueUsado.Text = "Tipo do Item/Produto";
            // 
            // rdUsado
            // 
            this.rdUsado.AutoSize = true;
            this.rdUsado.Location = new System.Drawing.Point(68, 13);
            this.rdUsado.Name = "rdUsado";
            this.rdUsado.Size = new System.Drawing.Size(56, 17);
            this.rdUsado.TabIndex = 13;
            this.rdUsado.TabStop = true;
            this.rdUsado.Text = "Usado";
            this.rdUsado.UseVisualStyleBackColor = true;
            // 
            // rdNovo
            // 
            this.rdNovo.AutoSize = true;
            this.rdNovo.Location = new System.Drawing.Point(6, 13);
            this.rdNovo.Name = "rdNovo";
            this.rdNovo.Size = new System.Drawing.Size(51, 17);
            this.rdNovo.TabIndex = 12;
            this.rdNovo.TabStop = true;
            this.rdNovo.Text = "Novo";
            this.rdNovo.UseVisualStyleBackColor = true;
            // 
            // btnItemLimpar
            // 
            this.btnItemLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItemLimpar.BackgroundImage = global::Rodomax.Properties.Resources._16_arrow_left;
            this.btnItemLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnItemLimpar.Location = new System.Drawing.Point(791, 67);
            this.btnItemLimpar.Name = "btnItemLimpar";
            this.btnItemLimpar.Size = new System.Drawing.Size(86, 23);
            this.btnItemLimpar.TabIndex = 143;
            this.btnItemLimpar.Text = "Limpar";
            this.btnItemLimpar.UseVisualStyleBackColor = true;
            this.btnItemLimpar.Click += new System.EventHandler(this.btnItemLimpar_Click);
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItemAdd.BackgroundImage = global::Rodomax.Properties.Resources._16_add;
            this.btnItemAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnItemAdd.Location = new System.Drawing.Point(499, 68);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(95, 23);
            this.btnItemAdd.TabIndex = 16;
            this.btnItemAdd.Text = "Adicionar";
            this.btnItemAdd.UseVisualStyleBackColor = true;
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // btnItemExcluir
            // 
            this.btnItemExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItemExcluir.BackgroundImage = global::Rodomax.Properties.Resources._16_delete;
            this.btnItemExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnItemExcluir.Location = new System.Drawing.Point(692, 67);
            this.btnItemExcluir.Name = "btnItemExcluir";
            this.btnItemExcluir.Size = new System.Drawing.Size(93, 23);
            this.btnItemExcluir.TabIndex = 18;
            this.btnItemExcluir.Text = "Excluir";
            this.btnItemExcluir.UseVisualStyleBackColor = true;
            this.btnItemExcluir.Click += new System.EventHandler(this.btnItemExcluir_Click);
            // 
            // btnItemEditar
            // 
            this.btnItemEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItemEditar.BackgroundImage = global::Rodomax.Properties.Resources._16_edit;
            this.btnItemEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnItemEditar.Location = new System.Drawing.Point(600, 68);
            this.btnItemEditar.Name = "btnItemEditar";
            this.btnItemEditar.Size = new System.Drawing.Size(86, 23);
            this.btnItemEditar.TabIndex = 17;
            this.btnItemEditar.Text = "Editar";
            this.btnItemEditar.UseVisualStyleBackColor = true;
            this.btnItemEditar.Click += new System.EventHandler(this.btnItemEditar_Click);
            // 
            // txtItemMultiplicador
            // 
            this.txtItemMultiplicador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemMultiplicador.Location = new System.Drawing.Point(265, 67);
            this.txtItemMultiplicador.Name = "txtItemMultiplicador";
            this.txtItemMultiplicador.Size = new System.Drawing.Size(75, 20);
            this.txtItemMultiplicador.TabIndex = 35;
            this.txtItemMultiplicador.Text = "1";
            this.txtItemMultiplicador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtItemMultiplicador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemMultiplicador_KeyPress);
            this.txtItemMultiplicador.Leave += new System.EventHandler(this.txtItemMultiplicador_Leave);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(265, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Multiplicador";
            // 
            // txtItemValorTotal
            // 
            this.txtItemValorTotal.Location = new System.Drawing.Point(181, 67);
            this.txtItemValorTotal.Name = "txtItemValorTotal";
            this.txtItemValorTotal.Size = new System.Drawing.Size(78, 20);
            this.txtItemValorTotal.TabIndex = 13;
            this.txtItemValorTotal.Text = "0,00";
            this.txtItemValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtItemValorTotal.TextChanged += new System.EventHandler(this.txtItemValorTotal_TextChanged);
            this.txtItemValorTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemValorTotal_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(178, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Valor Total Item";
            // 
            // txtItemVlUnitario
            // 
            this.txtItemVlUnitario.Location = new System.Drawing.Point(104, 67);
            this.txtItemVlUnitario.Name = "txtItemVlUnitario";
            this.txtItemVlUnitario.Size = new System.Drawing.Size(70, 20);
            this.txtItemVlUnitario.TabIndex = 12;
            this.txtItemVlUnitario.Text = "0,00";
            this.txtItemVlUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtItemVlUnitario.TextChanged += new System.EventHandler(this.txtItemVlUnitario_TextChanged);
            this.txtItemVlUnitario.Enter += new System.EventHandler(this.txtItemVlUnitario_Enter);
            this.txtItemVlUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemVlUnitario_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(104, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Valor Unitário";
            // 
            // txtItemQuantidade
            // 
            this.txtItemQuantidade.Location = new System.Drawing.Point(7, 67);
            this.txtItemQuantidade.Name = "txtItemQuantidade";
            this.txtItemQuantidade.Size = new System.Drawing.Size(85, 20);
            this.txtItemQuantidade.TabIndex = 11;
            this.txtItemQuantidade.Text = "1";
            this.txtItemQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtItemQuantidade.TextChanged += new System.EventHandler(this.txtItemQuantidade_TextChanged);
            this.txtItemQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemQuantidade_KeyPress);
            this.txtItemQuantidade.Leave += new System.EventHandler(this.txtItemQuantidade_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Quantidade N.F.";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Image = global::Rodomax.Properties.Resources._16_procurar;
            this.button3.Location = new System.Drawing.Point(791, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 23);
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtItemFilial
            // 
            this.txtItemFilial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemFilial.Enabled = false;
            this.txtItemFilial.Location = new System.Drawing.Point(499, 29);
            this.txtItemFilial.Name = "txtItemFilial";
            this.txtItemFilial.Size = new System.Drawing.Size(276, 20);
            this.txtItemFilial.TabIndex = 142;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(495, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Filial Entrada Estoque / Serviço";
            // 
            // button2
            // 
            this.button2.Image = global::Rodomax.Properties.Resources._16_procurar;
            this.button2.Location = new System.Drawing.Point(358, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtItemDescricao
            // 
            this.txtItemDescricao.Location = new System.Drawing.Point(7, 30);
            this.txtItemDescricao.Name = "txtItemDescricao";
            this.txtItemDescricao.Size = new System.Drawing.Size(342, 20);
            this.txtItemDescricao.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Produto / Descrição Serviço";
            // 
            // gridItens
            // 
            this.gridItens.AllowUserToAddRows = false;
            this.gridItens.AllowUserToDeleteRows = false;
            this.gridItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.gridItens.Location = new System.Drawing.Point(6, 93);
            this.gridItens.Name = "gridItens";
            this.gridItens.ReadOnly = true;
            this.gridItens.Size = new System.Drawing.Size(876, 269);
            this.gridItens.TabIndex = 0;
            this.gridItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridItens_CellDoubleClick);
            this.gridItens.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridItens_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prod";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Descrição";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column4.HeaderText = "Qtde N.F.";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.HeaderText = "Vl Unit";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 75;
            // 
            // Column6
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column6.HeaderText = "Qtde Est";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 75;
            // 
            // Column7
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column7.HeaderText = "Vl Un. Est";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column8.HeaderText = "Vl Total";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(687, 484);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Total Itens:";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(687, 498);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 13);
            this.label18.TabIndex = 26;
            this.label18.Text = "Diferença Nota:";
            // 
            // txtDiferencaItensNota
            // 
            this.txtDiferencaItensNota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiferencaItensNota.AutoSize = true;
            this.txtDiferencaItensNota.Location = new System.Drawing.Point(787, 498);
            this.txtDiferencaItensNota.Name = "txtDiferencaItensNota";
            this.txtDiferencaItensNota.Size = new System.Drawing.Size(28, 13);
            this.txtDiferencaItensNota.TabIndex = 28;
            this.txtDiferencaItensNota.Text = "0,00";
            this.txtDiferencaItensNota.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSomaItens
            // 
            this.txtSomaItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSomaItens.AutoSize = true;
            this.txtSomaItens.Location = new System.Drawing.Point(787, 484);
            this.txtSomaItens.Name = "txtSomaItens";
            this.txtSomaItens.Size = new System.Drawing.Size(28, 13);
            this.txtSomaItens.TabIndex = 27;
            this.txtSomaItens.Text = "0,00";
            this.txtSomaItens.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmNotaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(900, 679);
            this.Name = "frmNotaEntrada";
            this.Text = "Nota de Entrada";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNotaEntrada_KeyDown);
            this.pnlBotoes.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlDireita.ResumeLayout(false);
            this.grupoItens.ResumeLayout(false);
            this.grupoItens.PerformLayout();
            this.grpEstoqueUsado.ResumeLayout(false);
            this.grpEstoqueUsado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscaFornecedor;
        private System.Windows.Forms.TextBox txtOdemCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtDiferencaItensNota;
        private System.Windows.Forms.Label txtSomaItens;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox grupoItens;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.Button btnItemExcluir;
        private System.Windows.Forms.Button btnItemEditar;
        private System.Windows.Forms.TextBox txtItemMultiplicador;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtItemValorTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtItemVlUnitario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtItemQuantidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtItemFilial;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtItemDescricao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView gridItens;
        private System.Windows.Forms.TextBox txtValorTotalDocumento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAcresDesc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValorDocumento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txtDataFaturamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtDataEmissao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnContasPagar;
        private System.Windows.Forms.ComboBox cbFinanceiro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnItemLimpar;
        private System.Windows.Forms.GroupBox grpEstoqueUsado;
        private System.Windows.Forms.RadioButton rdUsado;
        private System.Windows.Forms.RadioButton rdNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}
