using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Aplicacao;
using Modelo;
using UI;
using Repositorio;

namespace Rodomax
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           ContextoDB Banco = new ContextoDB();

            NotaEntradaApp app= new NotaEntradaApp();
            NotaEntrada nota = new NotaEntrada();
            NotaEntradaItens item = new NotaEntradaItens();

            FornecedorApp form = new FornecedorApp();
            nota.Id = 3;
            nota.Fornecedor = form.Find(1);
            nota.Documento = "1";
            nota.Serie = "1";
            nota.DataEmissao = DateTime.Now;
            nota.DataRecebimento = DateTime.Now;
            nota.ValorDocumento = 133;
            nota.ValorDocumentoTotal = 165;
            
            FilialApp fil = new FilialApp();
            ProdutoApp prod = new ProdutoApp();
            NotaEntradaItemApp iApp = new NotaEntradaItemApp();
            item.Id = 2;
            item.Produto = prod.Find(6);
            item.Filial = fil.Find(4);
            item.ValorTotal = 123;
            item.ValorUnitario = 361;
            item.ValorUnitarioEstoque = 566;
            item.Multiplicador = 2;
            item.QuantidadeEstoque = 5005;
            item.QuantidadeNota = 1;
            item.NotaEntrada = nota;

            List<NotaEntradaItens> list = new List<NotaEntradaItens>();
            list.Add(item);
            nota.NotaEntradaItens = list;
            
            app.Atualizar(nota);




            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmNotaEntrada());
            */
        }
    }
}
