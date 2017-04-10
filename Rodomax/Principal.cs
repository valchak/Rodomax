using System;
using System.Windows.Forms;
using MMLib.Extensions;
using Aplicacao;
using Modelo;
using System.Linq;
using System.Threading;
using UI;
using System.Collections.Generic;
using Rodomax.Reports;

namespace Rodomax
{
    public partial class Principal : MetroFramework.Forms.MetroForm
    {
        _Singleton instancia = _Singleton.GetInstance;
        public Principal()
        {
            InitializeComponent();
            ValidaAcesso();
        }

        private void ValidaAcesso()
        {
            UsuarioApp userApp = new UsuarioApp();
            IEnumerable<Usuario> listaUser = userApp.GetAll();
            if (listaUser.Count() < 4)
            {
                this.Theme = MetroFramework.MetroThemeStyle.Dark;
            }

            SecurPerfilApp app = new SecurPerfilApp();
            SecurPerfil perfil = app.Get(x => x.Id == instancia.userLogado.Perfil.Id).First();

            if (perfil.Id == 1)
            {
                MenuAdministrativo.Visible = true;
            }

            foreach (var f in perfil.Formulario)
            {

                switch (f.Id)
                {
                    case 1:
                        menuCadCidade.Visible = true;
                        break;
                    case 2:
                        menuEstoque.Visible = true;
                        break;
                    case 3:
                        menuCadFilial.Visible = true;
                        break;
                    case 4:
                        menuCadFornecedor.Visible = true;
                        break;
                    case 5:
                        menuCadFuncionario.Visible = true;
                        break;
                    case 6:
                        menuEstoqueSaida.Visible = true;
                        break;
                    case 7:
                        menuNotaEntrada.Visible = true;
                        break;
                    case 8:
                        menuCadProduto.Visible = true;
                        break;
                    case 9:
                        cadUsuario.Visible = true;
                        break;
                    case 10:
                        cadUsuario.Visible = true;
                        break;

                }

            }


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

        private void cadFilialToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFilial tela = new frmFilial();
            tela.ShowDialog();
            tela.Dispose();
        }

        private void cadFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionario tela = new frmFuncionario();
            tela.ShowDialog();
            tela.Dispose();
        }

        private void cadUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario tela = new frmUsuario();
            tela.ShowDialog();
            tela.Dispose();
        }

        private void menuAlterarSenha_Click(object sender, EventArgs e)
        {
            frmUsuarioAlterarSenha tela = new frmUsuarioAlterarSenha();
            tela.ShowDialog();
            tela.Dispose();
        }

        private void menuCentroDeCusto_Click(object sender, EventArgs e)
        {
            frmCentroCusto tela = new frmCentroCusto();
            tela.ShowDialog();
            tela.Dispose();
        }

        private void movimentoDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelEstoqueMovimento tela = new RelEstoqueMovimento();
            tela.ShowDialog();
            tela.Dispose();
        }

        private void protocoloMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelProtocoloMaterial tela = new RelProtocoloMaterial();
            tela.ShowDialog();
            tela.Dispose();
        }
    }
}
