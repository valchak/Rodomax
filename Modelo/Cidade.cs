using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("cidade")]
    public class Cidade
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Nome { get; set; }
        
    }
}
