using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("produto")]
    public class Produto
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Nome { get; set; }

        public ProdutoGrupo ProdutoGrupo { get; set; }


        public double CustoMedio { get; set; }
        public int Multiplicador { get; set; }
        [StringLength(1)]
        public string EstoqueFilial { get; set; }
        [StringLength(1)]
        public string EstoqueUsado { get; set; }
        [StringLength(1)]
        public string Situacao { get; set; }
        public string Observacao { get; set; }

        public Fornecedor UltimoFornecedor { get; set; }
        public double UltimoValorCompra { get; set; }

        public DateTime UltimaDataCompra { get; set; }
        [StringLength(50)]
        public string UltimaNotaCompra { get; set; }


    }
}
