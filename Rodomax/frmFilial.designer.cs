namespace UI
{
    partial class frmFilial
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarCidade = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
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
            this.pnlBotoes.Size = new System.Drawing.Size(652, 94);
            // 
            // btnNovo
            // 
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.txtTelefone);
            this.pnlDados.Controls.Add(this.txtCep);
            this.pnlDados.Controls.Add(this.txtEmail);
            this.pnlDados.Controls.Add(this.label10);
            this.pnlDados.Controls.Add(this.txtBairro);
            this.pnlDados.Controls.Add(this.label5);
            this.pnlDados.Controls.Add(this.label9);
            this.pnlDados.Controls.Add(this.txtComplemento);
            this.pnlDados.Controls.Add(this.label8);
            this.pnlDados.Controls.Add(this.label7);
            this.pnlDados.Controls.Add(this.label6);
            this.pnlDados.Controls.Add(this.cbEmpresa);
            this.pnlDados.Controls.Add(this.btnBuscarCidade);
            this.pnlDados.Controls.Add(this.txtCidade);
            this.pnlDados.Controls.Add(this.label4);
            this.pnlDados.Controls.Add(this.txtEndereco);
            this.pnlDados.Controls.Add(this.label3);
            this.pnlDados.Controls.Add(this.txtNome);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.txtId);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Controls.Add(this.panel1);
            this.pnlDados.Size = new System.Drawing.Size(652, 448);
            // 
            // pnlDireita
            // 
            this.pnlDireita.Location = new System.Drawing.Point(280, 3);
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
            this.panel1.Location = new System.Drawing.Point(10, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 169);
            this.panel1.TabIndex = 0;
            // 
            // btnRemove1
            // 
            this.btnRemove1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove1.Location = new System.Drawing.Point(294, 111);
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
            this.btnRemoveTodos.Location = new System.Drawing.Point(295, 82);
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
            this.btnAddTodos.Location = new System.Drawing.Point(295, 53);
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
            this.btnAddSim1.Location = new System.Drawing.Point(295, 24);
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
            this.gridSim.Size = new System.Drawing.Size(285, 163);
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
            this.gridNao.Size = new System.Drawing.Size(285, 163);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome Filial";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(16, 158);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(282, 20);
            this.txtEndereco.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cidade";
            // 
            // btnBuscarCidade
            // 
            this.btnBuscarCidade.Image = global::Rodomax.Properties.Resources._16_procurar;
            this.btnBuscarCidade.Location = new System.Drawing.Point(304, 109);
            this.btnBuscarCidade.Name = "btnBuscarCidade";
            this.btnBuscarCidade.Size = new System.Drawing.Size(49, 23);
            this.btnBuscarCidade.TabIndex = 9;
            this.btnBuscarCidade.UseVisualStyleBackColor = true;
            this.btnBuscarCidade.Click += new System.EventHandler(this.btnBuscarCidade_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Empresa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "CEP";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(16, 204);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(282, 20);
            this.txtComplemento.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Complemento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(380, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Telefone";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(383, 158);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(254, 20);
            this.txtBairro.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Bairro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(18, 246);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(619, 20);
            this.txtEmail.TabIndex = 22;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(383, 109);
            this.txtCep.Mask = "00000-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(254, 20);
            this.txtCep.TabIndex = 23;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(383, 204);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(254, 20);
            this.txtTelefone.TabIndex = 24;
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Location = new System.Drawing.Point(383, 65);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(254, 21);
            this.cbEmpresa.TabIndex = 10;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(16, 109);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ReadOnly = true;
            this.txtCidade.Size = new System.Drawing.Size(282, 20);
            this.txtCidade.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 66);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(282, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(16, 22);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 2;
            // 
            // frmFilial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(656, 615);
            this.Name = "frmFilial";
            this.Text = "Cadastro de Filial";
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
        private System.Windows.Forms.Button btnBuscarCidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
    }
}
