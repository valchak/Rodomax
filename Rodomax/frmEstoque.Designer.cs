namespace Rodomax
{
    partial class frmEstoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridPesquisa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label0 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilial = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.grpProdutos = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdUsado = new System.Windows.Forms.RadioButton();
            this.rdNovo = new System.Windows.Forms.RadioButton();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnFilial = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.pnlBotoes.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.pnlDireita.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesquisa)).BeginInit();
            this.grpProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Enabled = false;
            this.pnlBotoes.Size = new System.Drawing.Size(1009, 94);
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.btnProduto);
            this.pnlDados.Controls.Add(this.btnFilial);
            this.pnlDados.Controls.Add(this.btnFiltrar);
            this.pnlDados.Controls.Add(this.grpProdutos);
            this.pnlDados.Controls.Add(this.txtProduto);
            this.pnlDados.Controls.Add(this.txtFilial);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.label0);
            this.pnlDados.Controls.Add(this.panel1);
            this.pnlDados.Size = new System.Drawing.Size(1009, 505);
            // 
            // pnlDireita
            // 
            this.pnlDireita.Location = new System.Drawing.Point(637, 3);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gridPesquisa);
            this.panel1.Location = new System.Drawing.Point(11, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 409);
            this.panel1.TabIndex = 0;
            // 
            // gridPesquisa
            // 
            this.gridPesquisa.AllowUserToAddRows = false;
            this.gridPesquisa.AllowUserToDeleteRows = false;
            this.gridPesquisa.AllowUserToOrderColumns = true;
            this.gridPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.gridPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPesquisa.Location = new System.Drawing.Point(0, 0);
            this.gridPesquisa.Name = "gridPesquisa";
            this.gridPesquisa.ReadOnly = true;
            this.gridPesquisa.Size = new System.Drawing.Size(988, 409);
            this.gridPesquisa.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Filial";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Produto";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "Qtde Novo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "Qtde Usado";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(8, 8);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(27, 13);
            this.label0.TabIndex = 1;
            this.label0.Text = "Filial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Produto";
            // 
            // txtFilial
            // 
            this.txtFilial.Location = new System.Drawing.Point(11, 25);
            this.txtFilial.Name = "txtFilial";
            this.txtFilial.Size = new System.Drawing.Size(300, 20);
            this.txtFilial.TabIndex = 3;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(392, 25);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(300, 20);
            this.txtProduto.TabIndex = 4;
            // 
            // grpProdutos
            // 
            this.grpProdutos.Controls.Add(this.radioButton1);
            this.grpProdutos.Controls.Add(this.rdUsado);
            this.grpProdutos.Controls.Add(this.rdNovo);
            this.grpProdutos.Location = new System.Drawing.Point(786, 10);
            this.grpProdutos.Name = "grpProdutos";
            this.grpProdutos.Size = new System.Drawing.Size(187, 37);
            this.grpProdutos.TabIndex = 5;
            this.grpProdutos.TabStop = false;
            this.grpProdutos.Text = "Tipo";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(124, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Todos";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdUsado
            // 
            this.rdUsado.AutoSize = true;
            this.rdUsado.Location = new System.Drawing.Point(62, 14);
            this.rdUsado.Name = "rdUsado";
            this.rdUsado.Size = new System.Drawing.Size(56, 17);
            this.rdUsado.TabIndex = 1;
            this.rdUsado.TabStop = true;
            this.rdUsado.Text = "Usado";
            this.rdUsado.UseVisualStyleBackColor = true;
            // 
            // rdNovo
            // 
            this.rdNovo.AutoSize = true;
            this.rdNovo.Location = new System.Drawing.Point(6, 16);
            this.rdNovo.Name = "rdNovo";
            this.rdNovo.Size = new System.Drawing.Size(51, 17);
            this.rdNovo.TabIndex = 0;
            this.rdNovo.TabStop = true;
            this.rdNovo.Text = "Novo";
            this.rdNovo.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(916, 60);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(83, 23);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnFilial
            // 
            this.btnFilial.Image = global::Rodomax.Properties.Resources._16_procurar;
            this.btnFilial.Location = new System.Drawing.Point(317, 23);
            this.btnFilial.Name = "btnFilial";
            this.btnFilial.Size = new System.Drawing.Size(52, 23);
            this.btnFilial.TabIndex = 7;
            this.btnFilial.UseVisualStyleBackColor = true;
            this.btnFilial.Click += new System.EventHandler(this.btnFilial_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.Image = global::Rodomax.Properties.Resources._16_procurar;
            this.btnProduto.Location = new System.Drawing.Point(698, 24);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(52, 23);
            this.btnProduto.TabIndex = 8;
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1013, 662);
            this.Name = "frmEstoque";
            this.Text = "Consulta de Estoque";
            this.pnlBotoes.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlDireita.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPesquisa)).EndInit();
            this.grpProdutos.ResumeLayout(false);
            this.grpProdutos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtFilial;
        private System.Windows.Forms.GroupBox grpProdutos;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdUsado;
        private System.Windows.Forms.RadioButton rdNovo;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnFilial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
