
using Modelo;

namespace Ferramenta
{
    public class Singleton
    {
        private static Singleton instance;

        private Singleton()
        {
        }

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        public Cidade cidade = null;
        public Filial filial = null;
        public Fornecedor fornecedor = null;
        public CentroCusto centroCusto = null;
        public Produto produto = null;
        public ProdutoGrupo produtoGrupo = null;
        public ProdutoGrupoUsuario produtoGrupoUsuario = null;
        public Estoque estoque = null;



        public Formatacao formatacao = new Formatacao();

    }
}