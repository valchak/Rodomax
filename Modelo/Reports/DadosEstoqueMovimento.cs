using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Reports
{
    public class DadosEstoqueMovimento
    {
        public int Id { get; set; }
        public DateTime DataMovimento { get; set; }
        public int ProdutoId { get; set; }
        public string ProdutoNome { get; set; }
        public int FilialId { get; set; }
        public string FilialNome { get; set; }
        public double ValorUnitario { get; set; }
        public double ValorTotal { get; set; }
        public int QtdeEntrada { get; set; }
        public int QtdeSaida { get; set; }
        public string Tipo { get; set; }
        public int QuantidadeEstoque { get; set; }
    }
}
