using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("ordem_compra_detalhe")]
    public class OrdemCompraDetalhes
    {
        public int Id { get; set; }
        public OrdemCompra OrdemCompra { get; set; }
        public Produto Produto { get; set; }
        public ProdutoTipo ProdutoTipo { get; set; }
        [StringLength(255)]
        public string Descricao { get; set; }
        public double Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public double AcresDesc { get; set; }
        public double ValorTotal { get; set; }
        
    }
}
