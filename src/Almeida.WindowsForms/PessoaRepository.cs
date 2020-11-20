using Almeida.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Almeida.WindowsForms
{
    public class PessoaRepository : AbstractRepository<Pessoas, int>
    {
        public override void Delete(Pessoas entity)
        {
            throw new NotImplementedException();
        }

        public override void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Pessoas> GetAll()
        {
            string sql = "SELECT Nome, Cpf, Telefone, DataInicio FROM Pessoa order by Nome";
            using (var conn = new SqlConnection(ConnectionStrings))
            {
                var cmd = new SqlCommand(sql, conn);
                List<Pessoas> list = new List<Pessoas>();
                Pessoas p = null;
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            p = new Pessoas();
                            p.Id = (int)reader["Id"];
                            p.Nome = reader["Nome"].ToString();
                            p.Cpf = reader["CPF"].ToString();
                            p.Telefone = reader["Telefone"].ToString();
                            list.Add(p);
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                return list;
            }

        }
        public override Pessoas GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override void Save(Pessoas entity)
        {
            //var caminhoBanco = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "BancoAlmeidaJJ.mdf");
            //var stringConexao = string.Format(@"Server=(localdb)\mssqllocaldb; Integrated Security=true; AttachDbFileName={0};", caminhoBanco);


            //using (var conn = new System.Data.SqlClient.SqlConnection(stringConexao))
            using (var conn = new SqlConnection(ConnectionStrings))
            {
                string sql = "INSERT INTO Pessoa (Nome, Telefone, Cpf, DataInicio) VALUES (@Nome, @Telefone, @Cpf, @DataInicio)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nome", entity.Nome);
                cmd.Parameters.AddWithValue("@Telefone", entity.Telefone);
                cmd.Parameters.AddWithValue("@Cpf", entity.Cpf);
                cmd.Parameters.AddWithValue("@DataInicio", entity.DataInicio);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("Sucesso ao salvar");
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

        }

        public override void Update(Pessoas entity)
        {
            throw new NotImplementedException();
        }
    }
}
