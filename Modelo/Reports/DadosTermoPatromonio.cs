using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Reports
{
    public class DadosTermoPatromonio
    {
        public int Id { get; set; }
        public string Patrimonio { get; set; }
        public DateTime DataProtocolo { get; set; }
        public DateTime DataVistoria { get; set; }

        public string AreaResponsavel { get; set; }
        public string Tipo { get; set; }
        public string MarcaModelo { get; set; }
        public string Empresa { get; set; }
        public string SereiImei { get; set; }
        public Double ValorPatrimonio { get; set; }

        public string Observacao { get; set; }
        public string FuncionarioUtilizador { get; set; }
        public string FuncionarioMatriz { get; set; }
        public string CargoFuncaoUtilizador { get; set; }
        public string CargoFuncaoMatriz { get; set; }
    }
}
