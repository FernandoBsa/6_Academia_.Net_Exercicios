using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    internal class Livro
    {
        private string Titulo;
        public string titulo
        {
            get { return Titulo; }
            set
            {
                if (value != "")
                {
                    Titulo = value;
                }
                else
                {
                    Console.WriteLine("O título do livro não pode ser vazio.");
                }
            }
        }

        public Autor Autor { get; set; }
    }
}
