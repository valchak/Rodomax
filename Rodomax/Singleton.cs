
using Modelo;

namespace Ferramenta
{
    public class Singleton
    {
        private static Singleton instance;

        public static string hash = "f12456ekliukhjmfgf51d5";

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
        public Funcionario funcionario = null;
        public Usuario usuario = null;
        public Usuario userLogado = null;




        public Formatacao formatacao = new Formatacao();

    }
}