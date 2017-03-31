using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Table("secur_form")]
    public class SecurForm
    {
        public int Id { get; set; }
        [StringLength(255)]
        public String NomeFormulario { get; set; }

        public virtual ICollection<SecurPerfil> SecurPerfil { get; set; }

    }
}
