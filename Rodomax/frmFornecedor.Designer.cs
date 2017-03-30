namespace Rodomax
{
    partial class frmFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornecedor));
            this.txtId = new System.Windows.Forms.TextBox();
            this.grupoPessoa = new System.Windows.Forms.GroupBox();
            this.rdCPF = new MetroFramework.Controls.MetroRadioButton();
            this.rdCNPJ = new MetroFramework.Controls.MetroRadioButton();
            this.txtRazaoSocial = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtCNPJCPF = new System.Windows.Forms.TextBox();
            this.txtIE = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.labo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.btnCidade = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.pnlBotoes.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.pnlDireita.SuspendLayout();
            this.grupoPessoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Size = new System.Drawing.Size(556, 94);
            // 
            // btnNovo
            // 
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.label10);
            this.pnlDados.Controls.Add(this.txtObservacao);
            this.pnlDados.Controls.Add(this.label9);
            this.pnlDados.Controls.Add(this.txtEmail);
            this.pnlDados.Controls.Add(this.label8);
            this.pnlDados.Controls.Add(this.txtContato);
            this.pnlDados.Controls.Add(this.label7);
            this.pnlDados.Controls.Add(this.label6);
            this.pnlDados.Controls.Add(this.label5);
            this.pnlDados.Controls.Add(this.label4);
            this.pnlDados.Controls.Add(this.btnCidade);
            this.pnlDados.Controls.Add(this.ad);
            this.pnlDados.Controls.Add(this.txtCidade);
            this.pnlDados.Controls.Add(this.label3);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Controls.Add(this.labo);
            this.pnlDados.Controls.Add(this.txtCEP);
            this.pnlDados.Controls.Add(this.txtEndereco);
            this.pnlDados.Controls.Add(this.txtTelefone);
            this.pnlDados.Controls.Add(this.txtIE);
            this.pnlDados.Controls.Add(this.txtCNPJCPF);
            this.pnlDados.Controls.Add(this.txtNomeFantasia);
            this.pnlDados.Controls.Add(this.txtRazaoSocial);
            this.pnlDados.Controls.Add(this.grupoPessoa);
            this.pnlDados.Controls.Add(this.txtId);
            this.pnlDados.Size = new System.Drawing.Size(553, 365);
            // 
            // pnlDireita
            // 
            this.pnlDireita.Location = new System.Drawing.Point(184, 3);
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
            this.txtId.Location = new System.Drawing.Point(22, 26);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // grupoPessoa
            // 
            this.grupoPessoa.Controls.Add(this.rdCPF);
            this.grupoPessoa.Controls.Add(this.rdCNPJ);
            this.grupoPessoa.Location = new System.Drawing.Point(315, 7);
            this.grupoPessoa.Name = "grupoPessoa";
            this.grupoPessoa.Size = new System.Drawing.Size(220, 39);
            this.grupoPessoa.TabIndex = 0;
            this.grupoPessoa.TabStop = false;
            this.grupoPessoa.Text = "Tipo de Pessoa";
            // 
            // rdCPF
            // 
            this.rdCPF.AutoSize = true;
            this.rdCPF.Location = new System.Drawing.Point(120, 19);
            this.rdCPF.Name = "rdCPF";
            this.rdCPF.Size = new System.Drawing.Size(91, 15);
            this.rdCPF.TabIndex = 1;
            this.rdCPF.TabStop = true;
            this.rdCPF.Text = "Pessoa Fisica";
            this.rdCPF.UseVisualStyleBackColor = true;
            // 
            // rdCNPJ
            // 
            this.rdCNPJ.AutoSize = true;
            this.rdCNPJ.Location = new System.Drawing.Point(6, 19);
            this.rdCNPJ.Name = "rdCNPJ";
            this.rdCNPJ.Size = new System.Drawing.Size(102, 15);
            this.rdCNPJ.TabIndex = 0;
            this.rdCNPJ.TabStop = true;
            this.rdCNPJ.Text = "Pessoa Juridica";
            this.rdCNPJ.UseVisualStyleBackColor = true;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(22, 65);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(273, 20);
            this.txtRazaoSocial.TabIndex = 1;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(22, 104);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(273, 20);
            this.txtNomeFantasia.TabIndex = 3;
            // 
            // txtCNPJCPF
            // 
            this.txtCNPJCPF.Location = new System.Drawing.Point(315, 65);
            this.txtCNPJCPF.Name = "txtCNPJCPF";
            this.txtCNPJCPF.Size = new System.Drawing.Size(220, 20);
            this.txtCNPJCPF.TabIndex = 2;
            // 
            // txtIE
            // 
            this.txtIE.Location = new System.Drawing.Point(315, 104);
            this.txtIE.Name = "txtIE";
            this.txtIE.Size = new System.Drawing.Size(220, 20);
            this.txtIE.TabIndex = 4;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(392, 142);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(143, 20);
            this.txtTelefone.TabIndex = 7;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(22, 142);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(273, 20);
            this.txtEndereco.TabIndex = 5;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(315, 142);
            this.txtCEP.Mask = "#####-###";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(71, 20);
            this.txtCEP.TabIndex = 6;
            // 
            // labo
            // 
            this.labo.AutoSize = true;
            this.labo.Location = new System.Drawing.Point(21, 10);
            this.labo.Name = "labo";
            this.labo.Size = new System.Drawing.Size(40, 13);
            this.labo.TabIndex = 8;
            this.labo.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Razão Social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome Fantasia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Endereço";
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Location = new System.Drawing.Point(21, 169);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(40, 13);
            this.ad.TabIndex = 13;
            this.ad.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(22, 184);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(237, 20);
            this.txtCidade.TabIndex = 12;
            // 
            // btnCidade
            // 
            this.btnCidade.Image = ((System.Drawing.Image)(resources.GetObject("btnCidade.Image")));
            this.btnCidade.Location = new System.Drawing.Point(262, 181);
            this.btnCidade.Name = "btnCidade";
            this.btnCidade.Size = new System.Drawing.Size(33, 23);
            this.btnCidade.TabIndex = 8;
            this.btnCidade.UseVisualStyleBackColor = true;
            this.btnCidade.Click += new System.EventHandler(this.btnCidade_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "CEP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(314, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "CPF / CNPJ";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(315, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "I.E.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Contato";
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(315, 184);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(220, 20);
            this.txtContato.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(22, 222);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(513, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Observação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(21, 260);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(513, 87);
            this.txtObservacao.TabIndex = 11;
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 516);
            this.Name = "frmFornecedor";
            this.Text = "Cadastro de Fornecedro";
            this.pnlBotoes.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlDireita.ResumeLayout(false);
            this.grupoPessoa.ResumeLayout(false);
            this.grupoPessoa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.MaskedTextBox txtRazaoSocial;
        private System.Windows.Forms.GroupBox grupoPessoa;
        private MetroFramework.Controls.MetroRadioButton rdCPF;
        private MetroFramework.Controls.MetroRadioButton rdCNPJ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labo;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtIE;
        private System.Windows.Forms.TextBox txtCNPJCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCidade;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.TextBox txtCidade;
    }
}