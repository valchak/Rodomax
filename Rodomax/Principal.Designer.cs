namespace Rodomax
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadCidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaDeEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídaDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadFilialToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrativoToolStripMenuItem,
            this.cadastrosToolStripMenuItem,
            this.operaçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1163, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadFornecedorToolStripMenuItem,
            this.cadFuncionárioToolStripMenuItem,
            this.cadProdutoToolStripMenuItem,
            this.cadCidadeToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadCidadeToolStripMenuItem
            // 
            this.cadCidadeToolStripMenuItem.Name = "cadCidadeToolStripMenuItem";
            this.cadCidadeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cadCidadeToolStripMenuItem.Text = "Cad. Cidade";
            this.cadCidadeToolStripMenuItem.Click += new System.EventHandler(this.cadCidadeToolStripMenuItem_Click);
            // 
            // cadFornecedorToolStripMenuItem
            // 
            this.cadFornecedorToolStripMenuItem.Name = "cadFornecedorToolStripMenuItem";
            this.cadFornecedorToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cadFornecedorToolStripMenuItem.Text = "Cad. Fornecedor";
            this.cadFornecedorToolStripMenuItem.Click += new System.EventHandler(this.cadFornecedorToolStripMenuItem_Click);
            // 
            // cadProdutoToolStripMenuItem
            // 
            this.cadProdutoToolStripMenuItem.Name = "cadProdutoToolStripMenuItem";
            this.cadProdutoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cadProdutoToolStripMenuItem.Text = "Cad. Produto";
            this.cadProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadProdutoToolStripMenuItem_Click);
            // 
            // operaçõesToolStripMenuItem
            // 
            this.operaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notaDeEntradaToolStripMenuItem,
            this.saídaDeEstoqueToolStripMenuItem,
            this.estoqueToolStripMenuItem});
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.operaçõesToolStripMenuItem.Text = "Operações";
            // 
            // notaDeEntradaToolStripMenuItem
            // 
            this.notaDeEntradaToolStripMenuItem.Name = "notaDeEntradaToolStripMenuItem";
            this.notaDeEntradaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.notaDeEntradaToolStripMenuItem.Text = "Nota de Entrada";
            this.notaDeEntradaToolStripMenuItem.Click += new System.EventHandler(this.notaDeEntradaToolStripMenuItem_Click);
            // 
            // saídaDeEstoqueToolStripMenuItem
            // 
            this.saídaDeEstoqueToolStripMenuItem.Name = "saídaDeEstoqueToolStripMenuItem";
            this.saídaDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saídaDeEstoqueToolStripMenuItem.Text = "Saída de Estoque";
            this.saídaDeEstoqueToolStripMenuItem.Click += new System.EventHandler(this.saídaDeEstoqueToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // cadFuncionárioToolStripMenuItem
            // 
            this.cadFuncionárioToolStripMenuItem.Name = "cadFuncionárioToolStripMenuItem";
            this.cadFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cadFuncionárioToolStripMenuItem.Text = "Cad. Funcionário";
            this.cadFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.cadFuncionárioToolStripMenuItem_Click);
            // 
            // administrativoToolStripMenuItem
            // 
            this.administrativoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadFilialToolStripMenuItem1,
            this.cadUsuárioToolStripMenuItem});
            this.administrativoToolStripMenuItem.Name = "administrativoToolStripMenuItem";
            this.administrativoToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.administrativoToolStripMenuItem.Text = "Administrativo";
            // 
            // cadFilialToolStripMenuItem1
            // 
            this.cadFilialToolStripMenuItem1.Name = "cadFilialToolStripMenuItem1";
            this.cadFilialToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.cadFilialToolStripMenuItem1.Text = "Cad. Filial";
            this.cadFilialToolStripMenuItem1.Click += new System.EventHandler(this.cadFilialToolStripMenuItem1_Click);
            // 
            // cadUsuárioToolStripMenuItem
            // 
            this.cadUsuárioToolStripMenuItem.Name = "cadUsuárioToolStripMenuItem";
            this.cadUsuárioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cadUsuárioToolStripMenuItem.Text = "Cad. Usuário";
            this.cadUsuárioToolStripMenuItem.Click += new System.EventHandler(this.cadUsuárioToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 577);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Rodomax Transportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadCidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notaDeEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídaDeEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadFilialToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadUsuárioToolStripMenuItem;
    }
}

