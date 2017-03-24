using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("material_saida")]
    public class MaterialSaida
    {
        public int Id { get; set; }
        public virtual Filial FilialSaida { get; set; }
        public virtual Filial FilialEntrada { get; set; }
        public DateTime DataSaidaEstoque { get; set; }
        public DateTime DataEntradaEstoque { get; set; }
        public virtual Funcionario ResponsavelRecebimento { get; set; }
        public virtual MaterialSolicitacao Solicitacao { get; set; }
        public string Observacao { get; set; }

        public virtual ICollection<MaterialSaidaProdutos> MaterialSaidaProdutos { get; set; }

        [NotMapped]
        public List<MaterialSaidaProdutos> listaExcluir { get; set; }
    }
}
