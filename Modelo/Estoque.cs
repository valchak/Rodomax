using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("estoque")]
    public class Estoque
    {
        [Column(Order = 0), Key, ForeignKey("Filial")]
        public int Filial_Id { get; set; }
        [Column(Order = 1), Key, ForeignKey("Produto")]
        public int Produto_Id { get; set; }

        public virtual Filial Filial { get; set; }
        public virtual Produto Produto { get; set; }

        public int QuantidadeNovo { get; set; }
        public int QuantidadeUsado { get; set; }
    }
}
