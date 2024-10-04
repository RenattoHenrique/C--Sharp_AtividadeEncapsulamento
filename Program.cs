using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan time = new TimeSpan(0, 0, 05);
            while (true)
            {
                Thread.Sleep(1000);
                time = time - TimeSpan.FromSeconds(1);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Contagem Regressiva: " + time.ToString(@"hh\:mm\:ss"));
                Console.ForegroundColor = ConsoleColor.Gray;
                if (time.TotalSeconds == 0) break;

            }
            Console.Clear();

            Pessoa pessoa = new Pessoa();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" ------------------ENCAPSULAMENTOS------------------ \n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.ForegroundColor = ConsoleColor.Red;
            pessoa.Nome = "";
            pessoa.Idade = -100;
            pessoa.Email = "";
            Console.ForegroundColor = ConsoleColor.Gray;

            
            pessoa.Nome = "Renato Henrique de Oliveira Ramos";
            pessoa.Idade = 27;
            pessoa.Telefone = "(81) 98594-2139";
            pessoa.Endereco = "Antiga PE 28, s/n - Jardim Santo Inacio, PE, 54500-000";
            pessoa.Email = "renatohenrique@gmail.com";
            

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Nome: " + pessoa.Nome);
            Console.WriteLine("Idade: " + pessoa.Idade + " Anos");
            Console.WriteLine("Telefone: " + pessoa.Telefone);
            Console.WriteLine("Endereço: " + pessoa.Endereco);
            Console.WriteLine("E-mail: " + pessoa.Email);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}