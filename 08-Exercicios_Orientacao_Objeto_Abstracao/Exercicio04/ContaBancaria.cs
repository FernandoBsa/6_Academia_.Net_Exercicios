using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal abstract class ContaBancaria
    {
        public decimal Saldo { get; protected set; }

        public abstract void Depositar(decimal valor);

        public abstract void Sacar(decimal valor);
    }
}
