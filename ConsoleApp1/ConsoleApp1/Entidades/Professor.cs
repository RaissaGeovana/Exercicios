using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entidades
{
    enum Nivel
    {
        Nivel1,
        Nivel2,
        Nivel3
    }

    internal class Professor
    {
        public string Nome { get; set; }

        public int HorasTrabalhadas { get; set; }
        
        public Nivel Nivel { get; set; }

        public Professor(string nome, int horasTrabalhadas, Nivel nivel)
        {
            this.Nome = nome;
            this.HorasTrabalhadas = horasTrabalhadas;
            this.Nivel = nivel;
        }
    }
}
