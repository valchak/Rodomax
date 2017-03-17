using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("malote")]
    public class Malote
    {
        public int Id { get; set; }
        public DateTime DataEnvio { get; set; }
        public DateTime DataRecebimento { get; set; }
        public Filial FilialOrigem { get; set; }
        public Filial FilialDestino { get; set; }
        public Fornecedor Transportadora { get; set; }
        public string Observacao { get; set; }

        public virtual ICollection<MaloteDetalhe> MaloteDetalhe { get; set; }
    }
}
