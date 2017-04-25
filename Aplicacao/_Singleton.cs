using Modelo;
using Modelo.Reports;
using System.Collections.Generic;

namespace Aplicacao
{
    public class _Singleton
    {
        private static _Singleton instance;


        private _Singleton()
        {
        }

        public static _Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new _Singleton();
                }
                return instance;
            }
        }

        /* Funções usadas para o secur do sistema */
        public Usuario userLogado = null;
        public IEnumerable<UsuarioFilial> userFiliais = null;
        /* Funções usadas para o secur do sistema */



        public Cidade cidade = null;
        public Filial filial = null;
        public Fornecedor fornecedor = null;
        public CentroCusto centroCusto = null;
        public Produto produto = null;
        public ProdutoGrupo produtoGrupo = null;
        public ProdutoGrupoUsuario produtoGrupoUsuario = null;
        public PatrimonioGrupo patrimonioGrupo = null;
        public Patrimonio patrimonio = null;
        public Estoque estoque = null;
        public Funcionario funcionario = null;
        public Usuario usuario = null;


        /*Para relatório*/
        public List<DadosProtocoloMaterial> listaProtocoloMaterial = null;
        


    }
    
}