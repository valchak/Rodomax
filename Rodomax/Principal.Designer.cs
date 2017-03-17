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
            this.cadFilialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.operaçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadCidadeToolStripMenuItem,
            this.cadFilialToolStripMenuItem,
            this.cadProdutoToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadCidadeToolStripMenuItem
            // 
            this.cadCidadeToolStripMenuItem.Name = "cadCidadeToolStripMenuItem";
            this.cadCidadeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cadCidadeToolStripMenuItem.Text = "Cad. Cidade";
            this.cadCidadeToolStripMenuItem.Click += new System.EventHandler(this.cadCidadeToolStripMenuItem_Click);
            // 
            // cadFilialToolStripMenuItem
            // 
            this.cadFilialToolStripMenuItem.Name = "cadFilialToolStripMenuItem";
            this.cadFilialToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cadFilialToolStripMenuItem.Text = "Cad. Filial";
            this.cadFilialToolStripMenuItem.Click += new System.EventHandler(this.cadFilialToolStripMenuItem_Click);
            // 
            // cadProdutoToolStripMenuItem
            // 
            this.cadProdutoToolStripMenuItem.Name = "cadProdutoToolStripMenuItem";
            this.cadProdutoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cadProdutoToolStripMenuItem.Text = "Cad. Produto";
            this.cadProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadProdutoToolStripMenuItem_Click);
            // 
            // operaçõesToolStripMenuItem
            // 
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.operaçõesToolStripMenuItem.Text = "Operações";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 284);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Rodomax";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadCidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadFilialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operaçõesToolStripMenuItem;
    }
}

