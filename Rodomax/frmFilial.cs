﻿using Aplicacao;
using Modelo;
using System;
using System.Windows.Forms;
using MMLib.Extensions;
using Rodomax;

namespace UI
{
    public partial class frmFilial : UI.ModelForm
    {
        _Singleton instancia = _Singleton.GetInstance;
        private FilialApp app;

        private Filial filial;
        private Cidade cidade;
       
        public frmFilial()
        {
            InitializeComponent();
            populaEmpresa();
            limparCampos();
        }
        private void populaEmpresa()
        {
            EmpresaApp empApp = new EmpresaApp();
            foreach (var emp in empApp.GetAll())
            {
                cbEmpresa.Items.Add(emp.Nome);
            }
            cbEmpresa.SelectedIndex = 0;
        }

        private void limparCampos()
        {
            txtId.Clear();
            txtCep.Clear();
            txtComplemento.Clear();
            txtCidade.Clear();
            txtEndereco.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtBairro.Clear();
            txtEmail.Clear();

            cidade = null;
            cbEmpresa.SelectedIndex = 0;
            this.AlteraBotoes(1);
            this.operacao = "";

            filial = new Filial();
            app = new FilialApp();

        }


        private void btnBuscarCidade_Click(object sender, EventArgs e)
        {
            frmCidadePesquisa tela = new frmCidadePesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.cidade != null)
            {
                cidade = instancia.cidade;
                instancia.cidade = null;
                txtCidade.Text = cidade.Nome;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "NOVO";
            this.AlteraBotoes(2);
            txtNome.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmFilialPesquisa tela = new frmFilialPesquisa();
            tela.ShowDialog();
            tela.Dispose();

            if (instancia.filial != null)
            {
                filial = instancia.filial;
                instancia.filial = null;
                cidade = filial.Cidade;
                txtId.Text = Convert.ToString(filial.Id);
                txtNome.Text = filial.Nome;
                txtCep.Text = filial.Cep;
                txtCidade.Text = cidade.Nome;
                txtComplemento.Text = filial.Complemento;
                txtEndereco.Text = filial.Endereco;
                txtBairro.Text = filial.Bairro;
                txtEmail.Text = filial.Email;
                txtTelefone.Text = filial.Telefone;

                cbEmpresa.SelectedItem = filial.Empresa.Nome;
                
                this.AlteraBotoes(3);
                this.operacao = "ALTERAR";
                

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpresaApp empApp = new EmpresaApp();
                filial.Nome = txtNome.Text.Trim().RemoveDiacritics().ToUpper();
                filial.Cep = txtCep.Text.Trim().RemoveDiacritics().ToUpper();
                filial.Bairro = txtBairro.Text.Trim().RemoveDiacritics().ToUpper();
                filial.Cidade = cidade;
                filial.Complemento = txtComplemento.Text.Trim().RemoveDiacritics().ToUpper();
                filial.Endereco = txtEndereco.Text.Trim().RemoveDiacritics().ToUpper();
                filial.Email = txtEmail.Text.Trim().RemoveDiacritics();
                filial.Telefone = txtTelefone.Text.Trim();
                filial.FilialCentroCustos = null;
                if (cbEmpresa.Text.Equals("RODOMAX"))
                {
                    filial.Empresa = empApp.Find(1);
                }
                else
                {
                    filial.Empresa = empApp.Find(2);
                }

                filial.Cidade = cidade;
                if (this.operacao.Equals("NOVO"))
                {
                    app.Adicionar(filial);
                    MessageBox.Show("Cadastro efetuado com sucesso: Código " + filial.Id);
                }
                else
                {
                    app.Atualizar(filial);
                    MessageBox.Show("Cadastro" + filial.Id + " alterado com sucesso.");
                }
                this.limparCampos();
                 
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro Salvar: " + erro.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.limparCampos();
            this.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                if (filial != null)
                {
                    app.Excluir(x => x.Id == filial.Id);
                    MessageBox.Show("Cadastro " + filial.Id + " excluido com sucesso.");
                    this.limparCampos();
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Excluir: " + erro.Message);
            }
        }

        private void frmFilial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
