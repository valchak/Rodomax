using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("produto_tipo")]
    public class ProdutoTipo
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Descricao { get; set; }
    }
}
