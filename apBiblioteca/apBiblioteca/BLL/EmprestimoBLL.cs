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
                dt = dal.SelecionarEmprestimos();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public Emprestimo SelecionarEmprestimoPorId(int id)
        {
            try
            {
                dal = new DAL.EmprestimoDAL();
                return dal.SelectById(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Emprestimo SelecionarEmprestimoPorIdLivro(int idLivro)
        {
            try
            {
                dal = new DAL.EmprestimoDAL();
                return dal.SelecionarPorIdLivro(idLivro);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void IncluirEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                dal = new DAL.EmprestimoDAL();
                if(!dal.LivroEmprestado(emprestimo.IdLivro) && !dal.LeitorCheio(emprestimo.IdLeitor))
                    dal.InsertEmprestimo(emprestimo);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                dal = new DAL.EmprestimoDAL();
                dal.UpdateEmprestimo(emprestimo);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                dal = new DAL.EmprestimoDAL();
                dal.DeleteEmprestimo(emprestimo);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
