using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("nota_entrada_itens")]
    public class NotaEntradaItens
    {
        public int Id { get; set; }

        public NotaEntrada NotaEntrada { get; set; }
        public Produto Produto { get; set; }
        public Filial FilialEstoque { get; set; }

        [StringLength(255)]
        public string Descricao { get; set; }
        public int QuantidadeNota { get; set; }
        public int Multiplicador { get; set; }
        public double ValorUnitario { get; set; }
        public double ValorTotal { get; set; }
        public int QuantidadeEstoque { get; set; }
        public double ValorUnitarioEstoque { get; set; }

        public EstoqueMovimento EstoqueMovimento { get; set; }

        //        [NotMapped]

    }
}
