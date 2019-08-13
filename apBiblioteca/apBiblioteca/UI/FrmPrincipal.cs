using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apBiblioteca.UI
{
    public partial class FrmPrincipal : Form
    {
        FrmLivro frmLivro = null;






        FrmLeitor frmLeitor = null;
        FrmOperacoes frmOperacoes = null;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frmLivro == null)
            frmLivro = new FrmLivro();

            frmLivro.Show();

        }

        private void leitoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmLeitor == null)
                frmLeitor = new FrmLeitor();
            frmLeitor.Show();

        }

        private void operaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmOperacoes == null)
                frmOperacoes = new FrmOperacoes();
            frmOperacoes.Show();


        }
    }
}
