using System;
using System.Collections.Generic;
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
        public String Descricao { get; set; }

        public virtual ICollection<SecurAcesso> Acessos { get; set; }

    }
}
