using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apBiblioteca
{
    class Leitor
    {
        const int tamanhoNome = 50;
        const int tamanhoTelefone = 20;
        const int tamanhoEmail = 50;
        const int tamanhoEndereco = 100;



        int idLeitor;
        private string nomeLeitor;
        private string telefoneLeitor;
        private string emailLeitor;
        private string enderecoLeitor;

        public Leitor(int id,string nome, string tel, string email, string endereco)
        {
            IdLeitor = id;
            NomeLeitor = nome;
            TelefoneLeitor = tel;
            EmailLeitor = email;
            EnderecoLeitor = endereco;
        }
        public Leitor(string nome, string tel, string email, string endereco)
        {
            NomeLeitor = nome;
            TelefoneLeitor = tel;
            EmailLeitor = email;
            EnderecoLeitor = endereco;
        }

        public int IdLeitor
        {
            get { return idLeitor; }
            set { idLeitor = value; }
        }



        public string NomeLeitor
        {
            get { return nomeLeitor; }
            set {
                value = value.TrimEnd();
                value = value.PadRight(tamanhoNome, ' ');

                nomeLeitor = value;
            }
        }

        

        public string TelefoneLeitor
        {
            get { return telefoneLeitor; }
            set {
                value = value.TrimEnd();
                value = value.PadRight(tamanhoTelefone, ' ');

                telefoneLeitor = value;

            }
        }
       

        public string EmailLeitor
        {
            get { return emailLeitor; }
            set {

                value = value.TrimEnd();
                value = value.PadRight(tamanhoEmail, ' ');

                emailLeitor = value;
            }
        }


        public string EnderecoLeitor
        {
            get { return enderecoLeitor; }
            set {
                value = value.TrimEnd();
                value = value.PadRight(tamanhoEndereco, ' ');

                enderecoLeitor = value;
            }
        }


    }
}
