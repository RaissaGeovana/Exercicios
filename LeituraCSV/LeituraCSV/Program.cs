using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace LeituraCSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Entidades.Aluno> alunos = new List<Entidades.Aluno>();

            string arquivo = File.ReadAllText(@"C:\Users\rageo\OneDrive\Área de Trabalho\AlunosV2.csv");

            string[] linhas = arquivo.Split("\n");

            int contadorLinha = 0;
            foreach (string linha in linhas)
            {
                if (contadorLinha == 0)
                {
                    contadorLinha++;
                    continue;
                }
                if (linha == "")
                    continue;
                string[] colunas = linha.Split(",");
                
                
                 string identificador = colunas[0];
                 string nome = colunas[1];
                 string email = colunas[2];
                 string telefone = colunas[3];
                 string endereço = colunas[4];
                 string dataCadastro = colunas[5];

                Entidades.Aluno aluno = new Entidades.Aluno();

                aluno.Identificador = identificador;
                aluno.Nome = nome;  
                aluno.Email = email;
                aluno.Telefone = telefone;
                aluno.Endereco = endereço;
                aluno.DataDeCadastro = dataCadastro;

                alunos.Add(aluno);
            }
             

                
            

        }
    }
}
