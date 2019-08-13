using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apBiblioteca
{
    class Emprestimo
    {

        int idEmprestimo;

        public int IdEmprestimo
        {
            get { return idEmprestimo; }
            set { idEmprestimo = value; }
        }


        int idLivro;

        public int IdLivro
        {
            get { return idLivro; }
            set { idLivro = value; }
        }

        int idLeitor ;

        public int IdLeitor
        {
            get { return idLeitor ; }
            set { idLeitor = value; }
        }

        DateTime dataEmprestimo;

        public DateTime DataEmprestimo
        {
            get { return dataEmprestimo; }
            set { dataEmprestimo = value; }
        }

        DateTime dataevolucaoPrevista;

        public DateTime DataDevolucaoPrevista
        {
            get { return dataevolucaoPrevista; }
            set { dataevolucaoPrevista = value; }
        }

        DateTime dataDevolucaoReal;

        public DateTime DataDevolucaoReal
        {
            get { return dataDevolucaoReal; }
            set { dataDevolucaoReal = value; }
        }




    }
}
