using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("telefone_cobranca")]
    public class TelefoneCobranca
    {
     
        public int Id { get; set; }
        public Filial FilialFatura { get; set; }
        public Fornecedor Fornecedor { get; set; }

        [StringLength(255)]
        public string LinhaCobranca { get; set; }
        [StringLength(18)]
        public string Cnpj { get; set; }
        public int DiaVencimento { get; set; }
        [StringLength(1)]
        public string Situacao { get; set; }

        public string Observacao { get; set; }


        public virtual ICollection<TelefoneLinha> LinhasTelefone { get; set; }

        [NotMapped]
        public List<TelefoneLinha> listaExcluir { get; set; }
    }
}
