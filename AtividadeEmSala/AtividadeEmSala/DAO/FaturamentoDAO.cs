using AtividadeEmSala.Entidades;
using QueryLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeEmSala.DAO
{
    internal class FaturamentoDAO : IDisposable
    {
        private readonly SqlConnection _conexao;

        public FaturamentoDAO()
        {
            _conexao = new SqlConnection("Server=5.161.62.27;Database=ES02;User Id=aluno;Password=5aPLAE89ucfKPJeBe4w#Gv_adTb?9#^z");
        }

        public void Dispose()
        {

        }

        internal void Insere(Faturamento faturamento)
        {
            _conexao.Open();

            string query = @"INSERT INTO Faturamento
                             VALUES (@Identificador, @TotalEntrada, @TotalSaida, @DiaReferencia)";

            using (var cmd = new SqlCommand(query, _conexao))
            {
                cmd.Parameters.AddWithValue("@Identificador", faturamento.Identificador);
                cmd.Parameters.AddWithValue("@TotalEntrada", faturamento.TotalEntrada);
                cmd.Parameters.AddWithValue("@TotalSaida", faturamento.TotalSaida);
                cmd.Parameters.AddWithValue("@DiaReferencia", faturamento.DiaReferencia);

                cmd.ExecuteNonQuery();
            }
        }
    }
}

