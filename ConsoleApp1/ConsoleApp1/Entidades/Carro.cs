using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Carro
    {
        public string Nome { get; set; }

        public double Valor { get; set; }

        public int Ano { get; set; }

        public Carro(string nome, double valor, int ano)
        {
            this.Nome = nome;
            this.Valor = valor;
            this.Ano = ano;
        }
    }
}
