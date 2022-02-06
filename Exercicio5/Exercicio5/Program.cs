using System;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeAluno;
            decimal[] notaProva = new decimal[3];
            decimal soma = 0.0M, media;

            Console.WriteLine("Qual o nome do Aluno(a)? ");
            nomeAluno = Console.ReadLine();


            for (int cnt = 0; cnt < 3; cnt++)
            {
                Console.WriteLine("Qual a nota da " + (cnt + 1) + "ª prova ?");
                notaProva[cnt] = Convert.ToDecimal(Console.ReadLine());

                soma += notaProva[cnt];

            }



            media = (soma / 3);
            Console.WriteLine("O aluno(a) " + nomeAluno + " teve uma média de " + media + " pontos nas provas.");
        }
    }  
}
