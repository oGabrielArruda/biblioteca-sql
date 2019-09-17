using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using apBiblioteca.BLL;

namespace apBiblioteca.UI
{
    public partial class FrmOperacoes : Form
    {
        public FrmOperacoes()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Emprestimo novoEmp = new Emprestimo(int.Parse(txtIdLivro.Text),
                                    int.Parse(txtIdLeitor.Text), 
                                    Convert.ToDateTime(mtxtDataEmp.Text), 
                                    Convert.ToDateTime(mtxtDataDev),
                                    Convert.ToDateTime(""));
            try
            {
                EmprestimoBLL empBLL = new EmprestimoBLL();
                empBLL.IncluirEmprestimo(novoEmp);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Emprestimo empAlterado = new Emprestimo(int.Parse(txtIdEmprestimo.Text),
                int.Parse(txtIdLeitor.Text),
                Convert.ToDateTime(mtxtDataEmp.Text),
                Convert.ToDateTime(mtxtDataDev.Text),
                Convert.ToDateTime("")
                );

            try
            {
                EmprestimoBLL empBLL = new EmprestimoBLL();
                empBLL.IncluirEmprestimo(empAlterado);
            }
            catch(Exception ex)
            {s
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }
    }
}
