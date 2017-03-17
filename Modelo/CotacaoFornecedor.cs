using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("cotacao_fornecedor")]
    public class CotacaoFornecedor
    {
        public int Id { get; set; }
        public Cotacao Cotacao { get; set; }
        public Fornecedor Fornecedor { get; set; }

        [StringLength(255)]
        public string Vendedor { get; set; }

        public FormaPagamento FormaPagamento { get; set; }

        [StringLength(1)]
        public string EmiteNotaFiscal { get; set; }
        

    }
}
