namespace Rodomax
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuAdministrativo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadFilial = new System.Windows.Forms.ToolStripMenuItem();
            this.cadUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCentroDeCusto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadCidade = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOperacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNotaEntrada = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEstoqueSaida = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUtil = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlterarSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentoDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAdministrativo,
            this.MenuCadastros,
            this.MenuOperacoes,
            this.MenuUtil,
            this.relatórioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1163, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuAdministrativo
            // 
            this.MenuAdministrativo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadFilial,
            this.cadUsuario,
            this.menuCentroDeCusto});
            this.MenuAdministrativo.Name = "MenuAdministrativo";
            this.MenuAdministrativo.Size = new System.Drawing.Size(97, 20);
            this.MenuAdministrativo.Text = "Administrativo";
            this.MenuAdministrativo.Visible = false;
            // 
            // menuCadFilial
            // 
            this.menuCadFilial.Name = "menuCadFilial";
            this.menuCadFilial.Size = new System.Drawing.Size(187, 22);
            this.menuCadFilial.Text = "Cad. Filial";
            this.menuCadFilial.Visible = false;
            this.menuCadFilial.Click += new System.EventHandler(this.cadFilialToolStripMenuItem1_Click);
            // 
            // cadUsuario
            // 
            this.cadUsuario.Name = "cadUsuario";
            this.cadUsuario.Size = new System.Drawing.Size(187, 22);
            this.cadUsuario.Text = "Cad. Usuário";
            this.cadUsuario.Visible = false;
            this.cadUsuario.Click += new System.EventHandler(this.cadUsuárioToolStripMenuItem_Click);
            // 
            // menuCentroDeCusto
            // 
            this.menuCentroDeCusto.Name = "menuCentroDeCusto";
            this.menuCentroDeCusto.Size = new System.Drawing.Size(187, 22);
            this.menuCentroDeCusto.Text = "Cad. Centro de Custo";
            this.menuCentroDeCusto.Click += new System.EventHandler(this.menuCentroDeCusto_Click);
            // 
            // MenuCadastros
            // 
            this.MenuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadFornecedor,
            this.menuCadFuncionario,
            this.menuCadProduto,
            this.menuCadCidade});
            this.MenuCadastros.Name = "MenuCadastros";
            this.MenuCadastros.Size = new System.Drawing.Size(71, 20);
            this.MenuCadastros.Text = "Cadastros";
            // 
            // menuCadFornecedor
            // 
            this.menuCadFornecedor.Name = "menuCadFornecedor";
            this.menuCadFornecedor.Size = new System.Drawing.Size(164, 22);
            this.menuCadFornecedor.Text = "Cad. Fornecedor";
            this.menuCadFornecedor.Visible = false;
            this.menuCadFornecedor.Click += new System.EventHandler(this.cadFornecedorToolStripMenuItem_Click);
            // 
            // menuCadFuncionario
            // 
            this.menuCadFuncionario.Name = "menuCadFuncionario";
            this.menuCadFuncionario.Size = new System.Drawing.Size(164, 22);
            this.menuCadFuncionario.Text = "Cad. Funcionário";
            this.menuCadFuncionario.Visible = false;
            this.menuCadFuncionario.Click += new System.EventHandler(this.cadFuncionárioToolStripMenuItem_Click);
            // 
            // menuCadProduto
            // 
            this.menuCadProduto.Name = "menuCadProduto";
            this.menuCadProduto.Size = new System.Drawing.Size(164, 22);
            this.menuCadProduto.Text = "Cad. Produto";
            this.menuCadProduto.Visible = false;
            this.menuCadProduto.Click += new System.EventHandler(this.cadProdutoToolStripMenuItem_Click);
            // 
            // menuCadCidade
            // 
            this.menuCadCidade.Name = "menuCadCidade";
            this.menuCadCidade.Size = new System.Drawing.Size(164, 22);
            this.menuCadCidade.Text = "Cad. Cidade";
            this.menuCadCidade.Visible = false;
            this.menuCadCidade.Click += new System.EventHandler(this.cadCidadeToolStripMenuItem_Click);
            // 
            // MenuOperacoes
            // 
            this.MenuOperacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNotaEntrada,
            this.menuEstoqueSaida,
            this.menuEstoque});
            this.MenuOperacoes.Name = "MenuOperacoes";
            this.MenuOperacoes.Size = new System.Drawing.Size(75, 20);
            this.MenuOperacoes.Text = "Operações";
            // 
            // menuNotaEntrada
            // 
            this.menuNotaEntrada.Name = "menuNotaEntrada";
            this.menuNotaEntrada.Size = new System.Drawing.Size(163, 22);
            this.menuNotaEntrada.Text = "Nota de Entrada";
            this.menuNotaEntrada.Visible = false;
            this.menuNotaEntrada.Click += new System.EventHandler(this.notaDeEntradaToolStripMenuItem_Click);
            // 
            // menuEstoqueSaida
            // 
            this.menuEstoqueSaida.Name = "menuEstoqueSaida";
            this.menuEstoqueSaida.Size = new System.Drawing.Size(163, 22);
            this.menuEstoqueSaida.Text = "Saída de Estoque";
            this.menuEstoqueSaida.Visible = false;
            this.menuEstoqueSaida.Click += new System.EventHandler(this.saídaDeEstoqueToolStripMenuItem_Click);
            // 
            // menuEstoque
            // 
            this.menuEstoque.Name = "menuEstoque";
            this.menuEstoque.Size = new System.Drawing.Size(163, 22);
            this.menuEstoque.Text = "Estoque";
            this.menuEstoque.Visible = false;
            this.menuEstoque.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // MenuUtil
            // 
            this.MenuUtil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAlterarSenha});
            this.MenuUtil.Name = "MenuUtil";
            this.MenuUtil.Size = new System.Drawing.Size(37, 20);
            this.MenuUtil.Text = "Util";
            // 
            // menuAlterarSenha
            // 
            this.menuAlterarSenha.Name = "menuAlterarSenha";
            this.menuAlterarSenha.Size = new System.Drawing.Size(144, 22);
            this.menuAlterarSenha.Text = "Alterar Senha";
            this.menuAlterarSenha.Click += new System.EventHandler(this.menuAlterarSenha_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimentoDeEstoqueToolStripMenuItem});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // movimentoDeEstoqueToolStripMenuItem
            // 
            this.movimentoDeEstoqueToolStripMenuItem.Name = "movimentoDeEstoqueToolStripMenuItem";
            this.movimentoDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.movimentoDeEstoqueToolStripMenuItem.Text = "Movimento de Estoque";
            this.movimentoDeEstoqueToolStripMenuItem.Click += new System.EventHandler(this.movimentoDeEstoqueToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 577);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Rodomax Transportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastros;
        private System.Windows.Forms.ToolStripMenuItem menuCadCidade;
        private System.Windows.Forms.ToolStripMenuItem menuCadProduto;
        private System.Windows.Forms.ToolStripMenuItem MenuOperacoes;
        private System.Windows.Forms.ToolStripMenuItem menuNotaEntrada;
        private System.Windows.Forms.ToolStripMenuItem menuEstoqueSaida;
        private System.Windows.Forms.ToolStripMenuItem menuEstoque;
        private System.Windows.Forms.ToolStripMenuItem menuCadFornecedor;
        private System.Windows.Forms.ToolStripMenuItem MenuAdministrativo;
        private System.Windows.Forms.ToolStripMenuItem menuCadFilial;
        private System.Windows.Forms.ToolStripMenuItem menuCadFuncionario;
        private System.Windows.Forms.ToolStripMenuItem cadUsuario;
        private System.Windows.Forms.ToolStripMenuItem MenuUtil;
        private System.Windows.Forms.ToolStripMenuItem menuAlterarSenha;
        private System.Windows.Forms.ToolStripMenuItem menuCentroDeCusto;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentoDeEstoqueToolStripMenuItem;
    }
}

