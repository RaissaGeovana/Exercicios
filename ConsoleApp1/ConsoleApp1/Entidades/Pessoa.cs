using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entidades
{
    internal class Pessoa
    {
        public string Nome { get; set; }

        public string Sexo { get; set; }

        public int Idade { get; set; }

        public bool Saudavel { get; set; }

        public bool AptoServicoMilitar { get; set; }

        public Pessoa(string nome, string sexo, int idade, bool saudavel)
        {
            this.Nome = nome;
            this.Sexo = sexo.ToUpper().FirstOrDefault().ToString();
            this.Idade = idade;
            this.Saudavel = saudavel;
            this.AptoServicoMilitar = this.Idade >= 18 && saudavel && sexo == "M";
        }
    }
}
