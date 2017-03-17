using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class MaloteDetalhe
    {
        public int Id { get; set; }
        public MaterialSaida MaterialSaida { get; set; }
        public int QuantidadeVolume { get; set; }
        [StringLength(255)]
        public string Descricao { get; set; }
    }
}
