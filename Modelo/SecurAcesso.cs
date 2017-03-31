using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("secur_acesso")]
    public class SecurAcesso
    {

        [Column(Order = 0), Key, ForeignKey("Perfil")]
        public int SecurPerfilId { get; set; }
        public virtual SecurPerfil Perfil { get; set; }
        [Column(Order = 1), Key, ForeignKey("Formulario")]
        public int SecurFormId { get; set; }
        public virtual SecurForm Formulario { get; set; }
    }
}
