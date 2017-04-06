namespace Rodomax
{
    partial class frmFornecedorPesquisa
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
            this.gridPesquisa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPesquisaResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyDown);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // pnlPesquisaResultado
            // 
            this.pnlPesquisaResultado.Controls.Add(this.gridPesquisa);
            // 
            // btnSelecionarPesquisa
            // 
            this.btnSelecionarPesquisa.Click += new System.EventHandler(this.btnSelecionarPesquisa_Click);
            // 
            // btnCriarNovo
            // 
            this.btnCriarNovo.Click += new System.EventHandler(this.btnCriarNovo_Click);
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
            this.gridPesquisa.Size = new System.Drawing.Size(602, 354);
            this.gridPesquisa.TabIndex = 1;
            this.gridPesquisa.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridPesquisa_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cod";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Razão Social";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Nome Fantasia";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefone";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // frmFornecedorPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(626, 486);
            this.KeyPreview = true;
            this.Name = "frmFornecedorPesquisa";
            this.Text = "Consulta Fornecedor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFornecedorPesquisa_KeyDown);
            this.pnlPesquisaResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView gridPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
