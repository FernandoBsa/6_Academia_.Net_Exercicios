using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class ContaCorrente : ContaBancaria
    {
        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
            else
            {
                Saldo -= valor;
            }
        }
    }
}
