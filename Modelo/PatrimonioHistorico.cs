using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("patrimonio_historico")]
    public class PatrimonioHistorico
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public virtual Patrimonio Patrimonio { get; set; }
        public string Historico { get; set; }
        public double Valor { get; set; }
    }
}
