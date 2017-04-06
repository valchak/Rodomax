namespace Rodomax
{
    partial class frmCidadePesquisa
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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.id,
            this.cidade});
            this.gridPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPesquisa.Location = new System.Drawing.Point(0, 0);
            this.gridPesquisa.Name = "gridPesquisa";
            this.gridPesquisa.ReadOnly = true;
            this.gridPesquisa.Size = new System.Drawing.Size(602, 354);
            this.gridPesquisa.TabIndex = 1;
            this.gridPesquisa.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridPesquisa_MouseDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "Codigo";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // cidade
            // 
            this.cidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            // 
            // frmCidadePesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(626, 486);
            this.Name = "frmCidadePesquisa";
            this.Text = "Consulta de Cidade";
            this.pnlPesquisaResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
    }
}
