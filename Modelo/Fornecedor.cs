using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("fornecedor")]
    public class Fornecedor
    {
        public int Id { get; set; }
        public Cidade Cidade { get; set; }
        [StringLength(255)]
        public string RazaoSocial { get; set; }
        [StringLength(255)]
        public string NomeFantasia { get; set; }
        [StringLength(255)]
        public string CnpjCpf { get; set; }
        [StringLength(20)]
        public string Ie { get; set; }
        [StringLength(255)]
        public string Endereco { get; set; }
        [StringLength(255)]
        public string Bairro { get; set; }
        [StringLength(10)]
        public string Cep { get; set; }
        [StringLength(255)]
        public string Contato { get; set; }
        [StringLength(255)]
        public string Telefone { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        public string Observacao { get; set; }

        
    }
}
