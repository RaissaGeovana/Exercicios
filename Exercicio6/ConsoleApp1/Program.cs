using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor da variavel A:");
            string a = Console.ReadLine();
            Console.WriteLine("Valor da variavel B:");
            string b = Console.ReadLine();

            string c = string.Empty;

            c = a;
            a = b;
            b = c;

            Console.WriteLine($"Valor da variavel A: {a}");
            Console.WriteLine($"Valor da variavel B: {b}");
            Console.ReadKey();

        }
    }
}
