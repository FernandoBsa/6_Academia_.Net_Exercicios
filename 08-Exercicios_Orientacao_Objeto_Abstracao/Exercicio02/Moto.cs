using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Moto : Veiculo
    {
        public string Cilindrada { get; set; }

        public override void Dirigir()
        {
            Console.WriteLine("Dirigindo a " + Marca + " " + Modelo + " com " + Cilindrada + " cilindradas.");
        }
    }
}
