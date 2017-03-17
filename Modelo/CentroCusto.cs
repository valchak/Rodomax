using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("centro_de_custo")]
    public class CentroCusto
    {
        public int Id { get; set; }
        [StringLength(250)]
        public string Nome { get; set; }
        [StringLength(1)]
        public string Situacao { get; set; }
        public virtual ICollection<Filial> Filiais { get; set; }
    }
}
