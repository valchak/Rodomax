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
            NotaEntradaItens item2 = new NotaEntradaItens();

            FornecedorApp form = new FornecedorApp();
            nota.Id = 8;
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
            item.Id = 9;
            item.Produto = prod.Find(1);
            item.Filial = fil.Find(1);
            item.ValorTotal = 123;
            item.ValorUnitario = 361;
            item.ValorUnitarioEstoque = 566;
            item.Multiplicador = 2;
            item.QuantidadeEstoque = 15;
            item.QuantidadeNota = 1;
            item.NotaEntrada = nota;

            item2.Id = 8;
            item2.Produto = null;
            item2.Filial = fil.Find(1);
            item2.ValorTotal = 1111;
            item2.Descricao = "Serviço Novo";
            item2.ValorUnitario = 1112;
            item2.ValorUnitarioEstoque = 1111;
            item2.Multiplicador = 2;
            item2.QuantidadeEstoque = 333;
            item2.QuantidadeNota = 444;
            item2.NotaEntrada = nota;


            List<NotaEntradaItens> list = new List<NotaEntradaItens>();
            List<NotaEntradaItens> excluir = new List<NotaEntradaItens>();
            excluir.Add(item);
            list.Add(item2);
            nota.NotaEntradaItens = list;
            nota.listaExcluir = excluir;
            
            app.Atualizar(nota);
            //app.Excluir(x=> x.Id == nota.Id);




            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmNotaEntrada());
            */
        }
    }
}
