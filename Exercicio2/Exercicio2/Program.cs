using System;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos fazer algumas operações:");

            Console.WriteLine("Digite o primeiro número :");
            decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o segundo número :");
            decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

            decimal adicao = primeiroNumero + segundoNumero;
            decimal subtracao = primeiroNumero - segundoNumero;
            decimal multiplicacao = primeiroNumero * segundoNumero;
            decimal divisao = primeiroNumero / segundoNumero;

            Console.WriteLine("A soma dos dois números é igual = " + adicao);
            Console.WriteLine("A subtração dos dois números é igual = " + subtracao);
            Console.WriteLine("A multiplcação dos dois números é igual = " + multiplicacao);
            Console.WriteLine("A divisão dos dois números é igual = " + divisao);
        }
    }
}
