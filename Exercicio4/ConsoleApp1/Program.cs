using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeFuncionario;
            double salarioFixo, vendasTotal , comissao ,salarioFinal;

            Console.WriteLine("Qual o nome do vendedor(a)? ");
            nomeFuncionario = Console.ReadLine();

            Console.WriteLine("Qual o Salario fixo do(a) " + nomeFuncionario + "?");
            salarioFixo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual o valor de vendas Total do(a) " + nomeFuncionario + "?");
            vendasTotal = Convert.ToDouble(Console.ReadLine());

            comissao = vendasTotal * 0.15;
            salarioFinal = salarioFixo + comissao;

            Console.WriteLine(" Vendedor(a) " + nomeFuncionario + " recebe R$" + salarioFixo + " de salario fixo.");
            Console.WriteLine(" Vendedor(a) " + nomeFuncionario + " recebeu R$" + salarioFinal + " de salario esse mês.");




        }
    }
}
