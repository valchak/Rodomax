using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("estoque_movimento")]
    public class EstoqueMovimento
    {
        public int Id { get; set; }
        public Filial Filial { get; set; }
        public Produto Produto { get; set; }
        public DateTime DataMovimento { get; set; }
        public int QuantidadeNovo { get; set; }
        public int QuantidadeUsado { get; set; }
        public double ValorUnitario { get; set; }
        [StringLength(1)]
        public string TipoMovimento { get; set; }
        public string ObservacaoHistorico { get; set; }
//[StringLength(255)]
                
        public virtual MaterialSaidaProdutos MaterialSaida { get; set; }

    }
}
