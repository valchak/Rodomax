using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("produto_grupo")]
    public class ProdutoGrupo
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Nome { get; set; }

        public virtual ICollection<ProdutoGrupoUsuario> UsuariosGrupo { get; set; }
        
    }
}
