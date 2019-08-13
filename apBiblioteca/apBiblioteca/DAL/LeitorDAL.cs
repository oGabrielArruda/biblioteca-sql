using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace apBiblioteca.DAL
{
    class LeitorDAL
    {
        String _conexaoSQLServer = "";
        SqlConnection conexao = null;


        public LeitorDAL()
        {
            _conexaoSQLServer = "Data Source = regulus; Initial Catalog = BD19170; Persist Security Info = True; User ID = BD19170; Password=260104gj";


        }


        /* Retorna uma Lista de Livros, ou seja, um objeto da 
           classe List<Livro> com os livros selecionados
        */
        public List<Leitor> SelectListLeitores()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conexaoSQLServer))
                {
                    using (SqlCommand command = new SqlCommand("select * from BibLeitor", conn))
                    {
                        conn.Open();
                        List<Leitor> listaLeitores = new List<Leitor>();
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Leitor leitor = new Leitor(
                                                  (int)dr["idLeitor"],
                                                  dr["nomeLeitor"] + "",
                                                  dr["telefoneLeitor"] + "",
                                                  dr["emailLeitor"] + "",
                                                  dr["enderecoLeitor"] + ""
                                    );
                                listaLeitores.Add(leitor);
                            }
                            return listaLeitores;
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                throw ex;

            }

        }



        //Retorna uma lista de leitores 
        public DataTable SelectLeitores()
        {
            try
            {

                String sql = "select * from BibLeitor";
                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        //Retorna um Livro selecionado pelo idLivro
        public Leitor SelectByID(int id)
        {
            try
            {
                String sql = "select * from BibLeitor where idLeitor = @id";
                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", id);
                conexao.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Leitor leitor = null;
                if (dr.Read())
                {
                    leitor = new Leitor(Convert.ToInt32(dr["idLeitor"]),
                                       dr["nomeLeitor"].ToString(),
                                       dr["telefoneLeitor"].ToString(),
                                       dr["emailLeitor"].ToString(),
                                       dr["enderecoLeitor"].ToString()
                                       );
                }



                return leitor;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retorna um leitor pelo codigo
        public Leitor SelectLeitorByNome(string nome)
        {
            try
            {
                String sql = "select * from BibLeitor where nomeLeitor = @nome";
                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                SqlDataReader dr;
                /*
                 * A classe SqlCommand usa o ExecuteReader 
                 * para fazer F5 no comando sql
                 * 
                 */
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Leitor leitor = null;
                if (dr.Read())
                {
                    leitor = new Leitor(Convert.ToInt32(dr["idLeitor"]),
                                       dr["nomeLeitor"].ToString(),
                                       dr["telefoneLeitor"].ToString(),
                                       dr["emailLeitor"].ToString(),
                                       dr["enderecoLeitor"].ToString()
                                       );
                }



                return leitor;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Inclui um novo leitor
        public void InsertLeitor(Leitor qualLeitor)
        {

            try
            {
                String sql = "insert into BibLeitor " +
                             "values(@id, @nome, @telefone, @email, @endereco)";

                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", qualLeitor.IdLeitor);
                cmd.Parameters.AddWithValue("@nome", qualLeitor.NomeLeitor);
                cmd.Parameters.AddWithValue("@telefone", qualLeitor.TelefoneLeitor);
                cmd.Parameters.AddWithValue("@email", qualLeitor.EmailLeitor);
                cmd.Parameters.AddWithValue("@endereco", qualLeitor.EnderecoLeitor);
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }


        }

        //Alterar leitor
        public void UpdateLeitor(Leitor qualLeitor)
        {
            try
            {
                String sql = "update BibLeitor set " +
                    "nomeLeitor = @nome," +
                    "telefoneLeitor = @tel " +
                    "emailLeitor = @email" +
                    "enderecoLeitor = @endereco" + 
                    "where idLivro = @id";

                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", qualLeitor.IdLeitor);
                cmd.Parameters.AddWithValue("@nome", qualLeitor.NomeLeitor);
                cmd.Parameters.AddWithValue("@tel", qualLeitor.TelefoneLeitor);
                cmd.Parameters.AddWithValue("@email", qualLeitor.EmailLeitor);
                cmd.Parameters.AddWithValue("@endereco", qualLeitor.EnderecoLeitor);
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }

        }

        //Excluir leitor
        public void DeleteLeitor(Leitor qualLeitor)
        {

            try
            {
                String sql = "delete from BibLeitor " +
                             "where idLeitor=@id";


                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", qualLeitor.IdLeitor);
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
