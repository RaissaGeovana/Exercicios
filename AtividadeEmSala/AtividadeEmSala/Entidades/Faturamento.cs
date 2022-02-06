using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AtividadeEmSala.DAO;

namespace AtividadeEmSala.Entidades
{
    internal class Faturamento
    {
        public string Identificador { get; set; }
        
        public decimal TotalEntrada { get; set; }
        
        public decimal TotalSaida { get; set; }
        
        public DateTime DiaReferencia { get; set; }

        public static void Faturamentos()
        {
            string arquivo1 = File.ReadAllText(@"C:\Users\rageo\OneDrive\Área de Trabalho\Faturamentos.csv");
            
            string[] linhas = arquivo1.Split("\n");

            foreach (string linha in linhas)
            {
                string[] colunas = linha.Split(",");

                try
                {
                    Faturamento faturamento = new Faturamento()
                    {
                        Identificador = colunas[0],
                        DiaReferencia = DateTime.Parse(colunas[1]),
                        TotalEntrada = decimal.Parse((colunas[2]+","+ colunas[3]).Replace("R$", string.Empty).Replace(" ", string.Empty).Replace("\"",string.Empty)),
                        TotalSaida = decimal.Parse((colunas[4] + "," + colunas[5]).Replace("R$", string.Empty).Replace(" ", string.Empty).Replace("\"", string.Empty))
                    };

                    FaturamentoDAO faturamentoDAO = new FaturamentoDAO();
                    faturamentoDAO.Insere(faturamento);
                }
                catch
                {
                    continue;
                }
            }
        }
        

    }

    
}

