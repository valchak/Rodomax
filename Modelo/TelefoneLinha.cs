using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("telefone_linha")]
    public class TelefoneLinha
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Linha { get; set; }
        public TelefoneCobranca TelefoneCobranca { get; set; }
        public Funcionario Funcionario { get; set; }
        public Filial Filial { get; set; }
        [StringLength(1)]
        public string Situacao { get; set; }
        public string Observacao { get; set; }

    }
}
