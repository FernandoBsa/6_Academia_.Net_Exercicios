﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal class Eletronico : Produto
    {
        public override double CalcularDesconto()
        {
            return Preco * 0.125;
        }
    }
}
