﻿using System;
using System.Windows.Forms;

namespace UI
{
    public partial class ModelForm : Form
    {
        public String operacao;
        public ModelForm()
        {
            InitializeComponent();
        }

        public void AlteraBotoes(int op)
        {
            // 1 Prepara os botoes para Limpar e localiza
            // 2 Prepara os botoes para inserir/alterar um registro
            // 3 Prepara a tela para exluir ou alterar

            pnlDados.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnPesquisar.Enabled = false;
            btnSalvar.Enabled = false;
            //cancelar / abrir formulário
            if (op == 1) 
            {
                btnNovo.Enabled = true;
                btnPesquisar.Enabled = true;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = false;
                pnlDados.Enabled = false;
            }
            //Novo
            if (op == 2)
            {
                btnSalvar.Enabled = true;
                btnExcluir.Enabled = false;
                btnCancelar.Enabled = true;
                pnlDados.Enabled = true;
            }
            //Pesquisar / Editar
            if (op == 3)
            {
                btnNovo.Enabled = false;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = true;
                pnlDados.Enabled = true;
            }
        }


        private void ModelFrom_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
        }

        private void ModelFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void pnlDireita_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
