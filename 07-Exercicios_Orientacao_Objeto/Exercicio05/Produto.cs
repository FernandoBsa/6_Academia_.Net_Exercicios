using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    public class Produto
    {
        public string nome;
        public double preco;
        public int quantidadeEstoque;

        public Produto(string nome, double preco, int quantidadeEstoque)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEstoque = quantidadeEstoque;
        }

        public void Adicionar(int quantidade)
        {
            quantidadeEstoque += quantidade;
        }

        public void Remover(int quantidade)
        {
            if (quantidadeEstoque >= quantidade)
            {
                quantidadeEstoque -= quantidade;
            }
            else
            {
                Console.WriteLine("A quantidade a ser removida é maior do que a quantidade em estoque.");
            }
        }

    }
}
