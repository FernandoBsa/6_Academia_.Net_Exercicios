namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Crie uma classe Produto com atributos como nome, preço e quantidade em estoque.
            //Implemente um construtor e métodos para adicionar e remover itens do estoque.

            //Produto produto = new Produto("Caneta", 0.70, 10);
            //Produto produto2 = new Produto("grafite", 0.70, 10);
            //Produto produto3 = new Produto("borracha", 0.70, 10);

            Produto produto = new Produto("Caneta", 1.5, 50);
            produto.Adicionar(10);
            Console.WriteLine(produto.nome + ", Valor: " + produto.preco + ", Quantidade em estoque: " + produto.quantidadeEstoque);
        }
    }
}