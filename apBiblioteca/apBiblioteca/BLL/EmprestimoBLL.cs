using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace apBiblioteca.BLL
{
    class EmprestimoBLL
    {
        DAL.EmprestimoDAL dal = null;

        public EmprestimoBLL()
        {

        }

        public List<Emprestimo> ListarEmprestimos()
        {
            try
            {
                dal = new DAL.EmprestimoDAL();
                return dal.SelectListEmprestimos();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable SelecionarEmprestimos()
        {
            DataTable dt = new DataTable();
            try
            {
                dal = new DAL.EmprestimoDAL();
                return dt = dal.SelecionarEmprestimos();
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }


    }
}
