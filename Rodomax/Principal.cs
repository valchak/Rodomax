using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;

namespace Rodomax
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void cadCidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutoPesquisa tela = new frmProdutoPesquisa();
            tela.ShowDialog();
            tela.Dispose();
        }
    }
}
