using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("empresa")]
    public class Empresa
    {
        public int Id { get; set; }
        [StringLength(250)]
        public string Nome { get; set; }

    }
}
