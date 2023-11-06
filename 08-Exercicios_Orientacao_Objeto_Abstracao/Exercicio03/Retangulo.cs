﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Retangulo : IFormaGeometrica
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public double CalcularArea()
        {
            return Largura * Altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }
    }
}
