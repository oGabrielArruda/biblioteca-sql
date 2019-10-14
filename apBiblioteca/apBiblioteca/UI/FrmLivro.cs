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
    public partial class FrmLivro : Form
    {
        public FrmLivro()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                //Cria uma instância da classe LivroBLL()
                LivroBLL livroBLL = new LivroBLL();
                dgvLivro.DataSource = livroBLL.SelecionarLivros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro(0, "", "", "");
            livro.CodigoLivro = txtCodigoLivro.Text;
            livro.TituloLivro = txtTituloLivro.Text;
            livro.AutorLivro = txtAutorLivro.Text;
            try
            {
                LivroBLL livroBLL = new LivroBLL();
                livroBLL.IncluirLivro(livro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro(int.Parse(txtIdLivro.Text),
                                    txtCodigoLivro.Text,
                                    txtTituloLivro.Text,
                                    txtAutorLivro.Text);
            
            try
            {
                LivroBLL livroBLL = new LivroBLL();
                livroBLL.AlterarLivro(livro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro(int.Parse(txtIdLivro.Text),
                                   "",
                                   "",
                                   "");

            try
            {
                LivroBLL livroBLL = new LivroBLL();
                livroBLL.ExcluirLivro(livro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdLivro.Text);
            Livro livro = new Livro(id,
                                 "",
                                 "",
                                 "");

            try
            {
                LivroBLL livroBLL = new LivroBLL();
                livro = livroBLL.SelecionarLivroPorId(id);
                txtCodigoLivro.Text = livro.CodigoLivro;
                txtTituloLivro.Text = livro.TituloLivro;
                txtAutorLivro.Text = livro.AutorLivro;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
            txtIdLivro.ReadOnly = true;

        }

        private void btnExibir_Click_1(object sender, EventArgs e)
        {
            try
            {
                LivroBLL livroBLL = new LivroBLL();
                dgvLivro.DataSource = livroBLL.SelecionarLivros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }

        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            Livro livro = new Livro(0, "", "", "");
            livro.CodigoLivro = txtCodigoLivro.Text;
            livro.TituloLivro = txtTituloLivro.Text;
            livro.AutorLivro = txtAutorLivro.Text;

            try
            {
                LivroBLL livroBLL = new LivroBLL();
                livroBLL.IncluirLivro(livro);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }


        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            Livro livro = new Livro(int.Parse(txtIdLivro.Text),
                                    txtCodigoLivro.Text,
                                    txtTituloLivro.Text,
                                    txtAutorLivro.Text);

            try
            {
                LivroBLL livroBLL = new LivroBLL();
                livroBLL.AlterarLivro(livro);


            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message.ToString());
            }


        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            Livro livro = new Livro(Convert.ToInt32(txtIdLivro.Text), "", "", "");
            try
            {
                LivroBLL livrobll = new LivroBLL();
                livrobll.ExcluirLivro(livro);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message.ToString());
            }
        }

        private void btnProcurar_Click_1(object sender, EventArgs e)
        {
           limparTela();
            try
            {
                if (txtIdLivro.Text.Trim() == "")
                    throw new Exception("Id vazio");
                int id = Convert.ToInt32(txtIdLivro.Text);
                Livro livro = new Livro(id, "", "", "");
                BLL.LivroBLL bll = new LivroBLL();
                 livro = bll.SelecionarLivroPorId(id);
                 txtCodigoLivro.Text = livro.CodigoLivro;
                 txtTituloLivro.Text = livro.TituloLivro;
                 txtAutorLivro.Text = livro.AutorLivro;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro : " + ex.Message.ToString());
            }        
        }

        private void limparTela()
        {
            txtCodigoLivro.Clear();
            txtAutorLivro.Clear();
            txtTituloLivro.Clear();
        }
    }
}
