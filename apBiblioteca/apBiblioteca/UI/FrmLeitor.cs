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
                MessageBox.Show("Erro: " + ex);
            }
        }
    }
}
