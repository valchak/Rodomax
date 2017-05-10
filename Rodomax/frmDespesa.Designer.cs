namespace Rodomax
{
    partial class frmDespesa
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
            this.pnlBotoes.SuspendLayout();
            this.pnlDireita.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Size = new System.Drawing.Size(1187, 94);
            // 
            // pnlDados
            // 
            this.pnlDados.Size = new System.Drawing.Size(1187, 609);
            // 
            // pnlDireita
            // 
            this.pnlDireita.Location = new System.Drawing.Point(815, 3);
            // 
            // frmDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1191, 770);
            this.Name = "frmDespesa";
            this.Text = "Lançamento de Despesas";
            this.pnlBotoes.ResumeLayout(false);
            this.pnlDireita.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
