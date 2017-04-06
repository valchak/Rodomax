using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("nota_entrada_itens")]
    public class NotaEntradaItens
    {
        public int Id { get; set; }

        public int NotaEntradaId { get; set; }
        public virtual NotaEntrada NotaEntrada { get; set; }
        public int FilialId { get; set; }
        public virtual Filial Filial { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual EstoqueMovimento EstoqueMovimento { get; set; }
        [StringLength(1)]
        public string TipoProduto { get; set; }
        [StringLength(255)]
        public string Descricao { get; set; }
        public int QuantidadeNota { get; set; }
        public int Multiplicador { get; set; }
        public double ValorUnitario { get; set; }
        public double ValorTotal { get; set; }
        public int QuantidadeEstoque { get; set; }
        public double ValorUnitarioEstoque { get; set; }
        

    }
}
