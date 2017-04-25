namespace Rodomax
{
    partial class frmCentroCusto
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemove1 = new System.Windows.Forms.Button();
            this.btnRemoveTodos = new System.Windows.Forms.Button();
            this.btnAddTodos = new System.Windows.Forms.Button();
            this.btnAddSim1 = new System.Windows.Forms.Button();
            this.gridSim = new System.Windows.Forms.DataGridView();
            this.simId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridNao = new System.Windows.Forms.DataGridView();
            this.naoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naoNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBotoes.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.pnlDireita.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNao)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Size = new System.Drawing.Size(648, 94);
            // 
            // btnNovo
            // 
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Controls.Add(this.txtNome);
            this.pnlDados.Controls.Add(this.panel1);
            this.pnlDados.Controls.Add(this.txtId);
            this.pnlDados.Size = new System.Drawing.Size(648, 366);
            // 
            // pnlDireita
            // 
            this.pnlDireita.Location = new System.Drawing.Point(276, 3);
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
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(21, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnRemove1);
            this.panel1.Controls.Add(this.btnRemoveTodos);
            this.panel1.Controls.Add(this.btnAddTodos);
            this.panel1.Controls.Add(this.btnAddSim1);
            this.panel1.Controls.Add(this.gridSim);
            this.panel1.Controls.Add(this.gridNao);
            this.panel1.Location = new System.Drawing.Point(8, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 270);
            this.panel1.TabIndex = 2;
            // 
            // btnRemove1
            // 
            this.btnRemove1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove1.Location = new System.Drawing.Point(294, 162);
            this.btnRemove1.Name = "btnRemove1";
            this.btnRemove1.Size = new System.Drawing.Size(43, 23);
            this.btnRemove1.TabIndex = 5;
            this.btnRemove1.Text = "<";
            this.btnRemove1.UseVisualStyleBackColor = true;
            this.btnRemove1.Click += new System.EventHandler(this.btnRemove1_Click);
            // 
            // btnRemoveTodos
            // 
            this.btnRemoveTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveTodos.Location = new System.Drawing.Point(295, 133);
            this.btnRemoveTodos.Name = "btnRemoveTodos";
            this.btnRemoveTodos.Size = new System.Drawing.Size(43, 23);
            this.btnRemoveTodos.TabIndex = 4;
            this.btnRemoveTodos.Text = "<<";
            this.btnRemoveTodos.UseVisualStyleBackColor = true;
            this.btnRemoveTodos.Click += new System.EventHandler(this.btnRemoveTodos_Click);
            // 
            // btnAddTodos
            // 
            this.btnAddTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTodos.Location = new System.Drawing.Point(295, 104);
            this.btnAddTodos.Name = "btnAddTodos";
            this.btnAddTodos.Size = new System.Drawing.Size(43, 23);
            this.btnAddTodos.TabIndex = 3;
            this.btnAddTodos.Text = ">>";
            this.btnAddTodos.UseVisualStyleBackColor = true;
            this.btnAddTodos.Click += new System.EventHandler(this.btnAddTodos_Click);
            // 
            // btnAddSim1
            // 
            this.btnAddSim1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSim1.Location = new System.Drawing.Point(295, 75);
            this.btnAddSim1.Name = "btnAddSim1";
            this.btnAddSim1.Size = new System.Drawing.Size(43, 23);
            this.btnAddSim1.TabIndex = 2;
            this.btnAddSim1.Text = ">";
            this.btnAddSim1.UseVisualStyleBackColor = true;
            this.btnAddSim1.Click += new System.EventHandler(this.btnAddSim1_Click);
            // 
            // gridSim
            // 
            this.gridSim.AllowUserToAddRows = false;
            this.gridSim.AllowUserToDeleteRows = false;
            this.gridSim.AllowUserToOrderColumns = true;
            this.gridSim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.simId,
            this.simNome});
            this.gridSim.Location = new System.Drawing.Point(344, 3);
            this.gridSim.Name = "gridSim";
            this.gridSim.ReadOnly = true;
            this.gridSim.Size = new System.Drawing.Size(285, 264);
            this.gridSim.TabIndex = 1;
            // 
            // simId
            // 
            this.simId.HeaderText = "Cod";
            this.simId.Name = "simId";
            this.simId.ReadOnly = true;
            this.simId.Width = 50;
            // 
            // simNome
            // 
            this.simNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.simNome.HeaderText = "Centro de Custo";
            this.simNome.Name = "simNome";
            this.simNome.ReadOnly = true;
            // 
            // gridNao
            // 
            this.gridNao.AllowUserToAddRows = false;
            this.gridNao.AllowUserToDeleteRows = false;
            this.gridNao.AllowUserToOrderColumns = true;
            this.gridNao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridNao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naoId,
            this.naoNome});
            this.gridNao.Location = new System.Drawing.Point(3, 3);
            this.gridNao.Name = "gridNao";
            this.gridNao.ReadOnly = true;
            this.gridNao.Size = new System.Drawing.Size(285, 264);
            this.gridNao.TabIndex = 0;
            // 
            // naoId
            // 
            this.naoId.HeaderText = "Cod";
            this.naoId.Name = "naoId";
            this.naoId.ReadOnly = true;
            this.naoId.Width = 50;
            // 
            // naoNome
            // 
            this.naoNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.naoNome.HeaderText = "Centro de Custo";
            this.naoNome.Name = "naoNome";
            this.naoNome.ReadOnly = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(21, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(616, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição";
            // 
            // frmCentroCusto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(652, 527);
            this.Name = "frmCentroCusto";
            this.Text = "Centro de Custos";
            this.pnlBotoes.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlDireita.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemove1;
        private System.Windows.Forms.Button btnRemoveTodos;
        private System.Windows.Forms.Button btnAddTodos;
        private System.Windows.Forms.Button btnAddSim1;
        private System.Windows.Forms.DataGridView gridSim;
        private System.Windows.Forms.DataGridViewTextBoxColumn simId;
        private System.Windows.Forms.DataGridViewTextBoxColumn simNome;
        private System.Windows.Forms.DataGridView gridNao;
        private System.Windows.Forms.DataGridViewTextBoxColumn naoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn naoNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
