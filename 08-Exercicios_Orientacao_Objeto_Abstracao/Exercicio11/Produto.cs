using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }
        public Produto(string nome, double preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        public Produto(string nome)
        {
            Nome = nome;
        }

        public Produto(string nome, int estoque) 
        {
            Nome = nome;
            Estoque = estoque;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Preço: R$ " + Preco);
            Console.WriteLine("Estoque: " + Estoque);
        }

    }
}
