using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    internal class ContaCorrente : ContaBancaria
    {
        private bool primeiraRetirada = true;

        public override void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine("Saldo atual: " + Saldo);
        }

        public override void Sacar(double valor)
        {
            if (primeiraRetirada)
            {
                Saldo -= valor;
                primeiraRetirada = false;
            }
            else
            {
                Saldo -= valor + 0.05;
            }
        }
    }
}
