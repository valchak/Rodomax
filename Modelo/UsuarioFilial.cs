using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("usuario_filial")]
    public class UsuarioFilial
    {
        [Column(Order = 0), Key, ForeignKey("Filial")]
        public int Filial_Id { get; set; }
        [Column(Order = 1), Key, ForeignKey("Usuario")]
        public int Usuario_Id { get; set; }

        public virtual Filial Filial { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
