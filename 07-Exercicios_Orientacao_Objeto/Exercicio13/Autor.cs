using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    internal class Autor
    {
        private string Nome;
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
                    Console.WriteLine("O nome do autor não pode ser vazio.");
                }
            }
        }
    }
}
