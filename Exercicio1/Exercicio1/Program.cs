using System;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número da soma:");
            decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o segundo número da soma:");
            decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

            decimal soma = primeiroNumero + segundoNumero;

            Console.WriteLine("A soma dos dois números é igual = " + soma);

        }
    }
}
