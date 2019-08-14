using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace apBiblioteca.BLL
{
    class LeitorBLL
    {
        DAL.LeitorDAL dal = null;
        public LeitorBLL()
        {

        }


        public List<Leitor> ListarLeitores()
        {
            try
            {
                dal = new DAL.LeitorDAL();
                return dal.SelectListLeitores();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public DataTable SelecionarLeitores()
        {
            DataTable dt = new DataTable();
            try
            {
                dal = new DAL.LeitorDAL();
                dt = dal.SelectLeitores();
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public Leitor SelecionarLeitorPorId(int id)
        {
            try
            {
                dal = new DAL.LeitorDAL();
                return dal.SelectByID(id);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public Leitor SelecionarLeitorPorNome(string nome)
        {
            try
            {
                dal = new DAL.LeitorDAL();
                return dal.SelectLeitorByNome(nome);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void IncluirLeitor(Leitor leitor)
        {

            try
            {
                dal = new DAL.LeitorDAL();
                dal.InsertLeitor(leitor);

            }
            catch (Exception ex)
            {
                throw ex;

            }

        }

        public void AlterarLeitor(Leitor leitor)
        {
            try
            {
                dal = new DAL.LeitorDAL();
                dal.UpdateLeitor(leitor);

            }
            catch (Exception ex)
            {
                throw ex;

            }


        }

        public void ExcluirLeitor(int id)
        {
            try
            {
                dal = new DAL.LeitorDAL();
                dal.DeleteLeitor(id);

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}
