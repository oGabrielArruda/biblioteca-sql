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
    public partial class FrmLeitor : Form
    {
        public FrmLeitor()
        {
            InitializeComponent();
        }

        private void btnNovoLeitor_Click(object sender, EventArgs e)
        {
            Leitor leitor = new Leitor(txtNomeLeitor.Text, txtTelLeitor.Text, txtEmailLeitor.Text, txtEnderecoLeitor.Text);
            try
            {
                LeitorBLL leitorBLL = new LeitorBLL();
                leitorBLL.IncluirLeitor(leitor);
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
                 LeitorBLL leitorBLL = new LeitorBLL();
                 dgvLeitor.DataSource = leitorBLL.SelecionarLeitores();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnAlterarLeitor_Click(object sender, EventArgs e)
        {
            Leitor leitor = new Leitor(txtNomeLeitor.Text, txtTelLeitor.Text, txtEmailLeitor.Text, txtEnderecoLeitor.Text);
            try
            {
                LeitorBLL leitorBLL = new LeitorBLL();
                leitorBLL.AlterarLeitor(leitor);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                LeitorBLL leitorBLL = new LeitorBLL();
                leitorBLL.ExcluirLeitor(int.Parse(txtIdLeitor.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnProcurarLeitor_Click(object sender, EventArgs e)
        {
            limparTela();
            int id = int.Parse(txtIdLeitor.Text);
            Leitor leitor = new Leitor("", "", "", "");
            try
            {
                LeitorBLL leitorBLL = new LeitorBLL();
                leitor = leitorBLL.SelecionarLeitorPorId(id);
                txtNomeLeitor.Text = leitor.NomeLeitor;
                txtTelLeitor.Text = leitor.TelefoneLeitor;
                txtEmailLeitor.Text = leitor.EmailLeitor;
                txtEnderecoLeitor.Text = leitor.EnderecoLeitor;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void limparTela()
        {
            txtEmailLeitor.Clear();
            txtEnderecoLeitor.Clear();
            txtNomeLeitor.Clear();
            txtTelLeitor.Clear();
        }
    }
}
