using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Table("secur_perfil")]
    public class SecurPerfil
    {
        public int Id { get; set; }
        [StringLength(255)]
        public String Descricao { get; set; }

        public virtual ICollection<SecurForm> Formulario { get; set; }

    }
}
