using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Reports
{
    public class DadosProtocoloMaterial
    {
        public int Id { get; set; }
        public string FuncionarioRecebimento { get; set; }
        public string CargoFuncao { get; set; }
        public string FuncionarioEnvio { get; set; }
        public string TipoProduto { get; set; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public string FilialDestino { get; set; }
        public string FilialOrigem { get; set; }
        public DateTime DataEnvio { get; set; }
        public DateTime DataRecebimento { get; set; }

    }
}
