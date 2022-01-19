using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Uteis
    {
        internal static bool ObtemBoleano()
        {
            while (true)
            {
                var strValor = Console.ReadLine();

                if (strValor.ToUpper().StartsWith("S"))
                {
                    return true;
                }
                else if(strValor.ToUpper().StartsWith("N"))
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Valor inválido, digite S(Sim) ou N(Não).");
                    continue;
                }
            }
        }

        internal static double ObtemDecimal()
        {
            double valor;
            while (true)
            {
                var strValor = Console.ReadLine();

                if (!double.TryParse(strValor.Replace(".", ","), out valor))
                {
                    Console.WriteLine("Valor inválido, digite um valor decimal.");
                    continue;
                }
                else
                {
                    break;
                }
            }

            return valor;
        }

        internal static int ObtemInteiro()
        {
            int valor;
            while (true)
            {
                var strValor = Console.ReadLine();

                if (!int.TryParse(strValor.Replace(",", "."), out valor))
                {
                    Console.WriteLine("Valor inválido, digite um valor do tipo inteiro.");
                    continue;
                }
                else
                {
                    break;
                }
            }

            return valor;
        }
    }
}
