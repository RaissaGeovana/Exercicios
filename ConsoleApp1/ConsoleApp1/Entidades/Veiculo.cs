using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entidades
{
    public class Veiculo
    {
        public string NomeVeiculo { get; set; }
        /// <summary>
        /// O valor original do veículo sem desconto
        /// </summary>
        public decimal ValorVeiculo { get; set; }
        /// <summary>
        /// Determina o tipo de combustivel, 1 - Alcool, 2 - Gasolina, 3 - Diesel
        /// </summary>
        public short TipoCombustivel { get; set; }
        /// <summary>
        /// O valor original do veículo com desconto aplicado
        /// </summary>
        public decimal ValorFinal { get; set; }
        /// <summary>
        /// O valor em R$ do desconto
        /// </summary>
        public decimal ValorDesconto { get; set; }
    }
}
