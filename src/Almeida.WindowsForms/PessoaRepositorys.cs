using Almeida.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Almeida.WindowsForms
{
    public class PessoaRepositorys : AbstractRepository<Pessoa, int>
    {
        public override void Delete(Pessoa entity)
        {
            throw new NotImplementedException();
        }

        public override void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Pessoa> GetAll()
        {
            string sql = "SELECT Nome, Cpf, Telefone, DataInicio FROM Pessoa order by Nome";
            using (var conn = new SqlConnection(ConnectionStrings))
            {
                var cmd = new SqlCommand(sql, conn);
                List<Pessoa> list = new List<Pessoa>();
                Pessoa p = null;
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            p = new Pessoa();
                            p.Id = (int)reader["Id"];
                            p.Nome = reader["Nome"].ToString();
                            p.Documento = reader["CPF"].ToString();
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
        public override Pessoa GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override void Save(Pessoa entity)
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
                cmd.Parameters.AddWithValue("@Cpf", entity.Documento);
                //cmd.Parameters.AddWithValue("@DataInicio", entity.DataInicio);
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
        //public DataTable GetConsultaPessoaPagamento()
        //{

        //    DataTable tabela = new DataTable();

        //    //SqlDataAdapter da = new SqlDataAdapter(" SELECT Nome, Telefone, CPF, DataInicio, pg.DataPagamento " +
        //    // " FROM " +
        //    // " dbo.Pessoa as pe " +
        //    // " left join dbo.Pagamento pg " +
        //    // " on pe.Id = pg.PessoaId ", ConnectionStrings);
        //    //da.Fill(tabela);
        //    //return tabela;


        //    //using (var conn = new SqlConnection(ConnectionStrings))
        //    //{
        //    //    var sql = " SELECT pe.Id, Nome, Telefone, CPF, DataInicio, pg.DataPagamento " +
        //    // " FROM " +
        //    // " dbo.Pessoa as pe " +
        //    // " left join dbo.Pagamento pg " +
        //    // " on pe.Id = pg.PessoaId ";
        //    //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    //    try
        //    //    {
        //    //       conn.Open();
        //    //       var dados =  cmd.ExecuteReader();
        //    //        System.Windows.Forms.MessageBox.Show("Sucesso ao salvar");
        //    //        tabela.Select(dados);
        //    //        return tabela;
        //    //    }
        //    //    catch (Exception e)
        //    //    {
        //    //        throw e;
        //    //    }
        //    //}

        //}

        public override void Update(Pessoa entity)
        {
            throw new NotImplementedException();
        }
    }
}
