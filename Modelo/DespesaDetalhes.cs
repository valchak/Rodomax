using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("despesa_detalhe")]
    public class DespesaDetalhes
    {
        public int Id { get; set; }
        public Despesa Despesa { get; set; }
        public DespesaTipo DespesaTipo { get; set; }
        public Filial Filial { get; set; }
        public TelefoneLinha TelefoneLinha { get; set; }
        public Funcionario Funcionario { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public double ValorTotal { get; set; }
        [StringLength(1)]
        public string Rateio { get; set; }
        public string Observacao { get; set; }
        [StringLength(1)]
        public string OutraOperadora { get; set; }
    }
}