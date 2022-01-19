using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class VendasCarango
    {
        public static void ContabilizarVendas()
        {
            var listaVeiculos = new List<Entidades.Veiculo>();

            while (true)
            {
                var veiculo = FazerPerguntas();

                if (veiculo == null)
                    break;

                veiculo = RealizarCalculos(veiculo);
                listaVeiculos.Add(veiculo);
            }

            ExibirResultados(listaVeiculos);
        }

        private static Entidades.Veiculo FazerPerguntas()
        {
            var veiculo = new Entidades.Veiculo();

            Console.WriteLine("Qual o valor do carro?");
            Console.WriteLine("Ou digite 0 para cancelar!");
            veiculo.ValorVeiculo = Convert.ToDecimal(Console.ReadLine());

            if (veiculo.ValorVeiculo == 0)
                return null;

            Console.WriteLine("Qual o combustivel do carro?");
            Console.WriteLine("1 para Alcool");
            Console.WriteLine("2 para Gasolina");
            Console.WriteLine("3 para Diesel");
            veiculo.TipoCombustivel = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Qual o modelo do veículo?");
            veiculo.NomeVeiculo = Console.ReadLine();

            Console.Clear();
            return veiculo;
        }

        private static Entidades.Veiculo RealizarCalculos(Entidades.Veiculo veiculo)
        {
            decimal porcentagemDesconto = 0M;

            switch (veiculo.TipoCombustivel)
            {
                case 1:
                    porcentagemDesconto = 0.25M;
                    break;
                case 2:
                    porcentagemDesconto = 0.21M;
                    break;
                case 3:
                    porcentagemDesconto = 0.14M;
                    break;
                default:
                    break;
            }

            veiculo.ValorDesconto = veiculo.ValorVeiculo * porcentagemDesconto;
            veiculo.ValorFinal = veiculo.ValorVeiculo - veiculo.ValorDesconto;

            return veiculo;
        }

        private static void ExibirResultados(List<Entidades.Veiculo> veiculos)
        {
            decimal totalPagar = 0M, totalDesconto = 0M;

            foreach (var veiculo in veiculos)
            {
                Console.WriteLine(veiculo.NomeVeiculo + " => " +
                    " Valor Original: R$" + veiculo.ValorVeiculo +
                    " Valor Desconto: R$" + veiculo.ValorDesconto +
                    " Valor a Pagar: R$" + veiculo.ValorFinal);
                totalPagar += veiculo.ValorFinal;
                totalDesconto += veiculo.ValorDesconto;
            }

            Console.WriteLine("O valor total de desconto: R$" +
                totalDesconto +
                " e o total a pagar: R$"
                + totalPagar
                );
        }
    }
}
