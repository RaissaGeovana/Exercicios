using System.Data.SqlClient;
using System.IO;
using System;
using System.Collections.Generic;

namespace Restaurante.Conexões
{
    public class Sql
    {
        private readonly SqlConnection _conexao;

        public Sql()
        {
            string stringConexao = (@"Server=5.161.62.27 ;Database=ES03;User Id=aluno;Password=5aPLAE89ucfKPJeBe4w#Gv_adTb?9#^z;");
            _conexao = new SqlConnection(stringConexao);
        }

        public void InserirCliente(Entidades.Cliente cliente)
        {
            try
            {

                _conexao.Open();


                string query = @"INSERT INTO Cliente
                                       (Nome
                                       ,Cpf)
                                 VALUES
                                       (@Nome
                                       ,@Cpf);";


                using (var cmd = new SqlCommand(query, _conexao))
                {

                    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@Cpf", cliente.Cpf);


                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {

                _conexao.Close();
            }
        }
        public void AtualizarCliente(Entidades.Cliente cliente)
        {
            try
            {
                _conexao.Open();

                string query = @"UPDATE Cliente
                                   SET Nome = @Nome
                                 WHERE Cpf = @Cpf";

                using (var cmd = new SqlCommand(query, _conexao))
                {
                    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@Cpf", cliente.Cpf);

                    cmd.ExecuteNonQuery();

                }
            }
            finally
            {
                _conexao.Close();
            }
        }
        public void DeletarCliente(Entidades.Cliente cliente)
        {
            try
            {
                _conexao.Open();

                string query = @"DELETE FROM Cliente
                                 WHERE Cpf = @Cpf";

                using (var cmd = new SqlCommand(query, _conexao))
                {
                    cmd.Parameters.AddWithValue("@Cpf", cliente.Cpf);
                    cmd.ExecuteNonQuery();

                }
            }
            finally
            {
                _conexao.Close();
            }
        }
        public Entidades.Cliente SelecionarCliente(string cpf)
        {
            try
            {
                _conexao.Open();

                string query = @"Select * FROM Cliente
                                 WHERE Cpf = @Cpf";

                using (var cmd = new SqlCommand(query, _conexao))
                {
                    cmd.Parameters.AddWithValue("@Cpf", cpf);
                    var rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        var cliente = new Entidades.Cliente();
                        cliente.Cpf = cpf;
                        cliente.Nome = rdr["Nome"].ToString();

                        return cliente;
                    }
                    else
                    {
                        throw new InvalidOperationException("Cpf " + cpf + " não encontrado!");
                    }
                }
            }
            finally
            {
                _conexao.Close();
            }
        }
        public List<Entidades.Cliente> ListarClientes()
        {
            var clientes = new List<Entidades.Cliente>();
            try
            {
                _conexao.Open();

                string query = @"Select * FROM Cliente";

                using (var cmd = new SqlCommand(query, _conexao))
                {
                    var rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        var cliente = new Entidades.Cliente();
                        cliente.Cpf = rdr["Cpf"].ToString();
                        cliente.Nome = rdr["Nome"].ToString();

                        clientes.Add(cliente);
                    }
                }
            }
            finally
            {
                _conexao.Close();
            }

            return clientes;
        }
        public void InserirMesas(Entidades.Mesas mesas)
        {
            try
            {

                _conexao.Open();


                string query = @"INSERT INTO Mesa
                         
                                      (QuantidadeCadeiras)
                                 VALUES
                                       
                                      (@QuantidadeCadeiras);";


                using (var cmd = new SqlCommand(query, _conexao))
                {

                    cmd.Parameters.AddWithValue("@QuantidadeCadeiras", mesas.QuantidadeCadeiras);



                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {

                _conexao.Close();
            }
        }
        public void AtualizarMesas(Entidades.Mesas mesas)
        {
            try
            {
                _conexao.Open();

                string query = @"UPDATE Mesa
                                   SET QuantidadeCadeiras = @QuantidadeCadeiras
                                 WHERE Identificador = @Identificador";

                using (var cmd = new SqlCommand(query, _conexao))
                {
                    cmd.Parameters.AddWithValue("@QuantidadeCadeiras", mesas.QuantidadeCadeiras);
                    cmd.Parameters.AddWithValue("@Identificador", mesas.Identificador);

                    cmd.ExecuteNonQuery();

                }
            }
            finally
            {
                _conexao.Close();
            }
        }
        public void DeletarMesas(Entidades.Mesas mesas)
        {
            try
            {
                _conexao.Open();

                string query = @"DELETE FROM Mesa
                                 WHERE Identificador = @Identificador";

                using (var cmd = new SqlCommand(query, _conexao))
                {
                    cmd.Parameters.AddWithValue("@Identificador", mesas.Identificador);
                    cmd.ExecuteNonQuery();

                }
            }
            finally
            {
                _conexao.Close();
            }
        }
        public Entidades.Mesas SelecionarMesas(string Identificador)
        {
            try
            {
                _conexao.Open();

                string query = @"Select * FROM Mesa
                                 WHERE Identificador = @identificador";

                using (var cmd = new SqlCommand(query, _conexao))
                {
                    cmd.Parameters.AddWithValue("@identificador", Identificador);
                    var rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        var mesa = new Entidades.Mesas();
                        mesa.Identificador = int.Parse(Identificador);

                        return mesa;
                    }
                    else
                    {
                        throw new InvalidOperationException("Identificador " + Identificador + "não encontrado");
                    }
                }
            }
            finally
            {
                _conexao.Close();
            }
        }
        public List<Entidades.Mesas> ListarMesas()
        {
            var mesas = new List<Entidades.Mesas>();
            try
            {
                _conexao.Open();

                string query = @"Select *
                                FROM Mesa";

                using (var cmd = new SqlCommand(query, _conexao))
                {
                    var rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        var mesa = new Entidades.Mesas();
                        mesa.Identificador = (int)rdr["Identificador"];
                        mesa.QuantidadeCadeiras = Convert.ToInt16(rdr["QuantidadeCadeiras"]);

                        mesas.Add(mesa);
                    }
                }
            }
            finally
            {
                _conexao.Close();
            }

            return mesas;
        }

