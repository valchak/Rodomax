using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("filial_centro_custo")]
    public class FilialCentroCusto
    {
        [Column(Order = 0), Key, ForeignKey("Filial")]
        public int Filial_Id { get; set; }
        [Column(Order = 1), Key, ForeignKey("CentroCusto")]
        public int CentroCusto_Id { get; set; }

        public virtual Filial Filial { get; set; }
        public virtual CentroCusto CentroCusto { get; set; }


    }
}
