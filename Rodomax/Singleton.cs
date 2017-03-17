
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
      



        public Formatacao formatacao = new Formatacao();

    }
}