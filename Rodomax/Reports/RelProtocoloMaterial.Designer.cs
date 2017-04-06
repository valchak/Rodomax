namespace Rodomax.Reports
{
    partial class RelProtocoloMaterial
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelProtocoloMaterial));
            this.DadosProtocoloMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnFilial = new System.Windows.Forms.Button();
            this.Filfad = new System.Windows.Forms.Label();
            this.txtFilial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.txtDataInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DadosProtocoloMaterialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnFilial);
            this.panel2.Controls.Add(this.Filfad);
            this.panel2.Controls.Add(this.txtFilial);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtDataFinal);
            this.panel2.Controls.Add(this.txtDataInicio);
            this.panel2.Controls.Add(this.txtId);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnLimparFiltro
            // 
            this.btnLimparFiltro.TabIndex = 7;
            this.btnLimparFiltro.Click += new System.EventHandler(this.btnLimparFiltro_Click);
            // 
            // DadosProtocoloMaterialBindingSource
            // 
            this.DadosProtocoloMaterialBindingSource.DataSource = typeof(Modelo.Reports.DadosProtocoloMaterial);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DadosRelatorio";
            reportDataSource1.Value = this.DadosProtocoloMaterialBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Rodomax.Reports.RelProtocoloUniforme.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(734, 386);
            this.reportViewer1.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(8, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // btnFilial
            // 
            this.btnFilial.Image = ((System.Drawing.Image)(resources.GetObject("btnFilial.Image")));
            this.btnFilial.Location = new System.Drawing.Point(288, 73);
            this.btnFilial.Name = "btnFilial";
            this.btnFilial.Size = new System.Drawing.Size(31, 23);
            this.btnFilial.TabIndex = 5;
            this.btnFilial.UseVisualStyleBackColor = true;
            // 
            // Filfad
            // 
            this.Filfad.AutoSize = true;
            this.Filfad.Location = new System.Drawing.Point(8, 57);
            this.Filfad.Name = "Filfad";
            this.Filfad.Size = new System.Drawing.Size(27, 13);
            this.Filfad.TabIndex = 20;
            this.Filfad.Text = "Filial";
            // 
            // txtFilial
            // 
            this.txtFilial.Location = new System.Drawing.Point(8, 75);
            this.txtFilial.Name = "txtFilial";
            this.txtFilial.Size = new System.Drawing.Size(270, 20);
            this.txtFilial.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Data Movimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Até";
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataFinal.Location = new System.Drawing.Point(201, 119);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(118, 20);
            this.txtDataFinal.TabIndex = 4;
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataInicio.Location = new System.Drawing.Point(8, 118);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(118, 20);
            this.txtDataInicio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Código Saída Material";
            // 
            // RelProtocoloMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1075, 471);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "RelProtocoloMaterial";
            this.Text = "Protocolo de Envio de Materiais";
            this.Load += new System.EventHandler(this.RelProtocoloMaterial_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RelProtocoloMaterial_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DadosProtocoloMaterialBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DadosProtocoloMaterialBindingSource;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFilial;
        private System.Windows.Forms.Label Filfad;
        private System.Windows.Forms.TextBox txtFilial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtDataFinal;
        private System.Windows.Forms.DateTimePicker txtDataInicio;
    }
}
