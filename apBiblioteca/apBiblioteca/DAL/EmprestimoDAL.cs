using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace apBiblioteca.DAL
{
    class EmprestimoDAL
    {
        String _conexaoSQLServer = "";
        SqlConnection conexao = null;


        public EmprestimoDAL()
        {
            _conexaoSQLServer = "Data Source = regulus.cotuca.unicamp.br; Initial Catalog = BD19170; Persist Security Info = True; User ID = BD19170; Password=BD19170";


        }

        public List<Emprestimo> SelectListEmprestimos() // o pai dos erros
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conexaoSQLServer))
                {
                    using (SqlCommand command = new SqlCommand("select * from BibEmprestimo", conn))
                    {
                        conn.Open();
                        List<Emprestimo> listaEmprestimos = new List<Emprestimo>();
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Emprestimo emprestimo = new Emprestimo((int)dr["idEmprestimo"],
                                                                            (int)dr["idLivro"],
                                                                          (int)dr["idLeitor"],
                                                                          (DateTime)dr["dataEmprestimo"],
                                                                          (DateTime)dr["dataDevolucaoPrevista"],
                                                                          (DateTime)dr["dataDevolucaoReal"]
                                    );
                                listaEmprestimos.Add(emprestimo);
                            }
                            return listaEmprestimos;
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                throw ex;

            }

        }

        public DataTable SelecionarEmprestimos()
        {
            try
            {
                String sql = "select * from BibEmprestimo";
                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Emprestimo SelectById(int id)
        {
            try
            {
                String sql = $"select * from BibEmprestimo where idEmprestimo=@id";
                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", id);
                conexao.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Emprestimo emprestimo = null;
                if (dr.Read())
                {
                    emprestimo = new Emprestimo((int)dr["idEmprestimo"],
                                                (int)dr["idLivro"],
                                                (int)dr["idLeitor"],
                                                (DateTime)dr["dataEmprestimo"],
                                                (DateTime)dr["dataDevolucaoPrevista"],
                                                (DateTime)dr["dataDevolucaoReal"]
                                        );
                }
                return emprestimo;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Emprestimo SelecionarPorIdLivro(int id)
        {
            try
            {
                String sql = "select * from BibEmprestimo where idLivro=@id";
                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", id);
                conexao.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                Emprestimo emprestimo = null;
                if (dr.Read())
                {
                    emprestimo = new Emprestimo((int)dr["idEmprestimo"],
                                                (int)dr["idLivro"],
                                                (int)dr["idLeitor"],
                                                (DateTime)dr["dataEmprestimo"],
                                                (DateTime)dr["dataDevolucaoPrevista"],
                                                (DateTime)dr["dataDevolucaoReal"]
                                        );
                }
                return emprestimo;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertEmprestimo(Emprestimo qualEmprestimo)
        {
            try
            {
                String sql = "insert into BibEmprestimo values(" +
                             "@idLivro, @idLeitor, @dataEmprestimo, @dataDevolucaoPrevista, '')";
                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@idLivro", qualEmprestimo.IdLivro);
                cmd.Parameters.AddWithValue("@idLeitor", qualEmprestimo.IdLeitor);
                cmd.Parameters.AddWithValue("@dataEmprestimo", qualEmprestimo.DataEmprestimo);
                cmd.Parameters.AddWithValue("@dataDevolucaoPrevista", qualEmprestimo.DataDevolucaoPrevista);
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }

        public void UpdateEmprestimo(Emprestimo qualEmprestimo)
        {
            try
            {
                String sql = "update BibEmprestimo set idLivro=@idLivro,"+
                    "idLeitor=@idLeitor,"+
                    "dataEmprestimo=@dataEmprestimo,"+
                    "dataDevolucaoPrevista=@dataDevolucaoPrevista,"+
                    "dataDevolucaoReal=@dataDevolucaoReal "+
                    "where idEmprestimo = @id";
                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@idLivro", qualEmprestimo.IdLivro);
                cmd.Parameters.AddWithValue("@idLeitor", qualEmprestimo.IdLeitor);
                cmd.Parameters.AddWithValue("@dataEmprestimo", qualEmprestimo.DataEmprestimo);
                cmd.Parameters.AddWithValue("@dataDevolucaoPrevista", qualEmprestimo.DataDevolucaoPrevista);
                cmd.Parameters.AddWithValue("@dataDevolucaoReal", qualEmprestimo.DataDevolucaoReal);
                cmd.Parameters.AddWithValue("@id", qualEmprestimo.IdEmprestimo);
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }

        public void DeleteEmprestimo(Emprestimo qualEmprestimo)
        {
            try
            {
                String sql = "Delete from BibEmprestimo where idEmprestimo=@id";
                conexao = new SqlConnection(_conexaoSQLServer);
                SqlCommand cmd = new SqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@id", qualEmprestimo.IdEmprestimo);
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool LeitorTemLivro(int id) // verifica se o leitor tem livro emprestado
        {
            List<Emprestimo> lista = this.SelectListEmprestimos(); // lista com todos emprestimo
            foreach (Emprestimo emp in lista) // pra cada item da lista
            {
                if(emp.IdLeitor == id) // se for um emprestimo do respectivo leitor
                {
                    if(emp.DataDevolucaoReal == Convert.ToDateTime("01/01/1900")) // se o livro não foi devolvido
                        return true; // retorna se verdadeiro, ou seja, o leitor tem livro emprestados
                }
            }      
                return false;            
        }

        public bool LeitorCheio(int id) // verifica se o leitor ja tem 5 livros
        {
            List<Emprestimo> lista = this.SelectListEmprestimos(); // lista com todos emprestimos
            int qtd = 0;
            foreach(Emprestimo emp in lista) // pra cada item da lista
            {
                if(emp.IdLeitor == emp.IdLeitor // se for o leitor desejado
                    && emp.DataDevolucaoReal == Convert.ToDateTime("01/01/1900")) // e se o livro não foi devolvido
                {
                    qtd++; // soma-se 1 na qtd de livros emprestados
                    if (qtd == 5) // se o leitor tiver 5 livros emprestados 
                        return true; // ele já tem seu máximo então retorna-se true
                }
            }
            return false;
        }

        public bool LivroEmprestado(int id) // verifica se o livro está emprestado
        {
            List<Emprestimo> lista = this.SelectListEmprestimos(); // lista com todos emprestimo
            foreach (Emprestimo emp in lista) // pra cada item da lista
            {
                if(emp.IdLivro == id) // se for o leitor desejado
                {
                    if(emp.DataDevolucaoReal == Convert.ToDateTime("01/01/1900")) // se ainda estiver emprestado
                      return true;
                }
            }
            return false;
        }
    }
}
