using System;
using System.Collections.Generic;
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
        public String NomeFormulario { get; set; }

        public virtual ICollection<SecurAcesso> Acessos { get; set; }
    }
}
