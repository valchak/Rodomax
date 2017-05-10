using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("despesa")]
    public class Despesa
    {
        public int Id { get; set; }
        public Fornecedor Fornecedor { get; set; }
        [StringLength(255)]
        public string Documento { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; }
        [StringLength(10)]
        public string DataReferencia { get; set; }
        public TelefoneCobranca TelefoneCobranca { get; set; }
        public double ValorTitulo { get; set; }
        public double ValorTotal { get; set; }

        public virtual ICollection<DespesaDetalhes> DespesaDetalhes { get; set; }

        [NotMapped]
        public List<DespesaDetalhes> listaExcluir { get; set; }
    }
}
