using ConsoleApp1.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio39();
        }

        public static void Exercicio40()
        {
            Console.WriteLine("Digite o nome:");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite a idade:");
            var idade = Uteis.ObtemInteiro();

            Console.WriteLine("Digite a grupo de risco:");
            Console.WriteLine("1- Baixo");
            Console.WriteLine("2- Medio");
            Console.WriteLine("3- Alto");
            var risco = Uteis.ObtemInteiro();

            if (idade < 17 || idade > 70)
            {
                Console.WriteLine("Idade não está na faixa necessária.");
            }
            else if (idade <= 20)
            {
                if (risco == 1)
                    Console.WriteLine("A categoria é 1");
                if (risco == 2)
                    Console.WriteLine("A categoria é 2");
                if (risco == 3)
                    Console.WriteLine("A categoria é 3");
            }
            else if (idade <= 24)
            {
                if (risco == 1)
                    Console.WriteLine("A categoria é 2");
                if (risco == 2)
                    Console.WriteLine("A categoria é 3");
                if (risco == 3)
                    Console.WriteLine("A categoria é 4");
            }
            else if (idade <= 34)
            {
                if (risco == 1)
                    Console.WriteLine("A categoria é 3");
                if (risco == 2)
                    Console.WriteLine("A categoria é 4");
                if (risco == 3)
                    Console.WriteLine("A categoria é 5");
            }
            else if (idade <= 64)
            {
                if (risco == 1)
                    Console.WriteLine("A categoria é 4");
                if (risco == 2)
                    Console.WriteLine("A categoria é 5");
                if (risco == 3)
                    Console.WriteLine("A categoria é 6");
            }
            else if (idade <= 70)
            {
                if (risco == 1)
                    Console.WriteLine("A categoria é 7");
                if (risco == 2)
                    Console.WriteLine("A categoria é 8");
                if (risco == 3)
                    Console.WriteLine("A categoria é 9");
            }
        }

        public static void Exercicio39()
        {
            Console.WriteLine("Digite o nome do aluno:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a matricula do aluno:");
            var matricula = Uteis.ObtemInteiro();
            
            Console.WriteLine("Digite a Nota de Laboratório:");
            var lab = Uteis.ObtemInteiro();

            Console.WriteLine("Digite a Nota de Avaliação Semestral:");
            var semestral = Uteis.ObtemInteiro();

            Console.WriteLine("Digite a Nota de Exame Final:");
            var final = Uteis.ObtemInteiro();

            var mediaPonderada = (lab * 2 + semestral * 3 + final * 5) / 10M;

            Console.WriteLine($"O aluno {nome} da matricula {matricula} tem  a media {mediaPonderada}:");

            if (mediaPonderada <= 5)
                Console.WriteLine("Sua classificação é R");
            if (mediaPonderada <= 6)
                Console.WriteLine("Sua classificação é D");
            if (mediaPonderada <= 7)
                Console.WriteLine("Sua classificação é C");
            if (mediaPonderada <= 8)
                Console.WriteLine("Sua classificação é B");
            if (mediaPonderada <= 10)
                Console.WriteLine("Sua classificação é A");
        }

        public static void Exercicio38()
        {
            Console.WriteLine("Digite a Nota de Laboratório:");
            var lab = Uteis.ObtemInteiro();

            Console.WriteLine("Digite a Nota de Avaliação Semestral:");
            var semestral = Uteis.ObtemInteiro();

            Console.WriteLine("Digite a Nota de Exame Final:");
            var final = Uteis.ObtemInteiro();

            var mediaPonderada = (lab * 2 + semestral * 3 + final * 5) / 10M;

            Console.WriteLine($"A média das notas é de {mediaPonderada}:");

        }

        public static void Exercicio37()
        {
            Console.WriteLine("Digite o sexo.");
            var sexo = Console.ReadLine().ToUpper().FirstOrDefault().ToString();

            Console.WriteLine("Digite a altura");
            var altura = Uteis.ObtemDecimal();

            Console.WriteLine("Digite a Idade");
            var idade = Uteis.ObtemInteiro();

            double pesoIdeal = default;

            if (sexo == "M")
            {
                if (altura > 1.7)
                {
                    if (idade <= 20)
                        pesoIdeal = (72.7 * altura) - 58;
                    else if (idade < 39)
                        pesoIdeal = (72.7 * altura) - 53;
                    else
                        pesoIdeal = (72.7 * altura) - 45;
                }
                else
                {
                    if (idade <= 40)
                        pesoIdeal = (72.7 * altura) - 50;
                    else
                        pesoIdeal = (72.7 * altura) - 58;
                }
            }
            else
            {
                if (altura > 1.5)
                {
                    pesoIdeal = (62.1 * altura) - 44.7;
                }
                else
                {
                    if (altura >= 35)
                        pesoIdeal = (62.1 * altura) - 45;
                    else
                        pesoIdeal = (62.1 * altura) - 49;
                }
            }

            Console.WriteLine($"O peso ideal é {pesoIdeal}");
        }

        public static void Exercicio36()
        {
            Console.WriteLine("Digite o tipo de cliente.");
            Console.WriteLine("1. Residência");
            Console.WriteLine("2. Comércio");
            Console.WriteLine("3. Indústria");
            var tipoCliente = Uteis.ObtemInteiro();

            Console.WriteLine("Digite o consumo em Kw.");
            var consumo = Uteis.ObtemInteiro();

            switch (tipoCliente)
            {
                case 1:
                    Console.WriteLine($"O consumo total é de {consumo}Kw e o valor total é de {consumo * 0.6}");
                    break;
                case 2:
                    Console.WriteLine($"O consumo total é de {consumo}Kw e o valor total é de {consumo * 0.48}");
                    break;
                case 3:
                    Console.WriteLine($"O consumo total é de {consumo}Kw e o valor total é de {consumo * 1.29}");
                    break;
                default:
                    Console.WriteLine($"Tipo inválido.");
                    break;
            }
        }

        public static void Exercicio35()
        {
            Console.WriteLine("Digite a idade do nadador.");
            var idade = Uteis.ObtemInteiro();

            if (idade < 5 || idade > 25)
                Console.WriteLine("Idade fora da faixa etária.");
            else if (idade < 8)
                Console.WriteLine("Infantil A.");
            else if (idade < 11)
                Console.WriteLine("Infantil B.");
            else if (idade < 14)
                Console.WriteLine("Juvenil A.");
            else if (idade < 18)
                Console.WriteLine("Juvenil B.");
            else
                Console.WriteLine("Sênior.");
        }

        public static void Exercicio34()
        {
            Console.WriteLine("Digite o nome do professor.");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de horas trabalhadas.");
            int horasTrabalhadas = Uteis.ObtemInteiro();
            Console.WriteLine("Digite o nível do professor.");
            Nivel nivel = (Nivel)Uteis.ObtemInteiro();

            Professor professor = new Professor(nome, horasTrabalhadas, nivel);

            switch (professor.Nivel)
            {
                case Nivel.Nivel1:
                    Console.WriteLine($"{professor.Nome} | {professor.HorasTrabalhadas} | R${(12 * horasTrabalhadas).ToString("0.00")}");
                    break;
                case Nivel.Nivel2:
                    Console.WriteLine($"{professor.Nome} | {professor.HorasTrabalhadas} | R${(12 * horasTrabalhadas).ToString("0.00")}");
                    break;
                case Nivel.Nivel3:
                    Console.WriteLine($"{professor.Nome} | {professor.HorasTrabalhadas} | R${(12 * horasTrabalhadas).ToString("0.00")}");
                    break;
            }
        }

        public static void Exercicio33()
        {
            Console.WriteLine($"Digite o valor do 1º lado.");
            var A = Uteis.ObtemInteiro();
            Console.Clear();

            Console.WriteLine($"Digite o valor do 2º lado.");
            var B = Uteis.ObtemInteiro();
            Console.Clear();

            Console.WriteLine($"Digite o valor do 3º lado.");
            var C = Uteis.ObtemInteiro();
            Console.Clear();

            if (
                Math.Abs(B - C) < A && A < B + C
                && Math.Abs(A - C) < B && B < A + C
                && Math.Abs(A - B) < C && C < A + B
               )
            {
                Console.WriteLine("Esses podem ser lados de um triângulo.");

                if (A == B && A == C && B == C)
                    Console.WriteLine("Triangulo equilátero.");
                else if (A == B || A == C || B == C)
                    Console.WriteLine("Triangulo isóceles.");
                else
                    Console.WriteLine("Triangulo equilátero.");
            }
            else
            {
                Console.WriteLine("Esse triângulo não existe.");
            }
        }

        public static void Exercicio32()
        {

            Console.WriteLine($"Digite um numero real.");
            var A = Uteis.ObtemDecimal();
            Console.Clear();

            Console.WriteLine($"Digite um numero real.");
            var B = Uteis.ObtemDecimal();
            Console.Clear();

            Console.WriteLine($"Digite um operador matemático.");
            var C = Console.ReadLine();
            Console.Clear();

            switch (C)
            {
                case "+":
                    Console.WriteLine(A + B);
                    break;
                case "-":
                    Console.WriteLine(A - B);
                    break;
                case "*":
                    Console.WriteLine(A * B);
                    break;
                case "/":
                    Console.WriteLine(A / B);
                    break;
                default:
                    Console.WriteLine("Operador inválido.");
                    break;
            }
        }

        public static void Exercicio31()
        {
            List<int> numeros = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Digite um numero inteiro.");
                numeros.Add(Uteis.ObtemInteiro());

                Console.Clear();
            }

            Console.Write("Antes: {");
            numeros.ForEach(x => Console.Write($"{x} "));
            Console.WriteLine("}");

            var sorted = numeros.OrderBy(x => x).ToList();

            Console.Write("Depois: {");
            sorted.ForEach(x => Console.Write($"{x} "));
            Console.WriteLine("}");
        }

        public static void Exercicio30()
        {
            Console.WriteLine("Nome do funcionário:");
            string nome = Console.ReadLine();

            Console.WriteLine("Idade do funcionário:");
            int idade = Uteis.ObtemInteiro();

            Console.WriteLine("Sexo do funcionário:");
            string sexo = Console.ReadLine().ToUpper().FirstOrDefault().ToString();

            Console.WriteLine("Salário do funcionário:");
            double salario = Uteis.ObtemDecimal();

            switch (sexo)
            {
                case "M":
                    Console.WriteLine(idade >= 30 ? $"O salário liquido de {nome} é de R${(salario + 100).ToString("0.00")}" : $"O salário liquido de {nome} é de R${(salario + 50).ToString("0.00")}");
                    break;
                case "F":
                    Console.WriteLine(idade >= 30 ? $"O salário liquido de {nome} é de R${(salario + 200).ToString("0.00")}" : $"O salário liquido de {nome} é de R${(salario + 80).ToString("0.00")}");
                    break;
                default:
                    Console.WriteLine("Valor atribuido a sexo é inválido.");
                    break;
            };
        }

        public static void Exercicio29()
        {
            Console.WriteLine("Digite o numero correspondente ao mês.");
            int numero = Uteis.ObtemInteiro();

            switch (numero)
            {
                case 1:
                    Console.WriteLine("O mês selecionado foi Janeiro");
                    break;
                case 2:
                    Console.WriteLine("O mês selecionado foi Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("O mês selecionado foi Março");
                    break;
                case 4:
                    Console.WriteLine("O mês selecionado foi Abril");
                    break;
                case 5:
                    Console.WriteLine("O mês selecionado foi Maio");
                    break;
                case 6:
                    Console.WriteLine("O mês selecionado foi Junho");
                    break;
                case 7:
                    Console.WriteLine("O mês selecionado foi Julho");
                    break;
                case 8:
                    Console.WriteLine("O mês selecionado foi Agosto");
                    break;
                case 9:
                    Console.WriteLine("O mês selecionado foi Setembro");
                    break;
                case 10:
                    Console.WriteLine("O mês selecionado foi Outubro");
                    break;
                case 11:
                    Console.WriteLine("O mês selecionado foi Novembro");
                    break;
                case 12:
                    Console.WriteLine("O mês selecionado foi Dezembro");
                    break;
                default:
                    Console.WriteLine("Mês inválido.");
                    break;
            }
        }

        public static void Exercicio28()
        {
            double somatorioAumentoFolha = 0;
            bool continuar = false;
            do
            {
                Console.WriteLine("Digite o nome do funcionario.");
                var nome = Console.ReadLine();
                Console.WriteLine("Digite o salário do funcionario.");
                var salario = Uteis.ObtemDecimal();
                Console.WriteLine("Digite o valor do salário mínimo.");
                var salarioMinimo = Uteis.ObtemDecimal();

                double salarioReajustado = 0;
                double reajuste = 0;
                if (salario < salarioMinimo * 3)
                {
                    salarioReajustado = salario + salario * 0.5;
                    reajuste = salario * 0.5;
                }
                else if (salario <= salarioMinimo * 10)
                {
                    salarioReajustado = salario + salario * 0.2;
                    reajuste = salario * 0.2;
                }
                else if (salario <= salarioMinimo * 20)
                {
                    salarioReajustado = salario + salario * 0.15;
                    reajuste = salario * 0.15;
                }
                else
                {
                    salarioReajustado = salario + salario * 0.1;
                    reajuste = salario * 0.1;
                }

                somatorioAumentoFolha += reajuste;

                Console.WriteLine($"Nome: {nome} | Reajuste: {reajuste.ToString("0.00")} | Novo Salário: {salarioReajustado.ToString("0.00")}");
                Console.WriteLine("Deseja continuar?");
                continuar = Console.ReadLine().ToUpper().First() != 'N';

                Console.Clear();

            } while (continuar);

            Console.WriteLine($"O aumento total da folha foi de {somatorioAumentoFolha.ToString("0.00")}");
        }

        public static void Exercicio27()
        {
            VendasCarango.ContabilizarVendas();
        }

        public static void Exercicio26()
        {
            Console.WriteLine("Digite um numero de 1 a 5");
            int numero = Uteis.ObtemInteiro();

            switch (numero)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("Um");
                    break;
                case 2:
                    Console.WriteLine("Dois");
                    break;
                case 3:
                    Console.WriteLine("Três");
                    break;
                case 4:
                    Console.WriteLine("Quatro");
                    break;
                case 5:
                    Console.WriteLine("Cinco");
                    break;
                default:
                    Console.WriteLine("Número inválido.");
                    break;
            }
        }

        public static void Exercicio25()
        {
            Console.WriteLine("Digite o primeiro número.");
            int numero1 = Uteis.ObtemInteiro();

            Console.WriteLine("Digite o segundo número.");
            int numero2 = Uteis.ObtemInteiro();

            Console.WriteLine(numero1 == numero2 ? "Números iguais." : "Números diferentes.");

            if (numero1 != numero2)
            {
                Console.WriteLine(numero1 > numero2 ? $"{numero1} maior que {numero2}." : $"{numero2} maior que {numero1}.");
            }
        }

        public static void Exercicio24()
        {
            bool continuar = false;
            do
            {
                Console.WriteLine("Digite o numero.");
                int numero = Uteis.ObtemInteiro();

                Console.WriteLine(numero < 0 ? "Negativo" : numero == 0 ? "Zero" : "Positivo");

                Console.WriteLine("Deseja continuar?");
                continuar = Console.ReadLine().ToUpper().First() != 'N';
            } while (continuar);
        }

        public static void Exercicio23()
        {
            Console.WriteLine("Digite o número.");
            int numero = Uteis.ObtemInteiro();

            if (numero < 25 || numero == 40 || numero > 80)
            {
                Console.WriteLine("O número está dentro do escopo definido (numero < 25, = 40 ou > 80).");
            }
        }

        public static void Exercicio22()
        {
            double somaCusto = 0;
            double somaVenda = 0;

            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine($"Digite o preço de custo do produto {i + 1}.");
                double precoCusto = Uteis.ObtemDecimal();
                Console.WriteLine($"Digite o preço de venda do produto {i + 1}.");
                double precoVenda = Uteis.ObtemDecimal();

                Console.WriteLine($"\r\nEsse produto {(precoCusto < precoVenda ? "gerou lucro." : precoCusto == precoVenda ? "não gerou lucro nem prejuízo." : "gerou prejuízo.")}.");

                somaCusto += precoCusto;
                somaVenda += precoVenda;
            }

            Console.WriteLine($"A média do preço de custo é {somaCusto / 40}");
            Console.WriteLine($"A média do preço de venda é {somaVenda / 40}");
        }

        public static void Exercicio21()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            bool continuar = false;
            do
            {
                Console.WriteLine("Digite o nome da pessoa.");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite a idade da pessoa.");
                int idade = Uteis.ObtemInteiro();
                Console.WriteLine("Digite o sexo da pessoa.");
                string sexo = Console.ReadLine();
                Console.WriteLine("A pessoa é saudável?");
                bool saudavel = Uteis.ObtemBoleano();

                Pessoa pessoa = new Pessoa(nome, sexo, idade, saudavel);
                pessoas.Add(pessoa);

                Console.WriteLine("Deseja continuar?");
                continuar = Console.ReadLine().ToUpper().First() != 'N';
            } while (continuar);

            pessoas.ForEach((pessoa) =>
            {
                Console.WriteLine($"Nome: {pessoa.Nome} | Idade: {pessoa.Idade} | Apto: {(pessoa.AptoServicoMilitar ? "Sim" : "Não")}");
            });

            Console.WriteLine("\r\n\r\n");

            Console.WriteLine($"Quantidade de pessoas aptas: {pessoas.Where(x => x.AptoServicoMilitar).Count()}");
            Console.WriteLine($"Quantidade de pessoas não aptas: {pessoas.Where(x => !x.AptoServicoMilitar).Count()}");
            Console.WriteLine($"Quantidade total de pessoas: {pessoas.Count}");
        }

        public static void Exercicio20()
        {
            bool continuar = false;
            List<Carro> carros = new List<Carro>();
            do
            {
                Console.WriteLine("Digite o modelo do carro.");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o valor do carro.");
                double valor = Uteis.ObtemDecimal();
                Console.WriteLine("Digite o ano do carro.");
                int ano = Uteis.ObtemInteiro();

                Carro carro = new Carro(nome, valor, ano);
                carros.Add(carro);

                Console.WriteLine("Deseja continuar?");
                continuar = Console.ReadLine().ToUpper().First() != 'N';
            } while (continuar);

            carros.ForEach((carro) =>
            {
                if (carro.Ano <= 2000)
                {
                    carro.Valor = carro.Valor - carro.Valor * 0.12;
                }
                else
                {
                    carro.Valor = carro.Valor - carro.Valor * 0.07;
                }
            });

            Console.WriteLine($"O total de carros até ano 2000 é de {carros.Where(x => x.Ano <= 2000).Count()} e o valor somado é de {carros.Where(x => x.Ano <= 2000).Sum(x => x.Valor).ToString("0.00")}");
            Console.WriteLine($"O total de carros é de {carros.Count} e o valor somado é de {carros.Sum(x => x.Valor).ToString("0.00")}");
        }

        private static void Exercicio19()
        {
            static void Main(string[] args)
            {
                int qtdMasculino = 0, qtdFeminino = 0, qtdInvalido = 0;

                for (int i = 0; i < 56; i++)
                {

                    Console.WriteLine($"Digite a nome  {i + 1}ª pessoa:");
                    var strIdade = Console.ReadLine();
                    Console.WriteLine($"Digite o sexo  {i + 1}ª pessoa:");
                    string sexo = Console.ReadLine();


                    if (sexo.ToLower().StartsWith("m"))
                        qtdMasculino++;
                    else if (sexo.ToLower().StartsWith("f"))
                        qtdFeminino++;
                    else
                        qtdInvalido++;

                }

                Console.WriteLine($"Quantidade masculino: {qtdMasculino}");
                Console.WriteLine($"Quantidade feminino: {qtdFeminino}");
                Console.WriteLine($"Quantidade invalido: {qtdInvalido}");
            }


        }
        private static void Exercicio18()
        {
            for (int i = 0; i < 75; i++)
            {
                Console.WriteLine($"Digite a idade  {i + 1}ª pessoa:");

                var strIdade = Console.ReadLine();
                double idade;

                if (!double.TryParse(strIdade.Replace(",", "."), out idade))
                {
                    Console.WriteLine("Valor inválido, o valor será ignorado.");
                    continue;
                }

                if (idade >= 18)
                    Console.WriteLine("Maior idade.");
                else
                    Console.WriteLine("Menor idade.");
            }
        }

        private static void Exercicio17()
        {
            int qtdDentroRange = 0, qtdForaRange = 0;

            for (int i = 0; i < 80; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º número:");

                var strNota = Console.ReadLine();
                double numero;

                if (!double.TryParse(strNota.Replace(",", "."), out numero))
                {
                    Console.WriteLine("Valor inválido, o valor será ignorado.");
                    continue;
                }

                if (numero >= 10 && numero <= 150)
                    qtdDentroRange++;
                else
                    qtdForaRange++;
            }

            Console.WriteLine($"Quantidade que está entre 10(inclusive) e 150(inclusive): {qtdDentroRange}");
            Console.WriteLine($"Quantidade que não está entre 10(inclusive) e 150(inclusive): {qtdForaRange}");
        }

        private static void Exercicio16()
        {
            Console.WriteLine("Digite o nome do aluno");
            var nomeAluno = Console.ReadLine();
            double nota = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite o valor da nota");

                var strNota = Console.ReadLine();
                double valorNota;

                if (!double.TryParse(strNota.Replace(",", "."), out valorNota))
                {
                    Console.WriteLine("Valor inválido, reinicie o programa e insira um valor decimal para continuar.");
                    return;
                }

                nota += valorNota;
            }

            var media = nota / 3;

            if (nota >= 7)
                Console.WriteLine("Aprovado");
            else if (nota < 7 && nota > 5)
                Console.WriteLine("Recuperação");
            else
                Console.WriteLine("Reprovado");
        }

        private static void Exercicio15()
        {
            Console.WriteLine("Digite um número.:");
            var strNumero = Console.ReadLine();

            int numero = int.Parse(strNumero);

            if (numero >= 100 && numero <= 200)
            {
                Console.WriteLine($"{numero} esta no intervalo entre 100 e 200.");
            }
            else
            {
                Console.WriteLine($"{numero} não esta no intervalo entre 100 e 200.");
            }
        }

        private static void Exercicio14()
        {
            Console.WriteLine("Digite um número.:");
            var strNumero = Console.ReadLine();
            Console.WriteLine("Digite um número.:");
            var strNumero2 = Console.ReadLine();


            int numero1 = int.Parse(strNumero);
            int numero2 = int.Parse(strNumero2);

            if (numero1 > numero2)
            {
                Console.WriteLine($"{numero1} e maior .");

            }
            else if (numero2 > numero1)
            {
                Console.WriteLine($"{numero2} e maior .");
            }
            else
            {
                Console.WriteLine("Valores iguais");
            }


        }

        private static void Exercicio13()
        {
            Console.WriteLine("Digite um número.:");
            var strNumero = Console.ReadLine();

            double numero;
            if (!double.TryParse(strNumero.Replace(",", "."), out numero))
            {
                Console.WriteLine("Valor inválido, reinicie o programa e insira um valor decimal para continuar.");
                return;
            }

            if (numero > 10)
                Console.WriteLine("Numero maior que 10.:");
        }

        private static void Exercicio12()
        {
            Console.WriteLine("Digite o valor de custo de fábrica em Real (R$).:");
            var strValorCustoFabrica = Console.ReadLine();

            double valorCustoFabrica;
            if (!double.TryParse(strValorCustoFabrica.Replace(",", "."), out valorCustoFabrica))
            {
                Console.WriteLine("Valor inválido, reinicie o programa e insira um valor decimal para continuar.");
                return;
            }

            double valorVendaCarro = valorCustoFabrica + (valorCustoFabrica * 45 / 100);
            valorVendaCarro += (valorVendaCarro * 28 / 100);

            Console.WriteLine($"O carro tem o valor de custo fabrica de R${valorCustoFabrica.ToString("F2", CultureInfo.CreateSpecificCulture("nl-BE"))} e o valor de venda é de R${valorVendaCarro.ToString("F2", CultureInfo.CreateSpecificCulture("nl-BE"))}.");
        }

        private static void Exercicio11()
        {
            Console.WriteLine("Digite o valor de custo do produto em Real (R$).:");
            var strValorCustoProduto = Console.ReadLine();

            double valorCustoProduto;
            if (!double.TryParse(strValorCustoProduto.Replace(",", "."), out valorCustoProduto))
            {
                Console.WriteLine("Valor inválido, reinicie o programa e insira um valor decimal para continuar.");
                return;
            }

            Console.WriteLine("Digite a margem a ser acrescida.:");
            string strPercentualAcrescido = Console.ReadLine();

            int percentualAcrescido;
            if (!int.TryParse(strPercentualAcrescido.Replace(",", "."), out percentualAcrescido))
            {
                Console.WriteLine("Valor inválido, reinicie o programa e insira um valor decimal para continuar.");
                return;
            }

            double valorVendaProduto = valorCustoProduto + valorCustoProduto * percentualAcrescido / 100;

            Console.WriteLine($"O produto escolhido tem o valor de custo de R${valorCustoProduto.ToString("F2", CultureInfo.CreateSpecificCulture("nl-BE"))} e o valor de venda é de R${valorVendaProduto.ToString("F2", CultureInfo.CreateSpecificCulture("nl-BE"))}.");
        }

        private static void Exercicio10()
        {
            Console.WriteLine("Digite o valor do produto em Real (R$).:");
            var strValorProduto = Console.ReadLine();

            double valorProduto;
            if (!double.TryParse(strValorProduto.Replace(",", "."), out valorProduto))
            {
                Console.WriteLine("Valor inválido, reinicie o programa e insira um valor decimal para continuar.");
                return;
            }

            double valorPrestacao = valorProduto / 5;

            Console.WriteLine($"O produto escolhido tem o valor de R${valorProduto.ToString("F2", CultureInfo.CreateSpecificCulture("nl-BE"))} e foi dividido em 5 prestações de R${valorPrestacao.ToString("F2", CultureInfo.CreateSpecificCulture("nl-BE"))}.");
        }

        private static void Exercicio9()
        {
            Console.WriteLine("Digite o valor depositado em Real (R$).:");
            var strValorDeposito = Console.ReadLine();

            double valorDeposito;
            if (!double.TryParse(strValorDeposito.Replace(",", "."), out valorDeposito))
            {
                Console.WriteLine("Valor inválido, reinicie o programa e insira um valor decimal para continuar.");
                return;
            }

            Console.WriteLine("Digite o tempo de investimento em meses.:");
            string strTempoInvestimento = Console.ReadLine();

            int tempoInvestimento;
            if (!int.TryParse(strTempoInvestimento.Replace(",", "."), out tempoInvestimento))
            {
                Console.WriteLine("Valor inválido, reinicie o programa e insira um valor decimal para continuar.");
                return;
            }

            double montante = valorDeposito * Math.Pow((1 + 0.007), tempoInvestimento);

            Console.WriteLine($"O valor de R${valorDeposito.ToString("F2", CultureInfo.CreateSpecificCulture("nl-BE"))} investido com rendimentos de 0,7% a.m. gerou um montante de R${montante.ToString("0.00")}.");
        }

        private static void Exercicio8()
        {
            Console.WriteLine("Digite o valor em Real (R$).:");
            var strValorReal = Console.ReadLine();

            decimal valorReal;
            if (!decimal.TryParse(strValorReal.Replace(",", "."), out valorReal))
            {
                Console.WriteLine("Valor inválido, reinicie o programa e insira um valor decimal para continuar.");
                return;
            }

            Console.WriteLine("Digite o valor da cotação de 1 Dólar (U$) em Real (R$) .:");
            var strCotacaoDolar = Console.ReadLine();

            decimal cotacaoDolar;
            if (!decimal.TryParse(strCotacaoDolar.Replace(",", "."), out cotacaoDolar))
            {
                Console.WriteLine("Valor inválido, reinicie o programa e insira um valor decimal para continuar.");
                return;
            }

            decimal valorDolar = valorReal / cotacaoDolar;

            Console.WriteLine($"O valor de R${valorReal.ToString("F2", CultureInfo.CreateSpecificCulture("nl-BE"))} convertido para Dólar é de U${valorDolar.ToString("0.00")}.");
        }

        private static void Exercicio7()
        {
            Console.WriteLine("Digite a temperatura em ºC.:");
            var strGrausCelsius = Console.ReadLine();

            double grausCelsius;
            if (!double.TryParse(strGrausCelsius, out grausCelsius))
            {
                Console.WriteLine("Valor inválido, reinicie o programa e insira um valor decimal para continuar.");
                return;
            }

            double grausFahrenheit = (9 * grausCelsius + 160) / 5;

            Console.WriteLine($"O valor de {grausCelsius}ºC convertido para Fahrenheit é de {grausFahrenheit}ºF.");
            Console.ReadKey();
        }
        private static void Exercicio6()
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
        }
        private static void Exercicio5()
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

        private static void Exercicio4()
        {
            string nomeFuncionario;
            double salarioFixo, vendasTotal, comissao, salarioFinal;

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

        private static void Exercicio3()
        {
            Console.WriteLine("Digite a distancia percorrida (Km).");
            var distanciaPercorrida = Uteis.ObtemDecimal();

            Console.WriteLine("Digite a quantidade de combustivel gasto (litros).");
            var combustivelGasto = Uteis.ObtemDecimal();

            Console.WriteLine($"A quantidade de combustível gasto foi de {(distanciaPercorrida / combustivelGasto).ToString("0.##")}Km por litro de combustível.");
        }
        private static void Exercicio2()
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
        private static void Exercicio1()
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



