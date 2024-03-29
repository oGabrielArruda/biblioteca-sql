﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apBiblioteca
{
    class Emprestimo
    {
        public Emprestimo(int idEmprestimo, int idLivro, int idLeitor, DateTime dataEmprestimo, DateTime dataDevolucaoPrevista, DateTime dataDevolucaoReal)
        {
            this.IdEmprestimo = idEmprestimo;
            this.IdLivro = idLivro;
            this.IdLeitor = idLeitor;
            this.DataEmprestimo = dataEmprestimo;
            this.DataDevolucaoPrevista = dataDevolucaoPrevista;
            this.DataDevolucaoReal = dataDevolucaoReal;
        }
        public Emprestimo(int idLivro, int idLeitor, DateTime dataEmprestimo, DateTime dataDevolucaoPrevista, DateTime dataDevolucaoReal)
        {
            this.IdLivro = idLivro;
            this.IdLeitor = idLeitor;
            this.DataEmprestimo = dataEmprestimo;
            this.DataDevolucaoPrevista = dataDevolucaoPrevista;
            this.DataDevolucaoReal = dataDevolucaoReal;
        }

        public Emprestimo(int idLivro, int idLeitor, DateTime dataEmprestimo, DateTime dataDevolucaoPrevista)
        {
            this.IdLivro = idLivro;
            this.IdLeitor = idLeitor;
            this.DataEmprestimo = dataEmprestimo;
            this.DataDevolucaoPrevista = dataDevolucaoPrevista;
        }

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

        DateTime dataDevolucaoPrevista;

        public DateTime DataDevolucaoPrevista
        {
            get { return dataDevolucaoPrevista; }
            set { dataDevolucaoPrevista = value; }
        }

        DateTime dataDevolucaoReal;

        public DateTime DataDevolucaoReal
        {
            get { return dataDevolucaoReal; }
            set { dataDevolucaoReal = value; }
        }
    }
}
