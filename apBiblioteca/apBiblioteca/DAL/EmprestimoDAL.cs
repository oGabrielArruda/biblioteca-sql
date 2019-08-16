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
            _conexaoSQLServer = "Data Source = regulus; Initial Catalog = BD19170; Persist Security Info = True; User ID = BD19170; Password=260104gj";


        }

        public List<Emprestimo> SelectListEmprestimos()
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
                                Emprestimo emprestimo = new Emprestimo(...);
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
    }
}
