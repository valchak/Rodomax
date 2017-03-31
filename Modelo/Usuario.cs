using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("usuario")]
    public class Usuario
    {
        public int Id { get; set; }
        public Funcionario Funcionario { get; set; }

        [StringLength(255)]
        public string Login { get; set; }
        [StringLength(255)]
        public string Senha { get; set; }
        [StringLength(1)]
        public string Situacao { get; set; }

        public virtual SecurPerfil Perfil {get;set;}

        public virtual ICollection<UsuarioFilial> ListaUsuarioFilial { get; set; }

        [NotMapped]
        public List<Filial> ListaExcluir { get; set; }
        [NotMapped]
        public List<Filial> ListaInserir { get; set; }
    }
}
