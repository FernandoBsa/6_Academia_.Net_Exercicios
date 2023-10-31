using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    internal class Produto
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

        public class ListaProdutos
        {
            private List<Produto> listaProdutos;

            public ListaProdutos()
            {
                listaProdutos = new List<Produto>();
            }

            public void AdicionarProdutoNaLista(Produto produto)
            {
                listaProdutos.Add(produto);
            }

            public void ExibirProdutos()
            {
                Console.WriteLine("Lista de Produtos:");
                foreach (var produto in listaProdutos)
                {
                    Console.WriteLine($"Nome: {produto.nome}, Preço: {produto.preco}, Quantidade em Estoque: {produto.quantidadeEstoque}");
                }
            }

            public Produto ConsultarProdutoPorCodigo(int codigo)
            {
                foreach (var produto in listaProdutos)
                {
                    if (listaProdutos.IndexOf(produto) + 1 == codigo)
                    {
                        return produto;
                    }
                }
                return null;
            }
        }
    }
}
