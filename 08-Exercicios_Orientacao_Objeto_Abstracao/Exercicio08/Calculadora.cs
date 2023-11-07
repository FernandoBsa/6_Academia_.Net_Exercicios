using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    internal class Calculadora
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }
        public decimal Somar(decimal a, decimal b)
        {
            return a + b;
        }
        public int Subtrair(int a, int b)
        {
            return a - b;
        }
        public decimal Subtrair(decimal a, decimal b)
        {
            return a - b;
        }
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
        public decimal Multiplicar(decimal a, decimal b)
        {
            return a * b;
        }
        public int Dividir(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }
            else
            {
                return a / b;
            }
        }

        public decimal Dividir(decimal a, decimal b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }
            else 
            { 
                return a / b;   
            }
        }
    }
}
