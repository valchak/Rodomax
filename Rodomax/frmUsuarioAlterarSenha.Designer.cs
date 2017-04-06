namespace Rodomax
{
    partial class frmUsuarioAlterarSenha
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
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.txtNovaSenha1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNovaSenha2 = new System.Windows.Forms.TextBox();
            this.pnlBotoes.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.pnlDireita.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Size = new System.Drawing.Size(381, 94);
            // 
            // btnNovo
            // 
            this.btnNovo.Visible = false;
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.label4);
            this.pnlDados.Controls.Add(this.txtNovaSenha2);
            this.pnlDados.Controls.Add(this.label3);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Controls.Add(this.txtNovaSenha1);
            this.pnlDados.Controls.Add(this.txtSenhaAtual);
            this.pnlDados.Controls.Add(this.txtLogin);
            this.pnlDados.Size = new System.Drawing.Size(381, 177);
            // 
            // pnlDireita
            // 
            this.pnlDireita.Location = new System.Drawing.Point(9, 3);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(190, 0);
            this.btnCancelar.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(281, 0);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Visible = false;
            // 
            // txtLogin
            // 
            this.txtLogin.Enabled = false;
            this.txtLogin.Location = new System.Drawing.Point(17, 23);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(342, 20);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Location = new System.Drawing.Point(17, 61);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.PasswordChar = '*';
            this.txtSenhaAtual.Size = new System.Drawing.Size(342, 20);
            this.txtSenhaAtual.TabIndex = 1;
            this.txtSenhaAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNovaSenha1
            // 
            this.txtNovaSenha1.Location = new System.Drawing.Point(17, 102);
            this.txtNovaSenha1.Name = "txtNovaSenha1";
            this.txtNovaSenha1.PasswordChar = '*';
            this.txtNovaSenha1.Size = new System.Drawing.Size(342, 20);
            this.txtNovaSenha1.TabIndex = 2;
            this.txtNovaSenha1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha Antiga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Informe Nova Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirmar Nova Senha";
            // 
            // txtNovaSenha2
            // 
            this.txtNovaSenha2.Location = new System.Drawing.Point(17, 143);
            this.txtNovaSenha2.Name = "txtNovaSenha2";
            this.txtNovaSenha2.PasswordChar = '*';
            this.txtNovaSenha2.Size = new System.Drawing.Size(342, 20);
            this.txtNovaSenha2.TabIndex = 6;
            this.txtNovaSenha2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmUsuarioAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(385, 338);
            this.KeyPreview = true;
            this.Name = "frmUsuarioAlterarSenha";
            this.Text = "Alterar Senha";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUsuarioAlterarSenha_KeyDown);
            this.pnlBotoes.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlDireita.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNovaSenha2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNovaSenha1;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.TextBox txtLogin;
    }
}
