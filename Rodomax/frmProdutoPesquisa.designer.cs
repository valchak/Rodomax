namespace UI
{
    partial class frmProdutoPesquisa
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
            this.gridPesquisa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSituacao = new System.Windows.Forms.GroupBox();
            this.rdTodos = new System.Windows.Forms.RadioButton();
            this.rdInativo = new System.Windows.Forms.RadioButton();
            this.rdAtivo = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlPesquisaResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesquisa)).BeginInit();
            this.grpSituacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // pnlPesquisaResultado
            // 
            this.pnlPesquisaResultado.Controls.Add(this.gridPesquisa);
            this.pnlPesquisaResultado.Location = new System.Drawing.Point(12, 82);
            this.pnlPesquisaResultado.Size = new System.Drawing.Size(602, 278);
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
            this.Column5});
            this.gridPesquisa.Location = new System.Drawing.Point(0, 3);
            this.gridPesquisa.Name = "gridPesquisa";
            this.gridPesquisa.ReadOnly = true;
            this.gridPesquisa.Size = new System.Drawing.Size(602, 275);
            this.gridPesquisa.TabIndex = 0;
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
            this.Column2.HeaderText = "Produto";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Situação";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // grpSituacao
            // 
            this.grpSituacao.Controls.Add(this.rdTodos);
            this.grpSituacao.Controls.Add(this.rdInativo);
            this.grpSituacao.Controls.Add(this.rdAtivo);
            this.grpSituacao.Location = new System.Drawing.Point(15, 48);
            this.grpSituacao.Name = "grpSituacao";
            this.grpSituacao.Size = new System.Drawing.Size(327, 31);
            this.grpSituacao.TabIndex = 7;
            this.grpSituacao.TabStop = false;
            this.grpSituacao.Text = "Situacao";
            // 
            // rdTodos
            // 
            this.rdTodos.AutoSize = true;
            this.rdTodos.Location = new System.Drawing.Point(174, 11);
            this.rdTodos.Name = "rdTodos";
            this.rdTodos.Size = new System.Drawing.Size(55, 17);
            this.rdTodos.TabIndex = 2;
            this.rdTodos.TabStop = true;
            this.rdTodos.Text = "Todos";
            this.rdTodos.UseVisualStyleBackColor = true;
            // 
            // rdInativo
            // 
            this.rdInativo.AutoSize = true;
            this.rdInativo.Location = new System.Drawing.Point(91, 11);
            this.rdInativo.Name = "rdInativo";
            this.rdInativo.Size = new System.Drawing.Size(57, 17);
            this.rdInativo.TabIndex = 1;
            this.rdInativo.TabStop = true;
            this.rdInativo.Text = "Inativo";
            this.rdInativo.UseVisualStyleBackColor = true;
            // 
            // rdAtivo
            // 
            this.rdAtivo.AutoSize = true;
            this.rdAtivo.Location = new System.Drawing.Point(7, 11);
            this.rdAtivo.Name = "rdAtivo";
            this.rdAtivo.Size = new System.Drawing.Size(49, 17);
            this.rdAtivo.TabIndex = 0;
            this.rdAtivo.TabStop = true;
            this.rdAtivo.Text = "Ativo";
            this.rdAtivo.UseVisualStyleBackColor = true;
            // 
            // frmProdutoPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(626, 388);
            this.Controls.Add(this.grpSituacao);
            this.Name = "frmProdutoPesquisa";
            this.Text = "Consulta Produtos";
            this.Controls.SetChildIndex(this.grpSituacao, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.Controls.SetChildIndex(this.btnFiltrar, 0);
            this.Controls.SetChildIndex(this.pnlPesquisaResultado, 0);
            this.Controls.SetChildIndex(this.btnSelecionarPesquisa, 0);
            this.Controls.SetChildIndex(this.btnCriarNovo, 0);
            this.pnlPesquisaResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPesquisa)).EndInit();
            this.grpSituacao.ResumeLayout(false);
            this.grpSituacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPesquisa;
        private System.Windows.Forms.GroupBox grpSituacao;
        private System.Windows.Forms.RadioButton rdTodos;
        private System.Windows.Forms.RadioButton rdInativo;
        private System.Windows.Forms.RadioButton rdAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
