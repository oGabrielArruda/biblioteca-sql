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
    }
}
