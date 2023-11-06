using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    abstract class Animal
    {
        public string Nome { get; set; }
        public string Especie { get; set; }
        public int Idade { get; set; }

        public Animal(string nome)
        {
            this.Nome = nome;
        }
        public abstract void EmitirSom();
        public  void Movimentou(string direcao)
        {
            Console.WriteLine("O Animal esta se movimentando para " + direcao);
        }

    }
}
