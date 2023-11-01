using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    internal class Fabricante
    {
        private string Nome;
        public string Endereco { get; set; }
        public string Cidade { get; set; }

        public string nome
        {
            get { return Nome; }
            set
            {
                if (value != "")
                {
                    Nome = value;
                }
                else
                {
                    Console.WriteLine("O nome do fabricante não pode ser vazio.");
                }
            }
        }
    }
}
