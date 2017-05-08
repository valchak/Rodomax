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
            this.txtLinhaCobranca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFilialContrato = new System.Windows.Forms.Button();
            this.txtFilialCobranca = new System.Windows.Forms.TextBox();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtCnpjCobranca = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdContratoAtivo = new System.Windows.Forms.RadioButton();
            this.rdContratoInativo = new System.Windows.Forms.RadioButton();
            this.cbDiaCobranca = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtLinha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFilialLinha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFilialLinha = new System.Windows.Forms.Button();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdLinhaAtiva = new System.Windows.Forms.RadioButton();
            this.rdLinhaBloqueada = new System.Windows.Forms.RadioButton();
            this.rdLinhaCancelada = new System.Windows.Forms.RadioButton();
            this.btnLimparLinha = new System.Windows.Forms.Button();
            this.btnAddLinha = new System.Windows.Forms.Button();
            this.btnExcluirLinha = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.pnlBotoes.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.pnlDireita.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Size = new System.Drawing.Size(487, 94);
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.tabControl1);
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
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(94, 2);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(3, 2);
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
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(479, 365);
            this.tabControl1.TabIndex = 2;
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
            // txtCnpjCobranca
            // 
            this.txtCnpjCobranca.Location = new System.Drawing.Point(7, 97);
            this.txtCnpjCobranca.Mask = "##.###.###/####-##";
            this.txtCnpjCobranca.Name = "txtCnpjCobranca";
            this.txtCnpjCobranca.Size = new System.Drawing.Size(139, 20);
            this.txtCnpjCobranca.TabIndex = 9;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "CNPJ Contrato";
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
            // rdContratoInativo
            // 
            this.rdContratoInativo.AutoSize = true;
            this.rdContratoInativo.Location = new System.Drawing.Point(62, 19);
            this.rdContratoInativo.Name = "rdContratoInativo";
            this.rdContratoInativo.Size = new System.Drawing.Size(57, 17);
            this.rdContratoInativo.TabIndex = 1;
            this.rdContratoInativo.TabStop = true;
            this.rdContratoInativo.Text = "Inativo";
            this.rdContratoInativo.UseVisualStyleBackColor = true;
            // 
            // cbDiaCobranca
            // 
            this.cbDiaCobranca.FormattingEnabled = true;
            this.cbDiaCobranca.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Dia Fatura";
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
            // txtLinha
            // 
            this.txtLinha.Location = new System.Drawing.Point(3, 18);
            this.txtLinha.Name = "txtLinha";
            this.txtLinha.Size = new System.Drawing.Size(127, 20);
            this.txtLinha.TabIndex = 0;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Filial";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Funcionário";
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
            // 
            // tabPage2
            // 
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
            // btnLimparLinha
            // 
            this.btnLimparLinha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparLinha.Location = new System.Drawing.Point(393, 125);
            this.btnLimparLinha.Name = "btnLimparLinha";
            this.btnLimparLinha.Size = new System.Drawing.Size(75, 23);
            this.btnLimparLinha.TabIndex = 10;
            this.btnLimparLinha.Text = "Limpar";
            this.btnLimparLinha.UseVisualStyleBackColor = true;
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
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(3, 154);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(465, 184);
            this.grid.TabIndex = 13;
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
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
    }
}
