using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal abstract class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public abstract double CalcularDesconto();
    }
}
