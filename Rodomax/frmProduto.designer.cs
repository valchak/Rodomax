namespace UI
{
    partial class frmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarGrupo = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMultiplicador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdEstoqueFilialSim = new System.Windows.Forms.RadioButton();
            this.grpEstoqueFilial = new System.Windows.Forms.GroupBox();
            this.rdEstoqueFilialNao = new System.Windows.Forms.RadioButton();
            this.grpEstoqueUsado = new System.Windows.Forms.GroupBox();
            this.rdUsadoNao = new System.Windows.Forms.RadioButton();
            this.rdUsadoSim = new System.Windows.Forms.RadioButton();
            this.grpSituacao = new System.Windows.Forms.GroupBox();
            this.rdSituacaoInativo = new System.Windows.Forms.RadioButton();
            this.rdSituacaoAtivo = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtUltimaNota = new System.Windows.Forms.Label();
            this.txtUltimoValor = new System.Windows.Forms.Label();
            this.txtUltimoFornecedor = new System.Windows.Forms.Label();
            this.txtUltimaData = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustoMedio = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.pnlBotoes.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.pnlDireita.SuspendLayout();
            this.grpEstoqueFilial.SuspendLayout();
            this.grpEstoqueUsado.SuspendLayout();
            this.grpSituacao.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.pnlDados.Controls.Add(this.groupBox1);
            this.pnlDados.Controls.Add(this.txtCustoMedio);
            this.pnlDados.Controls.Add(this.groupBox4);
            this.pnlDados.Controls.Add(this.grpSituacao);
            this.pnlDados.Controls.Add(this.grpEstoqueUsado);
            this.pnlDados.Controls.Add(this.grpEstoqueFilial);
            this.pnlDados.Controls.Add(this.txtMultiplicador);
            this.pnlDados.Controls.Add(this.label5);
            this.pnlDados.Controls.Add(this.label4);
            this.pnlDados.Controls.Add(this.txtNome);
            this.pnlDados.Controls.Add(this.label3);
            this.pnlDados.Controls.Add(this.btnBuscarGrupo);
            this.pnlDados.Controls.Add(this.txtGrupo);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.txtId);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Size = new System.Drawing.Size(556, 409);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(10, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(76, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtGrupo
            // 
            this.txtGrupo.Enabled = false;
            this.txtGrupo.Location = new System.Drawing.Point(10, 94);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(446, 20);
            this.txtGrupo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grupo Produto";
            // 
            // btnBuscarGrupo
            // 
            this.btnBuscarGrupo.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarGrupo.Image")));
            this.btnBuscarGrupo.Location = new System.Drawing.Point(470, 92);
            this.btnBuscarGrupo.Name = "btnBuscarGrupo";
            this.btnBuscarGrupo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarGrupo.TabIndex = 4;
            this.btnBuscarGrupo.UseVisualStyleBackColor = true;
            this.btnBuscarGrupo.Click += new System.EventHandler(this.btnBuscarGrupo_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(11, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(535, 20);
            this.txtNome.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Custo Médio";
            // 
            // txtMultiplicador
            // 
            this.txtMultiplicador.Location = new System.Drawing.Point(224, 132);
            this.txtMultiplicador.Name = "txtMultiplicador";
            this.txtMultiplicador.Size = new System.Drawing.Size(100, 20);
            this.txtMultiplicador.TabIndex = 10;
            this.txtMultiplicador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMultiplicador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMultiplicador_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Multiplicador";
            // 
            // rdEstoqueFilialSim
            // 
            this.rdEstoqueFilialSim.AutoSize = true;
            this.rdEstoqueFilialSim.Location = new System.Drawing.Point(6, 19);
            this.rdEstoqueFilialSim.Name = "rdEstoqueFilialSim";
            this.rdEstoqueFilialSim.Size = new System.Drawing.Size(42, 17);
            this.rdEstoqueFilialSim.TabIndex = 12;
            this.rdEstoqueFilialSim.TabStop = true;
            this.rdEstoqueFilialSim.Text = "Sim";
            this.rdEstoqueFilialSim.UseVisualStyleBackColor = true;
            // 
            // grpEstoqueFilial
            // 
            this.grpEstoqueFilial.Controls.Add(this.rdEstoqueFilialNao);
            this.grpEstoqueFilial.Controls.Add(this.rdEstoqueFilialSim);
            this.grpEstoqueFilial.Location = new System.Drawing.Point(14, 158);
            this.grpEstoqueFilial.Name = "grpEstoqueFilial";
            this.grpEstoqueFilial.Size = new System.Drawing.Size(132, 42);
            this.grpEstoqueFilial.TabIndex = 13;
            this.grpEstoqueFilial.TabStop = false;
            this.grpEstoqueFilial.Text = "Estoque Filial";
            // 
            // rdEstoqueFilialNao
            // 
            this.rdEstoqueFilialNao.AutoSize = true;
            this.rdEstoqueFilialNao.Location = new System.Drawing.Point(68, 19);
            this.rdEstoqueFilialNao.Name = "rdEstoqueFilialNao";
            this.rdEstoqueFilialNao.Size = new System.Drawing.Size(45, 17);
            this.rdEstoqueFilialNao.TabIndex = 13;
            this.rdEstoqueFilialNao.TabStop = true;
            this.rdEstoqueFilialNao.Text = "Não";
            this.rdEstoqueFilialNao.UseVisualStyleBackColor = true;
            // 
            // grpEstoqueUsado
            // 
            this.grpEstoqueUsado.Controls.Add(this.rdUsadoNao);
            this.grpEstoqueUsado.Controls.Add(this.rdUsadoSim);
            this.grpEstoqueUsado.Location = new System.Drawing.Point(220, 158);
            this.grpEstoqueUsado.Name = "grpEstoqueUsado";
            this.grpEstoqueUsado.Size = new System.Drawing.Size(132, 42);
            this.grpEstoqueUsado.TabIndex = 14;
            this.grpEstoqueUsado.TabStop = false;
            this.grpEstoqueUsado.Text = "Estoque Usado?";
            // 
            // rdUsadoNao
            // 
            this.rdUsadoNao.AutoSize = true;
            this.rdUsadoNao.Location = new System.Drawing.Point(68, 19);
            this.rdUsadoNao.Name = "rdUsadoNao";
            this.rdUsadoNao.Size = new System.Drawing.Size(45, 17);
            this.rdUsadoNao.TabIndex = 13;
            this.rdUsadoNao.TabStop = true;
            this.rdUsadoNao.Text = "Não";
            this.rdUsadoNao.UseVisualStyleBackColor = true;
            // 
            // rdUsadoSim
            // 
            this.rdUsadoSim.AutoSize = true;
            this.rdUsadoSim.Location = new System.Drawing.Point(6, 19);
            this.rdUsadoSim.Name = "rdUsadoSim";
            this.rdUsadoSim.Size = new System.Drawing.Size(42, 17);
            this.rdUsadoSim.TabIndex = 12;
            this.rdUsadoSim.TabStop = true;
            this.rdUsadoSim.Text = "Sim";
            this.rdUsadoSim.UseVisualStyleBackColor = true;
            // 
            // grpSituacao
            // 
            this.grpSituacao.Controls.Add(this.rdSituacaoInativo);
            this.grpSituacao.Controls.Add(this.rdSituacaoAtivo);
            this.grpSituacao.Location = new System.Drawing.Point(413, 158);
            this.grpSituacao.Name = "grpSituacao";
            this.grpSituacao.Size = new System.Drawing.Size(132, 42);
            this.grpSituacao.TabIndex = 15;
            this.grpSituacao.TabStop = false;
            this.grpSituacao.Text = "Situação";
            // 
            // rdSituacaoInativo
            // 
            this.rdSituacaoInativo.AutoSize = true;
            this.rdSituacaoInativo.Location = new System.Drawing.Point(68, 19);
            this.rdSituacaoInativo.Name = "rdSituacaoInativo";
            this.rdSituacaoInativo.Size = new System.Drawing.Size(57, 17);
            this.rdSituacaoInativo.TabIndex = 13;
            this.rdSituacaoInativo.TabStop = true;
            this.rdSituacaoInativo.Text = "Inativo";
            this.rdSituacaoInativo.UseVisualStyleBackColor = true;
            // 
            // rdSituacaoAtivo
            // 
            this.rdSituacaoAtivo.AutoSize = true;
            this.rdSituacaoAtivo.Location = new System.Drawing.Point(6, 19);
            this.rdSituacaoAtivo.Name = "rdSituacaoAtivo";
            this.rdSituacaoAtivo.Size = new System.Drawing.Size(49, 17);
            this.rdSituacaoAtivo.TabIndex = 12;
            this.rdSituacaoAtivo.TabStop = true;
            this.rdSituacaoAtivo.Text = "Ativo";
            this.rdSituacaoAtivo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Fornecedor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Data:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtUltimaNota);
            this.groupBox4.Controls.Add(this.txtUltimoValor);
            this.groupBox4.Controls.Add(this.txtUltimoFornecedor);
            this.groupBox4.Controls.Add(this.txtUltimaData);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(13, 321);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(532, 79);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados da Ultima Compra";
            // 
            // txtUltimaNota
            // 
            this.txtUltimaNota.AutoSize = true;
            this.txtUltimaNota.Location = new System.Drawing.Point(77, 61);
            this.txtUltimaNota.Name = "txtUltimaNota";
            this.txtUltimaNota.Size = new System.Drawing.Size(0, 13);
            this.txtUltimaNota.TabIndex = 7;
            // 
            // txtUltimoValor
            // 
            this.txtUltimoValor.AutoSize = true;
            this.txtUltimoValor.Location = new System.Drawing.Point(77, 48);
            this.txtUltimoValor.Name = "txtUltimoValor";
            this.txtUltimoValor.Size = new System.Drawing.Size(0, 13);
            this.txtUltimoValor.TabIndex = 6;
            // 
            // txtUltimoFornecedor
            // 
            this.txtUltimoFornecedor.AutoSize = true;
            this.txtUltimoFornecedor.Location = new System.Drawing.Point(77, 22);
            this.txtUltimoFornecedor.Name = "txtUltimoFornecedor";
            this.txtUltimoFornecedor.Size = new System.Drawing.Size(0, 13);
            this.txtUltimoFornecedor.TabIndex = 4;
            // 
            // txtUltimaData
            // 
            this.txtUltimaData.AutoSize = true;
            this.txtUltimaData.Location = new System.Drawing.Point(77, 35);
            this.txtUltimaData.Name = "txtUltimaData";
            this.txtUltimaData.Size = new System.Drawing.Size(0, 13);
            this.txtUltimaData.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Nota Fiscal:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Valor:";
            // 
            // txtCustoMedio
            // 
            this.txtCustoMedio.Location = new System.Drawing.Point(10, 132);
            this.txtCustoMedio.Name = "txtCustoMedio";
            this.txtCustoMedio.Size = new System.Drawing.Size(100, 20);
            this.txtCustoMedio.TabIndex = 21;
            this.txtCustoMedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCustoMedio.TextChanged += new System.EventHandler(this.txtCustoMedio_TextChanged);
            this.txtCustoMedio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustoMedio_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtObservacao);
            this.groupBox1.Location = new System.Drawing.Point(13, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 97);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacao.Location = new System.Drawing.Point(7, 20);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(518, 71);
            this.txtObservacao.TabIndex = 0;
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(560, 576);
            this.Name = "frmProduto";
            this.Text = "Cadastro de Produto";
            this.pnlBotoes.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlDireita.ResumeLayout(false);
            this.grpEstoqueFilial.ResumeLayout(false);
            this.grpEstoqueFilial.PerformLayout();
            this.grpEstoqueUsado.ResumeLayout(false);
            this.grpEstoqueUsado.PerformLayout();
            this.grpSituacao.ResumeLayout(false);
            this.grpSituacao.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarGrupo;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMultiplicador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpEstoqueFilial;
        private System.Windows.Forms.RadioButton rdEstoqueFilialNao;
        private System.Windows.Forms.RadioButton rdEstoqueFilialSim;
        private System.Windows.Forms.GroupBox grpSituacao;
        private System.Windows.Forms.RadioButton rdSituacaoInativo;
        private System.Windows.Forms.RadioButton rdSituacaoAtivo;
        private System.Windows.Forms.GroupBox grpEstoqueUsado;
        private System.Windows.Forms.RadioButton rdUsadoNao;
        private System.Windows.Forms.RadioButton rdUsadoSim;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label txtUltimaNota;
        private System.Windows.Forms.Label txtUltimoValor;
        private System.Windows.Forms.Label txtUltimoFornecedor;
        private System.Windows.Forms.Label txtUltimaData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCustoMedio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtObservacao;
    }
}
