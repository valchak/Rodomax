﻿namespace Rodomax
{
    partial class frmDespesa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtDataInicial = new System.Windows.Forms.DateTimePicker();
            this.txtDataEmissao = new System.Windows.Forms.DateTimePicker();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtValorTitulo = new System.Windows.Forms.TextBox();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.txtLinhaContrato = new System.Windows.Forms.TextBox();
            this.btnLinhaContrato = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataVencimento = new System.Windows.Forms.DateTimePicker();
            this.txtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbTipoDespesa = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddTipoDespesa = new System.Windows.Forms.Button();
            this.btnAddLinha = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cbLinhasTelefone = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtItemValorDespesa = new System.Windows.Forms.TextBox();
            this.txtItemValorFinal = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnLimparItem = new System.Windows.Forms.Button();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.txtFilial = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtItemRateiro = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ckRateio = new System.Windows.Forms.CheckBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDiferenca = new System.Windows.Forms.Label();
            this.txtDiferencaValor = new System.Windows.Forms.Label();
            this.btnFilial = new System.Windows.Forms.Button();
            this.pnlBotoes.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.pnlDireita.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Size = new System.Drawing.Size(936, 94);
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.btnFilial);
            this.pnlDados.Controls.Add(this.cbLinhasTelefone);
            this.pnlDados.Controls.Add(this.btnAddLinha);
            this.pnlDados.Controls.Add(this.txtDiferencaValor);
            this.pnlDados.Controls.Add(this.txtDiferenca);
            this.pnlDados.Controls.Add(this.label17);
            this.pnlDados.Controls.Add(this.txtReferencia);
            this.pnlDados.Controls.Add(this.txtObservacao);
            this.pnlDados.Controls.Add(this.label19);
            this.pnlDados.Controls.Add(this.ckRateio);
            this.pnlDados.Controls.Add(this.txtItemRateiro);
            this.pnlDados.Controls.Add(this.label18);
            this.pnlDados.Controls.Add(this.txtFilial);
            this.pnlDados.Controls.Add(this.label16);
            this.pnlDados.Controls.Add(this.btnFuncionario);
            this.pnlDados.Controls.Add(this.txtFuncionario);
            this.pnlDados.Controls.Add(this.label15);
            this.pnlDados.Controls.Add(this.btnLimparItem);
            this.pnlDados.Controls.Add(this.btnExcluirItem);
            this.pnlDados.Controls.Add(this.btnAddItem);
            this.pnlDados.Controls.Add(this.label13);
            this.pnlDados.Controls.Add(this.label14);
            this.pnlDados.Controls.Add(this.txtItemValorDespesa);
            this.pnlDados.Controls.Add(this.txtItemValorFinal);
            this.pnlDados.Controls.Add(this.label12);
            this.pnlDados.Controls.Add(this.btnAddTipoDespesa);
            this.pnlDados.Controls.Add(this.label11);
            this.pnlDados.Controls.Add(this.cbTipoDespesa);
            this.pnlDados.Controls.Add(this.groupBox1);
            this.pnlDados.Controls.Add(this.label10);
            this.pnlDados.Controls.Add(this.label8);
            this.pnlDados.Controls.Add(this.label9);
            this.pnlDados.Controls.Add(this.label7);
            this.pnlDados.Controls.Add(this.label6);
            this.pnlDados.Controls.Add(this.label5);
            this.pnlDados.Controls.Add(this.txtDataVencimento);
            this.pnlDados.Controls.Add(this.txtDataFinal);
            this.pnlDados.Controls.Add(this.label4);
            this.pnlDados.Controls.Add(this.label3);
            this.pnlDados.Controls.Add(this.btnLinhaContrato);
            this.pnlDados.Controls.Add(this.txtLinhaContrato);
            this.pnlDados.Controls.Add(this.btnFornecedor);
            this.pnlDados.Controls.Add(this.txtValorTitulo);
            this.pnlDados.Controls.Add(this.txtValorTotal);
            this.pnlDados.Controls.Add(this.txtDataEmissao);
            this.pnlDados.Controls.Add(this.txtDataInicial);
            this.pnlDados.Controls.Add(this.txtDocumento);
            this.pnlDados.Controls.Add(this.txtFornecedor);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Size = new System.Drawing.Size(936, 486);
            // 
            // pnlDireita
            // 
            this.pnlDireita.Location = new System.Drawing.Point(564, 3);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fornecedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Documento";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Location = new System.Drawing.Point(6, 18);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(315, 20);
            this.txtFornecedor.TabIndex = 2;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(6, 58);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(251, 20);
            this.txtDocumento.TabIndex = 3;
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataInicial.Location = new System.Drawing.Point(710, 18);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(98, 20);
            this.txtDataInicial.TabIndex = 4;
            this.txtDataInicial.Leave += new System.EventHandler(this.txtDataInicial_Leave);
            // 
            // txtDataEmissao
            // 
            this.txtDataEmissao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataEmissao.Location = new System.Drawing.Point(710, 59);
            this.txtDataEmissao.Name = "txtDataEmissao";
            this.txtDataEmissao.Size = new System.Drawing.Size(98, 20);
            this.txtDataEmissao.TabIndex = 6;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorTotal.Location = new System.Drawing.Point(520, 18);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(100, 20);
            this.txtValorTotal.TabIndex = 8;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorTotal.TextChanged += new System.EventHandler(this.txtValorTotal_TextChanged);
            this.txtValorTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorTotal_KeyPress);
            this.txtValorTotal.Leave += new System.EventHandler(this.txtValorTotal_Leave);
            // 
            // txtValorTitulo
            // 
            this.txtValorTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorTitulo.Location = new System.Drawing.Point(388, 18);
            this.txtValorTitulo.Name = "txtValorTitulo";
            this.txtValorTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtValorTitulo.TabIndex = 9;
            this.txtValorTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorTitulo.TextChanged += new System.EventHandler(this.txtValorTitulo_TextChanged);
            this.txtValorTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorTitulo_KeyPress);
            this.txtValorTitulo.Leave += new System.EventHandler(this.txtValorTitulo_Leave);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.BackgroundImage = global::Rodomax.Properties.Resources._16_procurar;
            this.btnFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFornecedor.Location = new System.Drawing.Point(327, 16);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(39, 23);
            this.btnFornecedor.TabIndex = 10;
            this.btnFornecedor.UseVisualStyleBackColor = true;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // txtLinhaContrato
            // 
            this.txtLinhaContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLinhaContrato.Enabled = false;
            this.txtLinhaContrato.Location = new System.Drawing.Point(388, 58);
            this.txtLinhaContrato.Name = "txtLinhaContrato";
            this.txtLinhaContrato.Size = new System.Drawing.Size(232, 20);
            this.txtLinhaContrato.TabIndex = 11;
            // 
            // btnLinhaContrato
            // 
            this.btnLinhaContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLinhaContrato.BackgroundImage = global::Rodomax.Properties.Resources._16_procurar;
            this.btnLinhaContrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLinhaContrato.Location = new System.Drawing.Point(626, 57);
            this.btnLinhaContrato.Name = "btnLinhaContrato";
            this.btnLinhaContrato.Size = new System.Drawing.Size(39, 23);
            this.btnLinhaContrato.TabIndex = 12;
            this.btnLinhaContrato.UseVisualStyleBackColor = true;
            this.btnLinhaContrato.Click += new System.EventHandler(this.btnLinhaContrato_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Valor Titulo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Valor Total";
            // 
            // txtDataVencimento
            // 
            this.txtDataVencimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataVencimento.Location = new System.Drawing.Point(828, 59);
            this.txtDataVencimento.Name = "txtDataVencimento";
            this.txtDataVencimento.Size = new System.Drawing.Size(98, 20);
            this.txtDataVencimento.TabIndex = 16;
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataFinal.Location = new System.Drawing.Point(828, 19);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(98, 20);
            this.txtDataFinal.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Referência";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(707, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Período Inicial";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(825, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Período Final";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(825, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Data Vencimento";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(707, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Data Emissão";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(385, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Linha Cobrança";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.grid);
            this.groupBox1.Location = new System.Drawing.Point(3, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(923, 273);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Itens da despesa";
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToOrderColumns = true;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(3, 16);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(917, 254);
            this.grid.TabIndex = 0;
            this.grid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Seq";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Filial";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Tipo Despesa";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefône";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Funcionário";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column6.HeaderText = "Vl. Despesa";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 90;
            // 
            // Column7
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column7.HeaderText = "Diferença";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column8.HeaderText = "Vl. Total";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 80;
            // 
            // cbTipoDespesa
            // 
            this.cbTipoDespesa.DisplayMember = "value";
            this.cbTipoDespesa.FormattingEnabled = true;
            this.cbTipoDespesa.Location = new System.Drawing.Point(6, 105);
            this.cbTipoDespesa.Name = "cbTipoDespesa";
            this.cbTipoDespesa.Size = new System.Drawing.Size(315, 21);
            this.cbTipoDespesa.TabIndex = 25;
            this.cbTipoDespesa.ValueMember = "key";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Tipo de Despesa";
            // 
            // btnAddTipoDespesa
            // 
            this.btnAddTipoDespesa.BackgroundImage = global::Rodomax.Properties.Resources._16_add;
            this.btnAddTipoDespesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddTipoDespesa.Location = new System.Drawing.Point(327, 105);
            this.btnAddTipoDespesa.Name = "btnAddTipoDespesa";
            this.btnAddTipoDespesa.Size = new System.Drawing.Size(39, 23);
            this.btnAddTipoDespesa.TabIndex = 27;
            this.btnAddTipoDespesa.UseVisualStyleBackColor = true;
            this.btnAddTipoDespesa.Click += new System.EventHandler(this.btnAddTipoDespesa_Click);
            // 
            // btnAddLinha
            // 
            this.btnAddLinha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddLinha.BackgroundImage = global::Rodomax.Properties.Resources._16_add;
            this.btnAddLinha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddLinha.Location = new System.Drawing.Point(626, 103);
            this.btnAddLinha.Name = "btnAddLinha";
            this.btnAddLinha.Size = new System.Drawing.Size(39, 23);
            this.btnAddLinha.TabIndex = 30;
            this.btnAddLinha.UseVisualStyleBackColor = true;
            this.btnAddLinha.Click += new System.EventHandler(this.btnAddLinha_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(385, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Linhas Telefônicas";
            // 
            // cbLinhasTelefone
            // 
            this.cbLinhasTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLinhasTelefone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbLinhasTelefone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbLinhasTelefone.DisplayMember = "value";
            this.cbLinhasTelefone.FormattingEnabled = true;
            this.cbLinhasTelefone.Location = new System.Drawing.Point(388, 105);
            this.cbLinhasTelefone.Name = "cbLinhasTelefone";
            this.cbLinhasTelefone.Size = new System.Drawing.Size(232, 21);
            this.cbLinhasTelefone.TabIndex = 28;
            this.cbLinhasTelefone.ValueMember = "key";
            this.cbLinhasTelefone.SelectedIndexChanged += new System.EventHandler(this.cbLinhasTelefone_SelectedIndexChanged);
            this.cbLinhasTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbLinhasTelefone_KeyPress);
            this.cbLinhasTelefone.Leave += new System.EventHandler(this.cbLinhasTelefone_Leave);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(828, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Valor Final";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(707, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Valor Despesa";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtItemValorDespesa
            // 
            this.txtItemValorDespesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemValorDespesa.Location = new System.Drawing.Point(710, 108);
            this.txtItemValorDespesa.Name = "txtItemValorDespesa";
            this.txtItemValorDespesa.Size = new System.Drawing.Size(100, 20);
            this.txtItemValorDespesa.TabIndex = 32;
            this.txtItemValorDespesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtItemValorDespesa.TextChanged += new System.EventHandler(this.txtItemValorDespesa_TextChanged);
            this.txtItemValorDespesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemValorDespesa_KeyPress);
            // 
            // txtItemValorFinal
            // 
            this.txtItemValorFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemValorFinal.Location = new System.Drawing.Point(828, 108);
            this.txtItemValorFinal.Name = "txtItemValorFinal";
            this.txtItemValorFinal.Size = new System.Drawing.Size(100, 20);
            this.txtItemValorFinal.TabIndex = 31;
            this.txtItemValorFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtItemValorFinal.TextChanged += new System.EventHandler(this.txtItemValorFinal_TextChanged);
            this.txtItemValorFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemValorFinal_KeyPress);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.BackgroundImage = global::Rodomax.Properties.Resources._16_add;
            this.btnAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddItem.Location = new System.Drawing.Point(626, 177);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(95, 23);
            this.btnAddItem.TabIndex = 35;
            this.btnAddItem.Text = "Adicionar";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirItem.BackgroundImage = global::Rodomax.Properties.Resources._16_delete;
            this.btnExcluirItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluirItem.Location = new System.Drawing.Point(730, 177);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(95, 23);
            this.btnExcluirItem.TabIndex = 36;
            this.btnExcluirItem.Text = "Excluir";
            this.btnExcluirItem.UseVisualStyleBackColor = true;
            this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);
            // 
            // btnLimparItem
            // 
            this.btnLimparItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparItem.BackgroundImage = global::Rodomax.Properties.Resources._16_arrow_left;
            this.btnLimparItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimparItem.Location = new System.Drawing.Point(831, 177);
            this.btnLimparItem.Name = "btnLimparItem";
            this.btnLimparItem.Size = new System.Drawing.Size(95, 23);
            this.btnLimparItem.TabIndex = 37;
            this.btnLimparItem.Text = "Limpar";
            this.btnLimparItem.UseVisualStyleBackColor = true;
            this.btnLimparItem.Click += new System.EventHandler(this.btnLimparItem_Click);
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Enabled = false;
            this.txtFuncionario.Location = new System.Drawing.Point(7, 141);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(314, 20);
            this.txtFuncionario.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Funcionário";
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackgroundImage = global::Rodomax.Properties.Resources._16_procurar;
            this.btnFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFuncionario.Location = new System.Drawing.Point(327, 139);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(39, 23);
            this.btnFuncionario.TabIndex = 40;
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // txtFilial
            // 
            this.txtFilial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilial.Enabled = false;
            this.txtFilial.Location = new System.Drawing.Point(388, 143);
            this.txtFilial.Name = "txtFilial";
            this.txtFilial.Size = new System.Drawing.Size(232, 20);
            this.txtFilial.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(385, 130);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "Filial";
            // 
            // txtItemRateiro
            // 
            this.txtItemRateiro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemRateiro.Location = new System.Drawing.Point(710, 146);
            this.txtItemRateiro.Name = "txtItemRateiro";
            this.txtItemRateiro.Size = new System.Drawing.Size(100, 20);
            this.txtItemRateiro.TabIndex = 47;
            this.txtItemRateiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemRateiro_KeyPress);
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(707, 133);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 13);
            this.label18.TabIndex = 46;
            this.label18.Text = "Indice Rateio";
            // 
            // ckRateio
            // 
            this.ckRateio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckRateio.AutoSize = true;
            this.ckRateio.Location = new System.Drawing.Point(828, 148);
            this.ckRateio.Name = "ckRateio";
            this.ckRateio.Size = new System.Drawing.Size(83, 17);
            this.ckRateio.TabIndex = 48;
            this.ckRateio.Text = "Rateio Igual";
            this.ckRateio.UseVisualStyleBackColor = true;
            this.ckRateio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ckRateio_MouseClick);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacao.Location = new System.Drawing.Point(8, 179);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(612, 20);
            this.txtObservacao.TabIndex = 50;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 166);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 49;
            this.label19.Text = "Observação";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(266, 59);
            this.txtReferencia.Mask = "##/####";
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(100, 20);
            this.txtReferencia.TabIndex = 51;
            this.txtReferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReferencia_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(320, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 12);
            this.label17.TabIndex = 52;
            this.label17.Text = "(Mes/Ano)";
            // 
            // txtDiferenca
            // 
            this.txtDiferenca.AutoSize = true;
            this.txtDiferenca.Location = new System.Drawing.Point(626, 5);
            this.txtDiferenca.Name = "txtDiferenca";
            this.txtDiferenca.Size = new System.Drawing.Size(53, 13);
            this.txtDiferenca.TabIndex = 53;
            this.txtDiferenca.Text = "Diferença";
            // 
            // txtDiferencaValor
            // 
            this.txtDiferencaValor.AutoSize = true;
            this.txtDiferencaValor.Location = new System.Drawing.Point(637, 19);
            this.txtDiferencaValor.Name = "txtDiferencaValor";
            this.txtDiferencaValor.Size = new System.Drawing.Size(28, 13);
            this.txtDiferencaValor.TabIndex = 54;
            this.txtDiferencaValor.Text = "0,00";
            this.txtDiferencaValor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnFilial
            // 
            this.btnFilial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilial.BackgroundImage = global::Rodomax.Properties.Resources._16_procurar;
            this.btnFilial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilial.Location = new System.Drawing.Point(626, 141);
            this.btnFilial.Name = "btnFilial";
            this.btnFilial.Size = new System.Drawing.Size(39, 23);
            this.btnFilial.TabIndex = 55;
            this.btnFilial.UseVisualStyleBackColor = true;
            this.btnFilial.Click += new System.EventHandler(this.btnFilial_Click);
            // 
            // frmDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(940, 647);
            this.Name = "frmDespesa";
            this.Text = "Lançamento de Despesas";
            this.pnlBotoes.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlDireita.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.DateTimePicker txtDataEmissao;
        private System.Windows.Forms.DateTimePicker txtDataInicial;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAddTipoDespesa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbTipoDespesa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtDataVencimento;
        private System.Windows.Forms.DateTimePicker txtDataFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLinhaContrato;
        private System.Windows.Forms.TextBox txtLinhaContrato;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.TextBox txtValorTitulo;
        private System.Windows.Forms.Button btnLimparItem;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtItemValorDespesa;
        private System.Windows.Forms.TextBox txtItemValorFinal;
        private System.Windows.Forms.Button btnAddLinha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbLinhasTelefone;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox ckRateio;
        private System.Windows.Forms.TextBox txtItemRateiro;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtFilial;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox txtReferencia;
        private System.Windows.Forms.Label txtDiferencaValor;
        private System.Windows.Forms.Label txtDiferenca;
        private System.Windows.Forms.Button btnFilial;
    }
}
