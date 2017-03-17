﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("patrimo_grupo")]
    public class PatrimonioGrupo
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Descricao { get; set; }
    }
}
