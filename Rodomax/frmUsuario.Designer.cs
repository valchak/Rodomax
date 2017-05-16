namespace Rodomax
{
    partial class frmUsuario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdInativo = new MetroFramework.Controls.MetroRadioButton();
            this.rdAtivo = new MetroFramework.Controls.MetroRadioButton();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlBotoes.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.pnlDireita.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNao)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Size = new System.Drawing.Size(627, 94);
            // 
            // btnNovo
            // 
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.label4);
            this.pnlDados.Controls.Add(this.label3);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Controls.Add(this.panel1);
            this.pnlDados.Controls.Add(this.groupBox1);
            this.pnlDados.Controls.Add(this.btnFuncionario);
            this.pnlDados.Controls.Add(this.txtSenha);
            this.pnlDados.Controls.Add(this.txtLogin);
            this.pnlDados.Controls.Add(this.txtFuncionario);
            this.pnlDados.Controls.Add(this.txtId);
            this.pnlDados.Size = new System.Drawing.Size(627, 371);
            // 
            // pnlDireita
            // 
            this.pnlDireita.Location = new System.Drawing.Point(255, 3);
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
            this.txtId.Location = new System.Drawing.Point(22, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Enabled = false;
            this.txtFuncionario.Location = new System.Drawing.Point(22, 64);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(476, 20);
            this.txtFuncionario.TabIndex = 1;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(22, 106);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(250, 20);
            this.txtLogin.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.Location = new System.Drawing.Point(365, 106);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(250, 20);
            this.txtSenha.TabIndex = 3;
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFuncionario.Image = global::Rodomax.Properties.Resources._16_procurar;
            this.btnFuncionario.Location = new System.Drawing.Point(512, 61);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(103, 23);
            this.btnFuncionario.TabIndex = 4;
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdInativo);
            this.groupBox1.Controls.Add(this.rdAtivo);
            this.groupBox1.Location = new System.Drawing.Point(449, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 51);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Situação";
            // 
            // rdInativo
            // 
            this.rdInativo.AutoSize = true;
            this.rdInativo.Location = new System.Drawing.Point(90, 19);
            this.rdInativo.Name = "rdInativo";
            this.rdInativo.Size = new System.Drawing.Size(59, 15);
            this.rdInativo.TabIndex = 1;
            this.rdInativo.TabStop = true;
            this.rdInativo.Text = "Inativo";
            this.rdInativo.UseVisualStyleBackColor = true;
            // 
            // rdAtivo
            // 
            this.rdAtivo.AutoSize = true;
            this.rdAtivo.Location = new System.Drawing.Point(6, 19);
            this.rdAtivo.Name = "rdAtivo";
            this.rdAtivo.Size = new System.Drawing.Size(51, 15);
            this.rdAtivo.TabIndex = 0;
            this.rdAtivo.TabStop = true;
            this.rdAtivo.Text = "Ativo";
            this.rdAtivo.UseVisualStyleBackColor = true;
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
            this.panel1.Location = new System.Drawing.Point(3, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 222);
            this.panel1.TabIndex = 6;
            // 
            // btnRemove1
            // 
            this.btnRemove1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove1.Location = new System.Drawing.Point(291, 142);
            this.btnRemove1.Name = "btnRemove1";
            this.btnRemove1.Size = new System.Drawing.Size(35, 23);
            this.btnRemove1.TabIndex = 5;
            this.btnRemove1.Text = "<";
            this.btnRemove1.UseVisualStyleBackColor = true;
            this.btnRemove1.Click += new System.EventHandler(this.btnRemove1_Click);
            // 
            // btnRemoveTodos
            // 
            this.btnRemoveTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveTodos.Location = new System.Drawing.Point(291, 113);
            this.btnRemoveTodos.Name = "btnRemoveTodos";
            this.btnRemoveTodos.Size = new System.Drawing.Size(35, 23);
            this.btnRemoveTodos.TabIndex = 4;
            this.btnRemoveTodos.Text = "<<";
            this.btnRemoveTodos.UseVisualStyleBackColor = true;
            this.btnRemoveTodos.Click += new System.EventHandler(this.btnRemoveTodos_Click);
            // 
            // btnAddTodos
            // 
            this.btnAddTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTodos.Location = new System.Drawing.Point(291, 84);
            this.btnAddTodos.Name = "btnAddTodos";
            this.btnAddTodos.Size = new System.Drawing.Size(35, 23);
            this.btnAddTodos.TabIndex = 3;
            this.btnAddTodos.Text = ">>";
            this.btnAddTodos.UseVisualStyleBackColor = true;
            this.btnAddTodos.Click += new System.EventHandler(this.btnAddTodos_Click);
            // 
            // btnAddSim1
            // 
            this.btnAddSim1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSim1.Location = new System.Drawing.Point(291, 55);
            this.btnAddSim1.Name = "btnAddSim1";
            this.btnAddSim1.Size = new System.Drawing.Size(35, 23);
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
            this.gridSim.Location = new System.Drawing.Point(334, 0);
            this.gridSim.Name = "gridSim";
            this.gridSim.ReadOnly = true;
            this.gridSim.Size = new System.Drawing.Size(280, 222);
            this.gridSim.TabIndex = 1;
            // 
            // simId
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simId.DefaultCellStyle = dataGridViewCellStyle1;
            this.simId.HeaderText = "Cod";
            this.simId.Name = "simId";
            this.simId.ReadOnly = true;
            this.simId.Width = 30;
            // 
            // simNome
            // 
            this.simNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simNome.DefaultCellStyle = dataGridViewCellStyle2;
            this.simNome.HeaderText = "Filial";
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
            this.gridNao.Location = new System.Drawing.Point(3, 0);
            this.gridNao.Name = "gridNao";
            this.gridNao.ReadOnly = true;
            this.gridNao.Size = new System.Drawing.Size(280, 222);
            this.gridNao.TabIndex = 0;
            // 
            // naoId
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naoId.DefaultCellStyle = dataGridViewCellStyle3;
            this.naoId.HeaderText = "Cod";
            this.naoId.Name = "naoId";
            this.naoId.ReadOnly = true;
            this.naoId.Width = 30;
            // 
            // naoNome
            // 
            this.naoNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naoNome.DefaultCellStyle = dataGridViewCellStyle4;
            this.naoNome.HeaderText = "Filial";
            this.naoNome.Name = "naoNome";
            this.naoNome.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Funcionário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Senha";
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(631, 538);
            this.Name = "frmUsuario";
            this.Text = "Cadastro de Usuário";
            this.Controls.SetChildIndex(this.pnlBotoes, 0);
            this.Controls.SetChildIndex(this.pnlDados, 0);
            this.pnlBotoes.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlDireita.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton rdInativo;
        private MetroFramework.Controls.MetroRadioButton rdAtivo;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemove1;
        private System.Windows.Forms.Button btnRemoveTodos;
        private System.Windows.Forms.Button btnAddTodos;
        private System.Windows.Forms.Button btnAddSim1;
        private System.Windows.Forms.DataGridView gridSim;
        private System.Windows.Forms.DataGridView gridNao;
        private System.Windows.Forms.DataGridViewTextBoxColumn simId;
        private System.Windows.Forms.DataGridViewTextBoxColumn simNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn naoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn naoNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}
