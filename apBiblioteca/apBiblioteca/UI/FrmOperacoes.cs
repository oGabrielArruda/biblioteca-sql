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
            Emprestimo novoEmp = new Emprestimo(int.Parse(txtIdLivro.Text), // instancia um novo obj emprestimo
                                    int.Parse(txtIdLeitor.Text),
                                    DateTime.Parse(mtxtDataEmp.Text),
                                    DateTime.Parse(mtxtDataDev.Text));
            try
            {
                EmprestimoBLL empBLL = new EmprestimoBLL();
                empBLL.IncluirEmprestimo(novoEmp); // inclui o emprestimo
                MessageBox.Show("Empréstimo incluído com sucesso"); // se deu certo, avisamos ao usuario
                limparTela(); 
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Emprestimo empAlterado = new Emprestimo(int.Parse(txtIdLeitor.Text),
                int.Parse(txtIdLeitor.Text),
                Convert.ToDateTime(mtxtDataEmp.Text),
                Convert.ToDateTime(mtxtDataDev.Text));

            try
            {
                EmprestimoBLL empBLL = new EmprestimoBLL();
                empBLL.AlterarEmprestimo(empAlterado);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Emprestimo emp = null;
            try
            {
                EmprestimoBLL empBll = new EmprestimoBLL();
                emp = empBll.SelecionarEmprestimoPorId(int.Parse(txtIdEmp.Text)); // atribuimos ao objeto 'emp' o emprestimo escolhido
                btnProcurar.PerformClick(); // exibimos as informações do emprestimo
                empBll.ExcluirEmprestimo(emp); // excluimos
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                EmprestimoBLL bll = new EmprestimoBLL();
                dgvDados.DataSource = bll.SelecionarEmprestimos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
            tabControl1.SelectedTab = tabPage3;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            Emprestimo emp = null;
            try
            {
                EmprestimoBLL bll = new EmprestimoBLL();
                emp = bll.SelecionarEmprestimoPorId(int.Parse(txtIdEmp.Text)); // selecionamos o emprestimo escolhido

                txtIdLeitor.Text = emp.IdLeitor.ToString(); // exibimos suas informacoes
                txtIdLivro.Text = emp.IdLivro.ToString();
                mtxtDataEmp.Text = emp.DataEmprestimo.ToString();
                mtxtDataDev.Text = emp.DataDevolucaoPrevista.ToString();

                if (emp.DataDevolucaoReal != Convert.ToDateTime("01/01/1900")) // se a data de devoluvcao real for diferente da padrão
                    chkDev.Checked = true;                                      // quer dizer que ja foi devolvido
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void limparTela()
        {
            txtIdLeitor.Clear();
            txtIdLivro.Clear();
            mtxtDataDev.Clear();
            mtxtDataEmp.Clear();
            chkDev.Checked = false;
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            try
            {
                EmprestimoBLL bll = new EmprestimoBLL();
                dgvDados.DataSource = bll.SelecionarEmprestimos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnProcurarDev_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text.Trim() == "") // se o text box do id esta vazio
                    throw new Exception("Id vazio");

                EmprestimoBLL bll = new EmprestimoBLL();
                Emprestimo emp = bll.SelecionarEmprestimoPorId(int.Parse(txtId.Text)); // selecionamos o emprestimo escolhido

                txtIdLivroDev.Text = emp.IdLivro.ToString(); // exibimos suas informacoes
                txtIdLeitorDev.Text = emp.IdLeitor.ToString();
                txtDataDevPrev.Text = emp.DataDevolucaoPrevista.ToString();
                txtDataEmpDev.Text = emp.DataEmprestimo.ToString();

                if (emp.DataDevolucaoReal != Convert.ToDateTime("01/01/1900"))
                    chkDev.Checked = true;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text.Trim() == "")
                    throw new Exception("id vazio");
  
                EmprestimoBLL bll = new EmprestimoBLL();
                Emprestimo emp = bll.SelecionarEmprestimoPorId(int.Parse(txtId.Text)); // selecionamos o emprestimo escolhido

                if (emp.DataDevolucaoReal != Convert.ToDateTime("01/01/1900")) // se o emprestimo ja foi devolvido
                    throw new Exception("Livro já devolvido!");


                emp.DataDevolucaoReal = DateTime.Now; // atribuimos ao emprestimo a data atual
                bll.AlterarEmprestimo(emp); // alteramos o emprestimo com a nova data, ficando assim 'devolvido'

                if(emp.DataDevolucaoReal > emp.DataDevolucaoPrevista) 
                 MessageBox.Show("Livro devolvido com atraso!");
                else
                    MessageBox.Show("Livro devolvido no prazo");
            }
            catch(Exception ex){
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }
    }
}
