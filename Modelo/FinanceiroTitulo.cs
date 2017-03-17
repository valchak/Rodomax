using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("financeiro_titulo")]
    public class FinanceiroTitulo
    {
        [Column(Order = 0), Key, ForeignKey("Fornecedor")]
        public int Fornecedor_Id { get; set; }
        [Column(Order = 1), Key]
        [StringLength(150)]
        public string Documento { get; set; }
        [Column(Order = 2), Key]
        public int Parcela { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; }
        public double Valor { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }
    }
}
