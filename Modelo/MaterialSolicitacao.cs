using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("material_solicitacao")]
    public class MaterialSolicitacao
    {
        public int Id { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public Filial Filial { get; set; }
        public Funcionario Funcionario { get; set; }
        public Produto Produto { get; set; }
        [StringLength(255)]
        public string Descricao { get; set; }
        public string Quantidade { get; set; }
        [StringLength(1)]
        public string Situacao { get; set; }
        public MaterialSaida MaterialSaida { get; set; }
    }
}
