namespace UI
{
    partial class ModelConsulta
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
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.pnlPesquisaResultado = new System.Windows.Forms.Panel();
            this.btnSelecionarPesquisa = new System.Windows.Forms.Button();
            this.btnCriarNovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Location = new System.Drawing.Point(15, 26);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(518, 20);
            this.txtPesquisa.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.Location = new System.Drawing.Point(539, 24);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Pesquisar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // pnlPesquisaResultado
            // 
            this.pnlPesquisaResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPesquisaResultado.Location = new System.Drawing.Point(12, 53);
            this.pnlPesquisaResultado.Name = "pnlPesquisaResultado";
            this.pnlPesquisaResultado.Size = new System.Drawing.Size(602, 307);
            this.pnlPesquisaResultado.TabIndex = 3;
            // 
            // btnSelecionarPesquisa
            // 
            this.btnSelecionarPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionarPesquisa.Location = new System.Drawing.Point(539, 362);
            this.btnSelecionarPesquisa.Name = "btnSelecionarPesquisa";
            this.btnSelecionarPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionarPesquisa.TabIndex = 4;
            this.btnSelecionarPesquisa.Text = "Selecionar";
            this.btnSelecionarPesquisa.UseVisualStyleBackColor = true;
            // 
            // btnCriarNovo
            // 
            this.btnCriarNovo.Location = new System.Drawing.Point(12, 362);
            this.btnCriarNovo.Name = "btnCriarNovo";
            this.btnCriarNovo.Size = new System.Drawing.Size(75, 23);
            this.btnCriarNovo.TabIndex = 5;
            this.btnCriarNovo.Text = "Novo";
            this.btnCriarNovo.UseVisualStyleBackColor = true;
            // 
            // ModelConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(626, 388);
            this.Controls.Add(this.btnCriarNovo);
            this.Controls.Add(this.btnSelecionarPesquisa);
            this.Controls.Add(this.pnlPesquisaResultado);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label1);
            this.Name = "ModelConsulta";
            this.Text = "ModelConsulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtPesquisa;
        public System.Windows.Forms.Button btnFiltrar;
        public System.Windows.Forms.Panel pnlPesquisaResultado;
        public System.Windows.Forms.Button btnSelecionarPesquisa;
        public System.Windows.Forms.Button btnCriarNovo;
    }
}