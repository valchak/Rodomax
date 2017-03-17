using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("financeiro_pendencia")]
    public class FinanceiroPendencia
    {
        public int Id { get; set; }
        public NotaEntrada NotaEntrada { get; set; }
        public Despesa Despesa { get; set; }
        public DateTime DataDocumento { get; set; }
        public double Valor { get; set; }
        public FinanceiroTitulo Titulo { get; set; }
    }
}
