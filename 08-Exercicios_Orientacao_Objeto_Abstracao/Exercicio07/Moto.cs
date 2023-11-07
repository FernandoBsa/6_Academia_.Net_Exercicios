using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Moto : Veiculo
    {
        public string Cilindrada { get; set; }

        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine("Cilindrada: " + Cilindrada);
        }
    }
}
