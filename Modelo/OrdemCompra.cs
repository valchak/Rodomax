using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("ordem_compra")]
    public class OrdemCompra
    {
        public int Id { get; set; }
        public DateTime DataOrdem { get; set; }

        public int Cotacao { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Funcionario FuncionarioSolicitante { get; set; }
        public Funcionario FuncionarioAutorizacao { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        public virtual ICollection<OrdemCompraDetalhes> OrdemCompraDetalhes { get; set; }
    }
}
