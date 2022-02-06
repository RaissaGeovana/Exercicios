using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AtividadeEmSala.DAO
{
    internal class PropagandaDAO
    {
        private readonly SqlConnection _conexao;

        public PropagandaDAO()
        {
            _conexao = new SqlConnection("Server=5.161.62.27;Database=ES02;User Id=aluno;Password=5aPLAE89ucfKPJeBe4w#Gv_adTb?9#^z");
        }

        internal void Insere(Entidades.Propagandas propaganda)
        {
            _conexao.Open();

            string query = @"INSERT INTO Aluno
                             VALUES (@Identificador, @EmpresaDivulgadora, @Custo, @DataPropaganda)";

            using (var cmd = new SqlCommand(query, _conexao))
            {
                cmd.Parameters.AddWithValue("@Identificador", propaganda.Identificador);
                cmd.Parameters.AddWithValue("@EmpresaDivulgadora", propaganda.EmpresaDivulgadora);
                cmd.Parameters.AddWithValue("@Custo", propaganda.Custo);
                cmd.Parameters.AddWithValue("@DataPropaganda", propaganda.DataPropaganda);

                cmd.ExecuteNonQuery();
            }
        }

    }
}

