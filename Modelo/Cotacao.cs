using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace Modelo
{
    [Table("cotacao")]
    public class Cotacao
    {
        public int Id { get; set; }
        public DateTime DataCotacao { get; set; }
        public Funcionario FuncionarioSolicitante { get; set; }

        public virtual ICollection<CotacaoFornecedor> CotacaoFornedores { get; set; }
        public virtual ICollection<CotacaoProduto> CotacaoProdutos { get; set; }
        public virtual ICollection<CotacaoValor> CotacaoValores { get; set; }

    }
}
