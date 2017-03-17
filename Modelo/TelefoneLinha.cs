using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("telefone_linha")]
    public class TelefoneLinha
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [StringLength(255)]
        public string Linha { get; set; }
        public TelefoneCobranca TelefoneCobranca { get; set; }
        public Funcionario Funcionario { get; set; }
        public Filial Filial { get; set; }
        [StringLength(1)]
        public string Situacao { get; set; }

    }
}
