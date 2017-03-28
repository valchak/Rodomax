namespace Rodomax
{
    partial class frmProdutoGrupoPesquisa
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
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPesquisaResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesquisa)).BeginInit();
            this.SuspendLayout();
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
            // gridPesquisa
            // 
            this.gridPesquisa.AllowUserToAddRows = false;
            this.gridPesquisa.AllowUserToDeleteRows = false;
            this.gridPesquisa.AllowUserToOrderColumns = true;
            this.gridPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.Column1});
            this.gridPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPesquisa.Location = new System.Drawing.Point(0, 0);
            this.gridPesquisa.Name = "gridPesquisa";
            this.gridPesquisa.ReadOnly = true;
            this.gridPesquisa.Size = new System.Drawing.Size(602, 354);
            this.gridPesquisa.TabIndex = 1;
            this.gridPesquisa.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridPesquisa_MouseDoubleClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "Cod";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 50;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Grupo de Produtos";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // frmProdutoGrupoPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(626, 486);
            this.Name = "frmProdutoGrupoPesquisa";
            this.Text = "Consulta Grupo Estoque";
            this.pnlPesquisaResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
