using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Imovel
    {
        public string endereco;
        public double preco;
        public string tipo;

        public Imovel(string endereco, double preco, string tipo)
        {
            this.endereco = endereco;
            this.preco = preco;
            this.tipo = tipo;
        }
    }
}
