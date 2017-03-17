using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("cotacao_valores")]
    public class CotacaoValor
    {
        
        [Column(Order = 0), Key, ForeignKey("Cotacao")]
        public int Cotacao_Id { get; set; }
        [Column(Order = 1), Key, ForeignKey("CotacaoFornecedor")]
        public int CotacaoFornecedor_Id { get; set; }
        [Column(Order = 2), Key, ForeignKey("CotacaoProduto")]
        public int CotacaoProduto_Id { get; set; }

        public double ValorUnitario { get; set; }
        [StringLength(1)]
        public string Situacao { get; set; }
        
        public virtual Cotacao Cotacao { get; set; }
        public virtual CotacaoFornecedor CotacaoFornecedor { get; set; }
        public virtual CotacaoProduto CotacaoProduto { get; set; }

    }
}