        public List<Entidades.Reserva> ListarReservas()
        {
            var reservas = new List<Entidades.Reserva>();
            try
            {
                _conexao.Open();

                string query = @"SELECT *
                                FROM ReservaMesa";

                using (var cmd = new SqlCommand(query, _conexao))
                {
                    var rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        var reserva = new Entidades.Reserva();
                        reserva.Identificador = Convert.ToInt32(rdr["Identificador"]);
                        reserva.InicioReserva = Convert.ToDateTime(rdr["InicioReserva"]);
                        reserva.FimReserva = Convert.ToDateTime(rdr["FimReserva"]);
                        reserva.Mesa = new Entidades.Mesas();
                        reserva.Cliente = new Entidades.Cliente();



                        reservas.Add(reserva);
                    }
                }
            }
            finally
            {
                _conexao.Close();
            }

            return reservas;
        }
        public Entidades.Reserva SelecionarReserva(int Identificador, DateTime InicioReserva, DateTime FimReserva, string Cliente, string Mesa)
        {
            try
            {
                _conexao.Open();

                string query = @"Select * FROM ReservaMesa
                                 WHERE Identificador = @Identificador";

                using (var cmd = new SqlCommand(query, _conexao))
                {
                    cmd.Parameters.AddWithValue("@Identificador", Identificador);



                    var rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        var reserva = new Entidades.Reserva();
                        reserva.Identificador = Identificador;
                        reserva.InicioReserva = InicioReserva;
                        reserva.FimReserva = FimReserva;
                        reserva.Cliente = new Entidades.Cliente() { Cpf = Convert.ToString(rdr["Cliente"]) };
                        reserva.Mesa = new Entidades.Mesas() { Identificador = (int)rdr["Mesa"] };



                        return reserva;
                    }
                    else
                    {
                        throw new InvalidOperationException("Mesa " + Identificador + " não encontrado!");
                    }
                }
            }
            finally
            {
                _conexao.Close();
            }
        }
        public List<Entidades.Mesas> ConsultarDisponibilidadeMesas(int qtdeCadeiras, DateTime dataInicio, DateTime dataFim)
        {
            var mesas = new List<Entidades.Mesas>();
            try
            {
                _conexao.Open();

                string query = @"SELECT m.Identificador FROM Mesa m
                                    --condicao que compara o identificador que nao contem na lista retornada da sub query
                                    WHERE m.Identificador NOT IN
                                    --subquery que retorna somente uma lista de identificador com base na pesquisa dentro de parenteses
                                    (SELECT m.Identificador AS IdentificadorMesa FROM Mesa m
                                    JOIN ReservaMesa rm ON m.Identificador = rm.Mesa
                                    WHERE rm.InicioReserva
                                    BETWEEN @dataInicio AND @dataFim
                                    AND rm.FimReserva 
                                    BETWEEN @dataInicio AND @dataFim)
                                    --ja estando fora da subquery, filtramos a quantidade de cadeiras
                                    AND m.QuantidadeCadeiras = @qtdeCadeiras";

                using (var cmd = new SqlCommand(query, _conexao))
                {
                    cmd.Parameters.AddWithValue("dataInicio", dataInicio);
                    cmd.Parameters.AddWithValue("dataFim", dataFim);
                    cmd.Parameters.AddWithValue("qtdeCadeiras", qtdeCadeiras);

                    var rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        var mesa = new Entidades.Mesas();
                        mesa.Identificador = Convert.ToInt32(rdr["Identificador"]);
                        mesas.Add(mesa);
                    }
                }
            }
            finally
            {
                _conexao.Close();
            }

            return mesas;
        }
        public void InserirReserva(Entidades.Reserva reserva)
        {
            try
            {

                _conexao.Open();


                string query = @"INSERT INTO ReservaMesa
                                           (Identificador
                                           ,InicioReserva
                                            ,FimReserva
                                            ,Cliente
                                            ,Mesa)
                                     VALUES
                                           (@Identificador
                                           ,@InicioReserva
                                            ,@FimReserva
                                            ,@Cliente
                                            ,@Mesa);";


                using (var cmd = new SqlCommand(query, _conexao))
                {

                    cmd.Parameters.AddWithValue("@Identificador", reserva.Identificador);
                    cmd.Parameters.AddWithValue("@InicioReserva", reserva.InicioReserva);
                    cmd.Parameters.AddWithValue("@FimReserva", reserva.FimReserva);
                    cmd.Parameters.AddWithValue("@Cliente", reserva.Cliente);
                    cmd.Parameters.AddWithValue("@Mesa", reserva.Mesa);

                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {

                _conexao.Close();
            }
        }
    }

}
