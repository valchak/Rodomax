using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("toner_manutencao")]
    public class TonerManutencao
    {
        public int Id { get; set; }
        public Estoque Estoque { get; set; }
        public Produto Produto { get; set; }
        public DateTime DataEnvio { get; set; }
        public DateTime DataRetorno { get; set; }
        public int QuantidadeEnviada { get; set; }
        public double ValorUnitarioEnvio { get; set; }
        public int QuantidadeRetorno { get; set; }
        public double ValorUnitarioRetorno { get; set; }
        public string Observacao { get; set; }

    }
}
