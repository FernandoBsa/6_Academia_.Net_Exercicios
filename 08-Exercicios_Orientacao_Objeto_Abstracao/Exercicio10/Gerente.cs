using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    internal class Gerente : Funcionario
    {
        public Gerente(string nome, double salario) : base(nome, salario)
        {
        }

        public void CalcularBonus()
        {
            double bonus = Salario * 0.2;
            Console.WriteLine("Bônus do gerente " + Nome + ": " + bonus);
        }
    }
}
