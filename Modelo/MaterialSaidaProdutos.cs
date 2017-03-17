using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("material_saida_produtos")]
    public class MaterialSaidaProdutos
    {
        public int Id { get; set; }
        public MaterialSaida MaterialSaida { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public CentroCusto CentroCusto { get; set; }
    }
}
