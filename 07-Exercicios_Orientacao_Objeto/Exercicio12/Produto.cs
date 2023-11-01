using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    internal class Produto
    {
        private string Nome;
        public Fabricante Fabricante { get; set; }

        private double Preco;

        public string nome
        {
            get { return Nome; }
            set
            {
                if (value != "")
                {
                    Nome = value;
                }
                else
                {
                    Console.WriteLine("O nome do produto não pode ser vazio.");
                }
            }
        }
        public double preco
        {
            get { return Preco; }
            set
            {
                if (value >= 0)
                {
                    Preco = value;
                }
                else
                {
                    Console.WriteLine("O preço do produto deve ser um valor positivo.");
                }
            }
        }
    }
}
