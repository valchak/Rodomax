namespace Rodomax
{
    partial class frmMaterialSaida
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaterialSaida));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridItens = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCentroCusto = new System.Windows.Forms.ComboBox();
            this.btnProduto = new System.Windows.Forms.Button();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnItemLimpar = new System.Windows.Forms.Button();
            this.btnItemExcluir = new System.Windows.Forms.Button();
            this.btnItemAdicionar = new System.Windows.Forms.Button();
            this.btnItemEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoSaida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilialOrigem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataSaida = new System.Windows.Forms.DateTimePicker();
            this.txtSolicitacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFilialDestino = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFilialOrigem = new System.Windows.Forms.Button();
            this.btnFilialDestino = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.txtFuncionarioSolicitante = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.pnlBotoes.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.pnlDireita.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItens)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Size = new System.Drawing.Size(801, 94);
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.txtObservacao);
            this.pnlDados.Controls.Add(this.label7);
            this.pnlDados.Controls.Add(this.btnFuncionario);
            this.pnlDados.Controls.Add(this.txtFuncionarioSolicitante);
            this.pnlDados.Controls.Add(this.label6);
            this.pnlDados.Controls.Add(this.btnFilialDestino);
            this.pnlDados.Controls.Add(this.btnFilialOrigem);
            this.pnlDados.Controls.Add(this.txtFilialDestino);
            this.pnlDados.Controls.Add(this.label5);
            this.pnlDados.Controls.Add(this.txtSolicitacao);
            this.pnlDados.Controls.Add(this.label4);
            this.pnlDados.Controls.Add(this.txtDataSaida);
            this.pnlDados.Controls.Add(this.label3);
            this.pnlDados.Controls.Add(this.txtFilialOrigem);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.txtCodigoSaida);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Controls.Add(this.groupBox1);
            this.pnlDados.Size = new System.Drawing.Size(801, 505);
            // 
            // pnlDireita
            // 
            this.pnlDireita.Location = new System.Drawing.Point(429, 3);
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
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbCentroCusto);
            this.groupBox1.Controls.Add(this.btnProduto);
            this.groupBox1.Controls.Add(this.txtProduto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnItemLimpar);
            this.groupBox1.Controls.Add(this.btnItemExcluir);
            this.groupBox1.Controls.Add(this.btnItemAdicionar);
            this.groupBox1.Controls.Add(this.btnItemEditar);
            this.groupBox1.Location = new System.Drawing.Point(1, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 382);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Materias";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gridItens);
            this.panel1.Location = new System.Drawing.Point(0, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 289);
            this.panel1.TabIndex = 25;
            // 
            // gridItens
            // 
            this.gridItens.AllowUserToAddRows = false;
            this.gridItens.AllowUserToDeleteRows = false;
            this.gridItens.AllowUserToOrderColumns = true;
            this.gridItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.gridItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridItens.Location = new System.Drawing.Point(0, 0);
            this.gridItens.Name = "gridItens";
            this.gridItens.ReadOnly = true;
            this.gridItens.Size = new System.Drawing.Size(792, 289);
            this.gridItens.TabIndex = 22;
            this.gridItens.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridItens_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 35;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prod";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 35;
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
            this.Column4.HeaderText = "Centro de Custo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Qtde";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 40;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Custo Un";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 75;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Custo Total";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 85;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(9, 63);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 9;
            this.txtQuantidade.Text = "1";
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Quantidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Centro de Custo";
            // 
            // cbCentroCusto
            // 
            this.cbCentroCusto.DisplayMember = "value";
            this.cbCentroCusto.FormattingEnabled = true;
            this.cbCentroCusto.Location = new System.Drawing.Point(413, 27);
            this.cbCentroCusto.Name = "cbCentroCusto";
            this.cbCentroCusto.Size = new System.Drawing.Size(379, 21);
            this.cbCentroCusto.TabIndex = 10;
            this.cbCentroCusto.ValueMember = "key";
            // 
            // btnProduto
            // 
            this.btnProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnProduto.Image")));
            this.btnProduto.Location = new System.Drawing.Point(315, 27);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(75, 23);
            this.btnProduto.TabIndex = 8;
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.Enabled = false;
            this.txtProduto.Location = new System.Drawing.Point(9, 29);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(300, 20);
            this.txtProduto.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Produto";
            // 
            // btnItemLimpar
            // 
            this.btnItemLimpar.Location = new System.Drawing.Point(718, 60);
            this.btnItemLimpar.Name = "btnItemLimpar";
            this.btnItemLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnItemLimpar.TabIndex = 14;
            this.btnItemLimpar.Text = "Limpar";
            this.btnItemLimpar.UseVisualStyleBackColor = true;
            this.btnItemLimpar.Click += new System.EventHandler(this.btnItemLimpar_Click);
            // 
            // btnItemExcluir
            // 
            this.btnItemExcluir.Location = new System.Drawing.Point(616, 61);
            this.btnItemExcluir.Name = "btnItemExcluir";
            this.btnItemExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnItemExcluir.TabIndex = 13;
            this.btnItemExcluir.Text = "Excluir";
            this.btnItemExcluir.UseVisualStyleBackColor = true;
            this.btnItemExcluir.Click += new System.EventHandler(this.btnItemExcluir_Click);
            // 
            // btnItemAdicionar
            // 
            this.btnItemAdicionar.Location = new System.Drawing.Point(413, 60);
            this.btnItemAdicionar.Name = "btnItemAdicionar";
            this.btnItemAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnItemAdicionar.TabIndex = 11;
            this.btnItemAdicionar.Text = "Adicionar";
            this.btnItemAdicionar.UseVisualStyleBackColor = true;
            this.btnItemAdicionar.Click += new System.EventHandler(this.btnItemAdicionar_Click);
            // 
            // btnItemEditar
            // 
            this.btnItemEditar.Location = new System.Drawing.Point(516, 61);
            this.btnItemEditar.Name = "btnItemEditar";
            this.btnItemEditar.Size = new System.Drawing.Size(75, 23);
            this.btnItemEditar.TabIndex = 12;
            this.btnItemEditar.Text = "Editar";
            this.btnItemEditar.UseVisualStyleBackColor = true;
            this.btnItemEditar.Click += new System.EventHandler(this.btnItemEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cód: Saída";
            // 
            // txtCodigoSaida
            // 
            this.txtCodigoSaida.Location = new System.Drawing.Point(10, 19);
            this.txtCodigoSaida.Name = "txtCodigoSaida";
            this.txtCodigoSaida.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoSaida.TabIndex = 1;
            this.txtCodigoSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filial do Estoque";
            // 
            // txtFilialOrigem
            // 
            this.txtFilialOrigem.Enabled = false;
            this.txtFilialOrigem.Location = new System.Drawing.Point(10, 57);
            this.txtFilialOrigem.Name = "txtFilialOrigem";
            this.txtFilialOrigem.Size = new System.Drawing.Size(300, 20);
            this.txtFilialOrigem.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Saída";
            // 
            // txtDataSaida
            // 
            this.txtDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataSaida.Location = new System.Drawing.Point(185, 19);
            this.txtDataSaida.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.txtDataSaida.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.txtDataSaida.Name = "txtDataSaida";
            this.txtDataSaida.Size = new System.Drawing.Size(100, 20);
            this.txtDataSaida.TabIndex = 2;
            this.txtDataSaida.Value = new System.DateTime(2017, 3, 24, 9, 34, 33, 0);
            // 
            // txtSolicitacao
            // 
            this.txtSolicitacao.Location = new System.Drawing.Point(291, 19);
            this.txtSolicitacao.Name = "txtSolicitacao";
            this.txtSolicitacao.Size = new System.Drawing.Size(100, 20);
            this.txtSolicitacao.TabIndex = 3;
            this.txtSolicitacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nº Solicitação";
            // 
            // txtFilialDestino
            // 
            this.txtFilialDestino.Enabled = false;
            this.txtFilialDestino.Location = new System.Drawing.Point(10, 93);
            this.txtFilialDestino.Name = "txtFilialDestino";
            this.txtFilialDestino.Size = new System.Drawing.Size(300, 20);
            this.txtFilialDestino.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Filial Destino Produto";
            // 
            // btnFilialOrigem
            // 
            this.btnFilialOrigem.Image = ((System.Drawing.Image)(resources.GetObject("btnFilialOrigem.Image")));
            this.btnFilialOrigem.Location = new System.Drawing.Point(316, 55);
            this.btnFilialOrigem.Name = "btnFilialOrigem";
            this.btnFilialOrigem.Size = new System.Drawing.Size(75, 23);
            this.btnFilialOrigem.TabIndex = 5;
            this.btnFilialOrigem.UseVisualStyleBackColor = true;
            this.btnFilialOrigem.Click += new System.EventHandler(this.btnFilialOrigem_Click);
            // 
            // btnFilialDestino
            // 
            this.btnFilialDestino.Image = ((System.Drawing.Image)(resources.GetObject("btnFilialDestino.Image")));
            this.btnFilialDestino.Location = new System.Drawing.Point(316, 91);
            this.btnFilialDestino.Name = "btnFilialDestino";
            this.btnFilialDestino.Size = new System.Drawing.Size(75, 23);
            this.btnFilialDestino.TabIndex = 6;
            this.btnFilialDestino.UseVisualStyleBackColor = true;
            this.btnFilialDestino.Click += new System.EventHandler(this.btnFilialDestino_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncionario.Image")));
            this.btnFuncionario.Location = new System.Drawing.Point(720, 17);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnFuncionario.TabIndex = 4;
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // txtFuncionarioSolicitante
            // 
            this.txtFuncionarioSolicitante.Enabled = false;
            this.txtFuncionarioSolicitante.Location = new System.Drawing.Point(414, 19);
            this.txtFuncionarioSolicitante.Name = "txtFuncionarioSolicitante";
            this.txtFuncionarioSolicitante.Size = new System.Drawing.Size(300, 20);
            this.txtFuncionarioSolicitante.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fucionário Solicitante";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Observação:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(414, 63);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(381, 51);
            this.txtObservacao.TabIndex = 7;
            // 
            // frmMaterialSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(805, 603);
            this.Name = "frmMaterialSaida";
            this.pnlBotoes.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlDireita.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFilialDestino;
        private System.Windows.Forms.Button btnFilialOrigem;
        private System.Windows.Forms.TextBox txtFilialDestino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSolicitacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtDataSaida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilialOrigem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoSaida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.TextBox txtFuncionarioSolicitante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCentroCusto;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnItemLimpar;
        private System.Windows.Forms.Button btnItemExcluir;
        private System.Windows.Forms.Button btnItemAdicionar;
        private System.Windows.Forms.Button btnItemEditar;
    }
}
