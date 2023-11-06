using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    internal class Gato : Animal
    {

        public int Vidas { get; set; }
        public Gato(string nome, int vidas) : base(nome)
        {
            this.Vidas = vidas;
        }

        public void Roronar()
        {
            Console.WriteLine("Roronando!");
        }
        public override void EmitirSom()
        {
            Console.WriteLine("Miau Miau");
        }

        public void Movimentou(string direcao)
        {
            Console.WriteLine("O gato se movimentou para " + direcao);
        }
    }
}
