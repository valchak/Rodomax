using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("material_saida")]
    public class MaterialSaida
    {
        public int Id { get; set; }
        public Filial FilialSaida { get; set; }
        public Filial FilialEntrada { get; set; }
        public DateTime DataSaidaEstoque { get; set; }
        public DateTime DataEntradaEstoque { get; set; }
        public Funcionario ResponsavelRecebimento { get; set; }
        public string Observacao { get; set; }

        public virtual ICollection<MaterialSaidaProdutos> MaterialSaidaProdutos { get; set; }
    }
}
