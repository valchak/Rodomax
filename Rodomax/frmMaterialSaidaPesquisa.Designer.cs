namespace Rodomax
{
    partial class frmMaterialSaidaPesquisa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtDataInicio = new System.Windows.Forms.DateTimePicker();
            this.txtDataFim = new System.Windows.Forms.DateTimePicker();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFilialDestino = new System.Windows.Forms.TextBox();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnFilalDestino = new System.Windows.Forms.Button();
            this.gridPesquisa = new System.Windows.Forms.DataGridView();
            this.btnFilialOrigem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPesquisaResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 54);
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.Text = "Filial Origem";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Enabled = false;
            this.txtPesquisa.Size = new System.Drawing.Size(395, 20);
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(818, 108);
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // pnlPesquisaResultado
            // 
            this.pnlPesquisaResultado.Controls.Add(this.gridPesquisa);
            this.pnlPesquisaResultado.Location = new System.Drawing.Point(12, 139);
            this.pnlPesquisaResultado.Size = new System.Drawing.Size(881, 534);
            // 
            // btnSelecionarPesquisa
            // 
            this.btnSelecionarPesquisa.Location = new System.Drawing.Point(818, 679);
            this.btnSelecionarPesquisa.Click += new System.EventHandler(this.btnSelecionarPesquisa_Click);
            // 
            // btnCriarNovo
            // 
            this.btnCriarNovo.Location = new System.Drawing.Point(12, 679);
            this.btnCriarNovo.Visible = false;
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataInicio.Location = new System.Drawing.Point(482, 109);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(101, 20);
            this.txtDataInicio.TabIndex = 6;
            this.txtDataInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataInicio_KeyPress);
            // 
            // txtDataFim
            // 
            this.txtDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataFim.Location = new System.Drawing.Point(625, 109);
            this.txtDataFim.Name = "txtDataFim";
            this.txtDataFim.Size = new System.Drawing.Size(97, 20);
            this.txtDataFim.TabIndex = 7;
            this.txtDataFim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataFim_KeyPress);
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Enabled = false;
            this.txtFuncionario.Location = new System.Drawing.Point(12, 111);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(395, 20);
            this.txtFuncionario.TabIndex = 8;
            this.txtFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFuncionario_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Funcionário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Até";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Filial Destino";
            // 
            // txtFilialDestino
            // 
            this.txtFilialDestino.Enabled = false;
            this.txtFilialDestino.Location = new System.Drawing.Point(479, 68);
            this.txtFilialDestino.Name = "txtFilialDestino";
            this.txtFilialDestino.Size = new System.Drawing.Size(371, 20);
            this.txtFilialDestino.TabIndex = 13;
            this.txtFilialDestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilialDestino_KeyPress);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Image = global::Rodomax.Properties.Resources.localizar2;
            this.btnFuncionario.Location = new System.Drawing.Point(413, 107);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(41, 23);
            this.btnFuncionario.TabIndex = 16;
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnFilalDestino
            // 
            this.btnFilalDestino.Image = global::Rodomax.Properties.Resources.localizar2;
            this.btnFilalDestino.Location = new System.Drawing.Point(852, 67);
            this.btnFilalDestino.Name = "btnFilalDestino";
            this.btnFilalDestino.Size = new System.Drawing.Size(41, 23);
            this.btnFilalDestino.TabIndex = 18;
            this.btnFilalDestino.UseVisualStyleBackColor = true;
            this.btnFilalDestino.Click += new System.EventHandler(this.btnFilalDestino_Click);
            // 
            // gridPesquisa
            // 
            this.gridPesquisa.AllowUserToAddRows = false;
            this.gridPesquisa.AllowUserToDeleteRows = false;
            this.gridPesquisa.AllowUserToOrderColumns = true;
            this.gridPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.gridPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPesquisa.Location = new System.Drawing.Point(0, 0);
            this.gridPesquisa.Name = "gridPesquisa";
            this.gridPesquisa.ReadOnly = true;
            this.gridPesquisa.Size = new System.Drawing.Size(881, 534);
            this.gridPesquisa.TabIndex = 0;
            this.gridPesquisa.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // btnFilialOrigem
            // 
            this.btnFilialOrigem.Image = global::Rodomax.Properties.Resources.localizar2;
            this.btnFilialOrigem.Location = new System.Drawing.Point(413, 67);
            this.btnFilialOrigem.Name = "btnFilialOrigem";
            this.btnFilialOrigem.Size = new System.Drawing.Size(41, 23);
            this.btnFilialOrigem.TabIndex = 19;
            this.btnFilialOrigem.UseVisualStyleBackColor = true;
            this.btnFilialOrigem.Click += new System.EventHandler(this.btnFilialOrigem_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Data Inicial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(622, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Data Final";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(737, 108);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cod";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Data Saída";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Filial Origem";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Filial Destino";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Funcionário";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // frmMaterialSaidaPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(905, 710);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFilialOrigem);
            this.Controls.Add(this.btnFilalDestino);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFilialDestino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.txtDataFim);
            this.Controls.Add(this.txtDataInicio);
            this.Name = "frmMaterialSaidaPesquisa";
            this.Text = "Consulta Saída de Material";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.Controls.SetChildIndex(this.btnFiltrar, 0);
            this.Controls.SetChildIndex(this.pnlPesquisaResultado, 0);
            this.Controls.SetChildIndex(this.btnSelecionarPesquisa, 0);
            this.Controls.SetChildIndex(this.btnCriarNovo, 0);
            this.Controls.SetChildIndex(this.txtDataInicio, 0);
            this.Controls.SetChildIndex(this.txtDataFim, 0);
            this.Controls.SetChildIndex(this.txtFuncionario, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtFilialDestino, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btnFuncionario, 0);
            this.Controls.SetChildIndex(this.btnFilalDestino, 0);
            this.Controls.SetChildIndex(this.btnFilialOrigem, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.btnLimpar, 0);
            this.pnlPesquisaResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPesquisa;
        private System.Windows.Forms.DateTimePicker txtDataInicio;
        private System.Windows.Forms.DateTimePicker txtDataFim;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFilialDestino;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnFilalDestino;
        private System.Windows.Forms.Button btnFilialOrigem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
