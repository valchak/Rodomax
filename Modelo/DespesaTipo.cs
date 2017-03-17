using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("despesa_tipo")]
    public class DespesaTipo
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Descircao { get; set; }
    }
}
