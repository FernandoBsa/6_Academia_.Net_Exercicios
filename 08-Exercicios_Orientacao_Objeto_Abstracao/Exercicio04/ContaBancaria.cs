using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    public abstract class ContaBancaria
    {
        public double Saldo { get; set; }

        public abstract void Depositar(double valor);

        public abstract void Sacar(double valor);
    }
}
