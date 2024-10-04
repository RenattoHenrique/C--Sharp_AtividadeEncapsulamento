using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Encapsulamento
{
    public class Pessoa
    {
        private string nome;
        private int idade;
        private string telefone;
        private string endereco;
        private string email;

        public string Nome
        {
            get { return nome; }
            set{ 
                if
                (string.IsNullOrWhiteSpace(value))
                    { Console.WriteLine("Nome não pode ser vazio."); }
                else 
                    { nome = value; }
            }
        }

        public int Idade
        {
            get { return idade; }
            set { 
                if
                (value < 0) 
                    { Console.WriteLine("Idade não pode ser negativa."); }
                else 
                { idade = value; }
            }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Email
        {
            get { return email; }
            set { if (string.IsNullOrWhiteSpace(value)) { Console.WriteLine("E-mail não pode ser vazio.\n"); }
                else { email = value; }
            }
        }
    }
}
