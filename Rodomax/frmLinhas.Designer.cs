namespace Rodomax
{
    partial class frmLinhas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtLinhaCobranca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDiaCobranca = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdContratoInativo = new System.Windows.Forms.RadioButton();
            this.rdContratoAtivo = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCnpjCobranca = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFilialContrato = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilialCobranca = new System.Windows.Forms.TextBox();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnResumo = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluirLinha = new System.Windows.Forms.Button();
            this.btnAddLinha = new System.Windows.Forms.Button();
            this.btnLimparLinha = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdLinhaCancelada = new System.Windows.Forms.RadioButton();
            this.rdLinhaBloqueada = new System.Windows.Forms.RadioButton();
            this.rdLinhaAtiva = new System.Windows.Forms.RadioButton();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.btnFilialLinha = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFilialLinha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLinha = new System.Windows.Forms.TextBox();
            this.pnlBotoes.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.pnlDireita.SuspendLayout();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Size = new System.Drawing.Size(487, 94);
            // 
            // btnNovo
            // 
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.tab);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Controls.Add(this.txtLinhaCobranca);
            this.pnlDados.Size = new System.Drawing.Size(487, 414);
            // 
            // pnlDireita
            // 
            this.pnlDireita.Location = new System.Drawing.Point(210, 3);
            this.pnlDireita.Size = new System.Drawing.Size(274, 90);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(185, 2);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(94, 2);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(3, 2);
            this.btnExcluir.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtLinhaCobranca
            // 
            this.txtLinhaCobranca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLinhaCobranca.Location = new System.Drawing.Point(3, 21);
            this.txtLinhaCobranca.Name = "txtLinhaCobranca";
            this.txtLinhaCobranca.Size = new System.Drawing.Size(476, 20);
            this.txtLinhaCobranca.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Linha Cobrança / Contrato";
            // 
            // tab
            // 
            this.tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Enabled = false;
            this.tab.Location = new System.Drawing.Point(3, 47);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(479, 365);
            this.tab.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtObservacao);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cbDiaCobranca);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtCnpjCobranca);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnFilialContrato);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtFilialCobranca);
            this.tabPage1.Controls.Add(this.btnFornecedor);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtFornecedor);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(471, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados do Contrato";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacao.Location = new System.Drawing.Point(7, 141);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(457, 192);
            this.txtObservacao.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Observação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Dia Fatura";
            // 
            // cbDiaCobranca
            // 
            this.cbDiaCobranca.FormattingEnabled = true;
            this.cbDiaCobranca.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbDiaCobranca.Location = new System.Drawing.Point(198, 99);
            this.cbDiaCobranca.Name = "cbDiaCobranca";
            this.cbDiaCobranca.Size = new System.Drawing.Size(56, 21);
            this.cbDiaCobranca.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdContratoInativo);
            this.groupBox1.Controls.Add(this.rdContratoAtivo);
            this.groupBox1.Location = new System.Drawing.Point(331, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 43);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Situação";
            // 
            // rdContratoInativo
            // 
            this.rdContratoInativo.AutoSize = true;
            this.rdContratoInativo.Location = new System.Drawing.Point(62, 19);
            this.rdContratoInativo.Name = "rdContratoInativo";
            this.rdContratoInativo.Size = new System.Drawing.Size(57, 17);
            this.rdContratoInativo.TabIndex = 1;
            this.rdContratoInativo.Text = "Inativo";
            this.rdContratoInativo.UseVisualStyleBackColor = true;
            // 
            // rdContratoAtivo
            // 
            this.rdContratoAtivo.AutoSize = true;
            this.rdContratoAtivo.Checked = true;
            this.rdContratoAtivo.Location = new System.Drawing.Point(7, 20);
            this.rdContratoAtivo.Name = "rdContratoAtivo";
            this.rdContratoAtivo.Size = new System.Drawing.Size(49, 17);
            this.rdContratoAtivo.TabIndex = 0;
            this.rdContratoAtivo.TabStop = true;
            this.rdContratoAtivo.Text = "Ativo";
            this.rdContratoAtivo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "CNPJ Contrato";
            // 
            // txtCnpjCobranca
            // 
            this.txtCnpjCobranca.Location = new System.Drawing.Point(7, 97);
            this.txtCnpjCobranca.Mask = "##.###.###/####-##";
            this.txtCnpjCobranca.Name = "txtCnpjCobranca";
            this.txtCnpjCobranca.Size = new System.Drawing.Size(139, 20);
            this.txtCnpjCobranca.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // btnFilialContrato
            // 
            this.btnFilialContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilialContrato.Image = global::Rodomax.Properties.Resources.localizar2;
            this.btnFilialContrato.Location = new System.Drawing.Point(423, 53);
            this.btnFilialContrato.Name = "btnFilialContrato";
            this.btnFilialContrato.Size = new System.Drawing.Size(41, 23);
            this.btnFilialContrato.TabIndex = 5;
            this.btnFilialContrato.UseVisualStyleBackColor = true;
            this.btnFilialContrato.Click += new System.EventHandler(this.btnFilialContrato_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Filial Fatura";
            // 
            // txtFilialCobranca
            // 
            this.txtFilialCobranca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilialCobranca.Enabled = false;
            this.txtFilialCobranca.Location = new System.Drawing.Point(6, 55);
            this.txtFilialCobranca.Name = "txtFilialCobranca";
            this.txtFilialCobranca.Size = new System.Drawing.Size(410, 20);
            this.txtFilialCobranca.TabIndex = 3;
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFornecedor.Image = global::Rodomax.Properties.Resources.localizar2;
            this.btnFornecedor.Location = new System.Drawing.Point(423, 14);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(41, 23);
            this.btnFornecedor.TabIndex = 2;
            this.btnFornecedor.UseVisualStyleBackColor = true;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fornecedor";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Location = new System.Drawing.Point(5, 17);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(412, 20);
            this.txtFornecedor.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnResumo);
            this.tabPage2.Controls.Add(this.grid);
            this.tabPage2.Controls.Add(this.btnExcluirLinha);
            this.tabPage2.Controls.Add(this.btnAddLinha);
            this.tabPage2.Controls.Add(this.btnLimparLinha);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.btnFuncionario);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtFuncionario);
            this.tabPage2.Controls.Add(this.btnFilialLinha);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtFilialLinha);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtLinha);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(471, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Linhas do Contrato";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnResumo
            // 
            this.btnResumo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnResumo.Location = new System.Drawing.Point(311, 15);
            this.btnResumo.Name = "btnResumo";
            this.btnResumo.Size = new System.Drawing.Size(157, 23);
            this.btnResumo.TabIndex = 14;
            this.btnResumo.Text = "Resumo das Linhas";
            this.btnResumo.UseVisualStyleBackColor = false;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grid.Location = new System.Drawing.Point(3, 154);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(465, 184);
            this.grid.TabIndex = 13;
            this.grid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_CellMouseDoubleClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column1.HeaderText = "Cod";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle17;
            this.Column2.HeaderText = "Linha";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle18;
            this.Column3.HeaderText = "Filial";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle19;
            this.Column4.HeaderText = "Func";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle20;
            this.Column5.HeaderText = "Situacao";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // btnExcluirLinha
            // 
            this.btnExcluirLinha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirLinha.Location = new System.Drawing.Point(311, 125);
            this.btnExcluirLinha.Name = "btnExcluirLinha";
            this.btnExcluirLinha.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirLinha.TabIndex = 12;
            this.btnExcluirLinha.Text = "Excluir";
            this.btnExcluirLinha.UseVisualStyleBackColor = true;
            this.btnExcluirLinha.Click += new System.EventHandler(this.btnExcluirLinha_Click);
            // 
            // btnAddLinha
            // 
            this.btnAddLinha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddLinha.Location = new System.Drawing.Point(230, 125);
            this.btnAddLinha.Name = "btnAddLinha";
            this.btnAddLinha.Size = new System.Drawing.Size(75, 23);
            this.btnAddLinha.TabIndex = 11;
            this.btnAddLinha.Text = "Adicionar";
            this.btnAddLinha.UseVisualStyleBackColor = true;
            this.btnAddLinha.Click += new System.EventHandler(this.btnAddLinha_Click);
            // 
            // btnLimparLinha
            // 
            this.btnLimparLinha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparLinha.Location = new System.Drawing.Point(393, 125);
            this.btnLimparLinha.Name = "btnLimparLinha";
            this.btnLimparLinha.Size = new System.Drawing.Size(75, 23);
            this.btnLimparLinha.TabIndex = 10;
            this.btnLimparLinha.Text = "Limpar";
            this.btnLimparLinha.UseVisualStyleBackColor = true;
            this.btnLimparLinha.Click += new System.EventHandler(this.btnLimparLinha_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdLinhaCancelada);
            this.groupBox2.Controls.Add(this.rdLinhaBloqueada);
            this.groupBox2.Controls.Add(this.rdLinhaAtiva);
            this.groupBox2.Location = new System.Drawing.Point(3, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 34);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Situação";
            // 
            // rdLinhaCancelada
            // 
            this.rdLinhaCancelada.AutoSize = true;
            this.rdLinhaCancelada.Location = new System.Drawing.Point(136, 11);
            this.rdLinhaCancelada.Name = "rdLinhaCancelada";
            this.rdLinhaCancelada.Size = new System.Drawing.Size(76, 17);
            this.rdLinhaCancelada.TabIndex = 2;
            this.rdLinhaCancelada.Text = "Cancelado";
            this.rdLinhaCancelada.UseVisualStyleBackColor = true;
            // 
            // rdLinhaBloqueada
            // 
            this.rdLinhaBloqueada.AutoSize = true;
            this.rdLinhaBloqueada.Location = new System.Drawing.Point(54, 11);
            this.rdLinhaBloqueada.Name = "rdLinhaBloqueada";
            this.rdLinhaBloqueada.Size = new System.Drawing.Size(76, 17);
            this.rdLinhaBloqueada.TabIndex = 1;
            this.rdLinhaBloqueada.Text = "Bloqueado";
            this.rdLinhaBloqueada.UseVisualStyleBackColor = true;
            // 
            // rdLinhaAtiva
            // 
            this.rdLinhaAtiva.AutoSize = true;
            this.rdLinhaAtiva.Checked = true;
            this.rdLinhaAtiva.Location = new System.Drawing.Point(2, 11);
            this.rdLinhaAtiva.Name = "rdLinhaAtiva";
            this.rdLinhaAtiva.Size = new System.Drawing.Size(49, 17);
            this.rdLinhaAtiva.TabIndex = 0;
            this.rdLinhaAtiva.TabStop = true;
            this.rdLinhaAtiva.Text = "Ativo";
            this.rdLinhaAtiva.UseVisualStyleBackColor = true;
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFuncionario.Image = global::Rodomax.Properties.Resources.localizar2;
            this.btnFuncionario.Location = new System.Drawing.Point(427, 92);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(41, 23);
            this.btnFuncionario.TabIndex = 8;
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Funcionário";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFuncionario.Enabled = false;
            this.txtFuncionario.Location = new System.Drawing.Point(3, 94);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(418, 20);
            this.txtFuncionario.TabIndex = 6;
            // 
            // btnFilialLinha
            // 
            this.btnFilialLinha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilialLinha.Image = global::Rodomax.Properties.Resources.localizar2;
            this.btnFilialLinha.Location = new System.Drawing.Point(427, 54);
            this.btnFilialLinha.Name = "btnFilialLinha";
            this.btnFilialLinha.Size = new System.Drawing.Size(41, 23);
            this.btnFilialLinha.TabIndex = 5;
            this.btnFilialLinha.UseVisualStyleBackColor = true;
            this.btnFilialLinha.Click += new System.EventHandler(this.btnFilialLinha_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Filial";
            // 
            // txtFilialLinha
            // 
            this.txtFilialLinha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilialLinha.Enabled = false;
            this.txtFilialLinha.Location = new System.Drawing.Point(3, 55);
            this.txtFilialLinha.Name = "txtFilialLinha";
            this.txtFilialLinha.Size = new System.Drawing.Size(418, 20);
            this.txtFilialLinha.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Linha";
            // 
            // txtLinha
            // 
            this.txtLinha.Location = new System.Drawing.Point(3, 18);
            this.txtLinha.Name = "txtLinha";
            this.txtLinha.Size = new System.Drawing.Size(127, 20);
            this.txtLinha.TabIndex = 0;
            // 
            // frmLinhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(491, 575);
            this.Name = "frmLinhas";
            this.Text = "Linhas Telefônicas";
            this.pnlBotoes.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlDireita.ResumeLayout(false);
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLinhaCobranca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFilialContrato;
        private System.Windows.Forms.TextBox txtFilialCobranca;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDiaCobranca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdContratoInativo;
        private System.Windows.Forms.RadioButton rdContratoAtivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtCnpjCobranca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.Button btnFilialLinha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFilialLinha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLinha;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btnExcluirLinha;
        private System.Windows.Forms.Button btnAddLinha;
        private System.Windows.Forms.Button btnLimparLinha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdLinhaCancelada;
        private System.Windows.Forms.RadioButton rdLinhaBloqueada;
        private System.Windows.Forms.RadioButton rdLinhaAtiva;
        private System.Windows.Forms.Button btnResumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
