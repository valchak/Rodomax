using System;
using UI;

namespace Rodomax
{
    public partial class Principal : MetroFramework.Forms.MetroForm
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void cadCidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCidade tela = new frmCidade();
            tela.ShowDialog();
            tela.Dispose();
        }

        private void cadFilialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFilial tela = new frmFilial();
            tela.ShowDialog();
            tela.Dispose();
        }

        private void cadProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto tela = new frmProduto();
            tela.ShowDialog();
            tela.Dispose();
        }

        private void notaDeEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotaEntrada tela = new frmNotaEntrada();
            tela.ShowDialog();
            tela.Dispose();
        }

        private void saídaDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterialSaida tela = new frmMaterialSaida();
            tela.ShowDialog();
            tela.Dispose();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstoque tela = new frmEstoque();
            tela.ShowDialog();
            tela.Dispose();
        }

        private void cadFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor tela = new frmFornecedor();
            tela.ShowDialog();
            tela.Dispose();
        }
    }
}
