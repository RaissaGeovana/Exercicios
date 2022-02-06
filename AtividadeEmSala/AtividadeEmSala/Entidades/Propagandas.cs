using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AtividadeEmSala.Entidades
{
    internal class Propagandas
    {
        public string Identificador { get; set; }

        public string EmpresaDivulgadora { get; set; }

        public decimal Custo { get; set; }

        public DateTime DataPropaganda { get; set; }

        public static void Propaganda()
        {
            {
                string arquivo2 = File.ReadAllText(@"C:\Users\rageo\OneDrive\Área de Trabalho\Propagandas.csv");

                string[] linhas = arquivo2.Split("\n");
                foreach (string linha in linhas)
                {
                    string[] colunas = linha.Split(",");
                    try
                    {
                        Propagandas propaganda = new Propagandas()
                        {
                            Identificador = colunas[0],
                            EmpresaDivulgadora = colunas[1],
                            Custo = Decimal.Parse(colunas[2]),
                            DataPropaganda = DateTime.Parse(colunas[3]),
                        };

                        DAO.PropagandaDAO propagandaDAO = new DAO.PropagandaDAO();
                        propagandaDAO.Insere(propaganda);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
        }


    }

    


    


}
