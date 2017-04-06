using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("material_saida_produtos")]
    public class MaterialSaidaProdutos
    {
        public int Id { get; set; }
        public MaterialSaida MaterialSaida { get; set; }
        public Produto Produto { get; set; }
        [StringLength(1)]
        public string TipoProduto { get; set; }
        public int Quantidade { get; set; }
        public double CustoUnitario { get; set; }
        public virtual CentroCusto CentroCusto { get; set; }
    }
}
