using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("patrimonio")]
    public class Patrimonio
    {
        public int Id { get; set; }
        public PatrimonioGrupo PatrimonioGrupo { get; set; }
        [StringLength(50)]
        public string PatrimonioNumero { get; set; }
        [StringLength(255)]
        public string Descricao { get; set; }
        [StringLength(255)]
        public string NumeroSerie { get; set; }
        public virtual Filial Filial { get; set; }
        public virtual CentroCusto CentroCusto { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public DateTime DataAquisicao { get; set; }
        public double ValorAquisicao { get; set; }
        [StringLength(1)]
        public string Situacao { get; set; }
        public string Observacao { get; set; }

        public virtual ICollection<PatrimonioHistorico> ListaHistorico { get; set; }

    }
}
