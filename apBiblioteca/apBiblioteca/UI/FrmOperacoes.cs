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
                                    DateTime.Parse(mtxtDataEmp.Text),
                                    DateTime.Parse(mtxtDataDev.Text));
            try
            {
                EmprestimoBLL empBLL = new EmprestimoBLL();
                empBLL.IncluirEmprestimo(novoEmp);
                MessageBox.Show("Empréstimo incluído com sucesso");
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
                emp = empBll.SelecionarEmprestimoPorIdLivro(int.Parse(txtIdLivro.Text));
                btnProcurar.PerformClick();
                empBll.ExcluirEmprestimo(emp);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            Emprestimo emp = null;
            try
            {
                EmprestimoBLL bll = new EmprestimoBLL();
                emp = bll.SelecionarEmprestimoPorIdLivro(int.Parse(txtIdLivro.Text));
                txtIdLeitor.Text = emp.IdLeitor.ToString();
                txtIdLivro.Text = emp.IdLivro.ToString();
                mtxtDataEmp.Text = emp.DataEmprestimo.ToString();
                mtxtDataDev.Text = emp.DataDevolucaoPrevista.ToString();
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
                if (txtId.Text.Trim() == "")
                    throw new Exception("Id vazio");

                EmprestimoBLL bll = new EmprestimoBLL();
                Emprestimo emp = bll.SelecionarEmprestimoPorIdLivro(int.Parse(txtId.Text));

                txtIdLeitorDev.Text = emp.IdLeitor.ToString();
                txtDataDevPrev.Text = emp.DataDevolucaoPrevista.ToString();
                txtDataEmpDev.Text = emp.DataEmprestimo.ToString();
                
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
                Emprestimo emp = bll.SelecionarEmprestimoPorId(int.Parse(txtId.Text));

                emp.DataDevolucaoReal = DateTime.Now;
                bll.AlterarEmprestimo(emp);
            }
            catch(Exception ex){
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }
    }
}
