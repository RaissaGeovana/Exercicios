using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AtividadeEmSala.DAO
{
    internal class AlunoDAO
    {
        private readonly SqlConnection _conexao;

        public AlunoDAO()
        {
            _conexao = new SqlConnection("Server=5.161.62.27;Database=ES02;User Id=aluno;Password=5aPLAE89ucfKPJeBe4w#Gv_adTb?9#^z");
        }

        internal void Insere(Entidades.Alunos aluno)
        {
            _conexao.Open();

            string query = @"INSERT INTO Aluno
                             VALUES (@Identificador, @Nome, @Email, @Telefone, @Endereço, @DataCadastro)";

            using (var cmd = new SqlCommand(query, _conexao))
            {
                cmd.Parameters.AddWithValue("@Identificador", aluno.Identificador);
                cmd.Parameters.AddWithValue("@Nome", aluno.nome);
                cmd.Parameters.AddWithValue("@Email", aluno.email);
                cmd.Parameters.AddWithValue("@Telefone", aluno.telefone);
                cmd.Parameters.AddWithValue("@Endereço", aluno.endereco);
                cmd.Parameters.AddWithValue("@DataCadastro", aluno.dataDeCadastro);

                cmd.ExecuteNonQuery();
            }
        }

    }
}
