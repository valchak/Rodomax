using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("cotacao_produto")]
    public class CotacaoProduto
    {

        public int Id { get; set; }
        public Cotacao Cotacao { get; set; }
        public Produto Produto { get; set; }
        [StringLength(255)]
        public string Descricao { get; set; }
        public double Quantidade { get; set; }
        public ProdutoTipo ProdutoTipo { get; set; }

    }
}
