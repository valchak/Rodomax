namespace Rodomax.Reports
{
    partial class RelEstoqueMovimento
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelEstoqueMovimento));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtDataInicio = new System.Windows.Forms.DateTimePicker();
            this.txtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fasd = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.btnGrupo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTodos = new System.Windows.Forms.RadioButton();
            this.rdEntrada = new System.Windows.Forms.RadioButton();
            this.rdSaida = new System.Windows.Forms.RadioButton();
            this.txtFilial = new System.Windows.Forms.TextBox();
            this.Filfad = new System.Windows.Forms.Label();
            this.btnFilial = new System.Windows.Forms.Button();
            this.DadosEstoqueMovimentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DadosEstoqueMovimentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Size = new System.Drawing.Size(738, 412);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFilial);
            this.panel2.Controls.Add(this.Filfad);
            this.panel2.Controls.Add(this.txtFilial);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnGrupo);
            this.panel2.Controls.Add(this.txtGrupo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtProduto);
            this.panel2.Controls.Add(this.fasd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtDataFinal);
            this.panel2.Controls.Add(this.txtDataInicio);
            this.panel2.Size = new System.Drawing.Size(328, 377);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnLimparFiltro
            // 
            this.btnLimparFiltro.Click += new System.EventHandler(this.btnLimparFiltro_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DadosRelatorio";
            reportDataSource1.Value = this.DadosEstoqueMovimentoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Rodomax.Reports.RelEstoqueMovimento.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(734, 408);
            this.reportViewer1.TabIndex = 0;
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataInicio.Location = new System.Drawing.Point(10, 125);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(118, 20);
            this.txtDataInicio.TabIndex = 0;
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataFinal.Location = new System.Drawing.Point(203, 126);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(118, 20);
            this.txtDataFinal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Até";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Movimento";
            // 
            // fasd
            // 
            this.fasd.AutoSize = true;
            this.fasd.Location = new System.Drawing.Point(7, 18);
            this.fasd.Name = "fasd";
            this.fasd.Size = new System.Drawing.Size(44, 13);
            this.fasd.TabIndex = 4;
            this.fasd.Text = "Produto";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(10, 33);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(311, 20);
            this.txtProduto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grupo";
            // 
            // txtGrupo
            // 
            this.txtGrupo.Enabled = false;
            this.txtGrupo.Location = new System.Drawing.Point(10, 79);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(270, 20);
            this.txtGrupo.TabIndex = 7;
            // 
            // btnGrupo
            // 
            this.btnGrupo.Image = ((System.Drawing.Image)(resources.GetObject("btnGrupo.Image")));
            this.btnGrupo.Location = new System.Drawing.Point(289, 77);
            this.btnGrupo.Name = "btnGrupo";
            this.btnGrupo.Size = new System.Drawing.Size(31, 23);
            this.btnGrupo.TabIndex = 8;
            this.btnGrupo.UseVisualStyleBackColor = true;
            this.btnGrupo.Click += new System.EventHandler(this.btnGrupo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdSaida);
            this.groupBox1.Controls.Add(this.rdEntrada);
            this.groupBox1.Controls.Add(this.rdTodos);
            this.groupBox1.Location = new System.Drawing.Point(3, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 49);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Movimento";
            // 
            // rdTodos
            // 
            this.rdTodos.AutoSize = true;
            this.rdTodos.Location = new System.Drawing.Point(10, 20);
            this.rdTodos.Name = "rdTodos";
            this.rdTodos.Size = new System.Drawing.Size(55, 17);
            this.rdTodos.TabIndex = 0;
            this.rdTodos.TabStop = true;
            this.rdTodos.Text = "Todos";
            this.rdTodos.UseVisualStyleBackColor = true;
            // 
            // rdEntrada
            // 
            this.rdEntrada.AutoSize = true;
            this.rdEntrada.Location = new System.Drawing.Point(121, 20);
            this.rdEntrada.Name = "rdEntrada";
            this.rdEntrada.Size = new System.Drawing.Size(62, 17);
            this.rdEntrada.TabIndex = 1;
            this.rdEntrada.TabStop = true;
            this.rdEntrada.Text = "Entrada";
            this.rdEntrada.UseVisualStyleBackColor = true;
            // 
            // rdSaida
            // 
            this.rdSaida.AutoSize = true;
            this.rdSaida.Location = new System.Drawing.Point(238, 19);
            this.rdSaida.Name = "rdSaida";
            this.rdSaida.Size = new System.Drawing.Size(54, 17);
            this.rdSaida.TabIndex = 2;
            this.rdSaida.TabStop = true;
            this.rdSaida.Text = "Saída";
            this.rdSaida.UseVisualStyleBackColor = true;
            // 
            // txtFilial
            // 
            this.txtFilial.Location = new System.Drawing.Point(10, 226);
            this.txtFilial.Name = "txtFilial";
            this.txtFilial.Size = new System.Drawing.Size(270, 20);
            this.txtFilial.TabIndex = 10;
            // 
            // Filfad
            // 
            this.Filfad.AutoSize = true;
            this.Filfad.Location = new System.Drawing.Point(10, 208);
            this.Filfad.Name = "Filfad";
            this.Filfad.Size = new System.Drawing.Size(27, 13);
            this.Filfad.TabIndex = 11;
            this.Filfad.Text = "Filial";
            // 
            // btnFilial
            // 
            this.btnFilial.Image = ((System.Drawing.Image)(resources.GetObject("btnFilial.Image")));
            this.btnFilial.Location = new System.Drawing.Point(290, 224);
            this.btnFilial.Name = "btnFilial";
            this.btnFilial.Size = new System.Drawing.Size(31, 23);
            this.btnFilial.TabIndex = 12;
            this.btnFilial.UseVisualStyleBackColor = true;
            this.btnFilial.Click += new System.EventHandler(this.btnFilial_Click);
            // 
            // DadosEstoqueMovimentoBindingSource
            // 
            this.DadosEstoqueMovimentoBindingSource.DataSource = typeof(Rodomax.Reports.DadosEstoqueMovimento);
            // 
            // RelEstoqueMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1075, 493);
            this.Name = "RelEstoqueMovimento";
            this.Text = "Relatório de Movimento de Estoque";
            this.Load += new System.EventHandler(this.RelEstoqueMovimento_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DadosEstoqueMovimentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtDataFinal;
        private System.Windows.Forms.DateTimePicker txtDataInicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdSaida;
        private System.Windows.Forms.RadioButton rdEntrada;
        private System.Windows.Forms.RadioButton rdTodos;
        private System.Windows.Forms.Button btnGrupo;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label fasd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFilial;
        private System.Windows.Forms.Label Filfad;
        private System.Windows.Forms.TextBox txtFilial;
        private System.Windows.Forms.BindingSource DadosEstoqueMovimentoBindingSource;
    }
}
