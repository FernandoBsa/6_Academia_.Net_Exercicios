using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Circulo : IFormaGeometrica
    {
        public double Raio { get; set; }

        public double CalcularArea()
        {
            return 3.14 * Raio * Raio;
        }

        public double CalcularPerimetro()
        {
            return 2 * 3.14 * Raio;
        }
    }
}
