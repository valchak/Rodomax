using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("forma_pagamento")]
    public class FormaPagamento
    {
        public int Id { get; set; }
        [StringLength(250)]
        public string Descricao { get; set; }

    }
}
