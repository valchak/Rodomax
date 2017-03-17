using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("produto_grupo_usuario")]
    public class ProdutoGrupoUsuario
    {
        [Column(Order = 0), Key, ForeignKey("ProdutoGrupo")]
        public int ProdutoGrupo_Id { get; set; }
        [Column(Order = 1), Key, ForeignKey("Usuario")]
        public int Usuario_Id { get; set; }

        public virtual ProdutoGrupo ProdutoGrupo { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
