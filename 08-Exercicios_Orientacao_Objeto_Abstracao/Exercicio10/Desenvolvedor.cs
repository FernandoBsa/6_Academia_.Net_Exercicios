using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    internal class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string nome, double salario) : base(nome, salario)
        {
        }

        public void MostrarFuncao()
        {
            Console.WriteLine(Nome + " é um desenvolvedor e atua no desenvolvimento de software.");
        }
    }
}
