namespace UI
{
    partial class frmCidade
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCidadeId = new MetroFramework.Controls.MetroTextBox();
            this.txtCidadeNome = new MetroFramework.Controls.MetroTextBox();
            this.pnlBotoes.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.pnlDireita.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBotoes.Size = new System.Drawing.Size(676, 91);
            // 
            // btnNovo
            // 
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.txtCidadeNome);
            this.pnlDados.Controls.Add(this.txtCidadeId);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Size = new System.Drawing.Size(676, 114);
            // 
            // pnlDireita
            // 
            this.pnlDireita.Location = new System.Drawing.Point(301, 3);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome da Cidade";
            // 
            // txtCidadeId
            // 
            this.txtCidadeId.Location = new System.Drawing.Point(14, 20);
            this.txtCidadeId.Name = "txtCidadeId";
            this.txtCidadeId.Size = new System.Drawing.Size(107, 23);
            this.txtCidadeId.TabIndex = 4;
            // 
            // txtCidadeNome
            // 
            this.txtCidadeNome.Location = new System.Drawing.Point(14, 66);
            this.txtCidadeNome.Name = "txtCidadeNome";
            this.txtCidadeNome.Size = new System.Drawing.Size(640, 23);
            this.txtCidadeNome.TabIndex = 5;
            // 
            // frmCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(679, 281);
            this.Name = "frmCidade";
            this.Text = "Cadastro de Cidade";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCidade_KeyDown);
            this.pnlBotoes.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlDireita.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtCidadeId;
        private MetroFramework.Controls.MetroTextBox txtCidadeNome;
    }
}
