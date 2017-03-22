using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("filial")]
    public class Filial
    {
        public int Id { get; set; }
        public Empresa Empresa { get; set; }
        public Cidade Cidade { get; set; }
        [StringLength(255)]
        public string Nome { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string Endereco { get; set; }
        [StringLength(255)]
        public string Bairro { get; set; }
        [StringLength(10)]
        public string Cep { get; set; }
        [StringLength(255)]
        public string Complemento { get; set; }
        [StringLength(255)]
        public string Telefone { get; set; }

        public virtual ICollection<FilialCentroCusto> FilialCentroCustos { get; set; }
    }
}
