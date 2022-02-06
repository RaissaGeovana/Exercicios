using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AtividadeEmSala.Entidades
{
    internal class Alunos
    {
        public string Identificador { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string endereco { get; set; }
        public Int64 dataDeCadastro { get; set; }

        public static void Aluno()
        {
            string arquivo3 = File.ReadAllText(@"C:\Users\rageo\OneDrive\Área de Trabalho\AlunosV2.csv");

            string[] linhas = arquivo3.Split("\n");

            foreach (string linha in linhas)
            {
                string[] colunas = linha.Split(",");
                try
                {
                    Alunos aluno = new Alunos()
                    {
                        Identificador = colunas[0],
                        nome = colunas[1],
                        email = colunas[2],
                        telefone = colunas[3],
                        endereco = colunas[4],
                        dataDeCadastro = Int64.Parse((colunas[5]).Replace(" ", string.Empty)),
                    };

                    DAO.AlunoDAO alunoDAO = new DAO.AlunoDAO();
                    alunoDAO.Insere(aluno);
                }
                catch
                {
                    continue;
                }
            }
 
            

        }

        
        
    }


}
