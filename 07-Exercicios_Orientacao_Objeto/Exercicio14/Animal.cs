using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    internal class Animal
    {
        public string Nome { get; set; }
        public string Especie { get; set; }
        public int Idade { get; set; }

        public void EmitirSom()
        {
            Console.WriteLine("O animal emite um som.");
        }
    }
}
