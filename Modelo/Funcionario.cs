using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("funcionario")]
    public class Funcionario
    {
        public int Id { get; set; }
        public Filial Filial { get; set; }
        [StringLength(255)]
        public string CPF { get; set; }
        [StringLength(255)]
        public string Funcao { get; set; }
        [StringLength(255)]
        public string Nome { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(1)]
        public string Situacao { get; set; }
    }
}
