using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Carro : Veiculo
    {
        public int NumeroPortas { get; set; }
        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine("Número de portas: " + NumeroPortas);
        }
    }
}
