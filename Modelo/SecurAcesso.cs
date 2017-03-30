using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Table("secur_acesso")]
    public class SecurAcesso
    {
        public virtual SecurPerfil Perfil { get; set; }
        public virtual SecurForm Formulario { get; set; }
    }
}
