using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("nota_entrada")]
    public class NotaEntrada
    {
        public int Id { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }
        public virtual OrdemCompra OrdemCompra { get; set; }

        [StringLength(100)]
        public string Documento { get; set; }
        [StringLength(10)]
        public string Serie { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataRecebimento { get; set; }
        public double ValorDocumento { get; set; }
        public double AcresDesc { get; set; }
        public double ValorDocumentoTotal { get; set; }
        [StringLength(1)]
        public string Faturado { get; set; }

        public virtual ICollection<NotaEntradaItens> NotaEntradaItens { get; set; }
        
        [NotMapped]
        public List<NotaEntradaItens> listaExcluir { get; set; }

    }
}
