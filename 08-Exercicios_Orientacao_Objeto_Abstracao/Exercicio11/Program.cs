namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11 -
            //a) Crie uma classe "Produto" com propriedades como "Nome," "Preço" e "Estoque."
            //b) Implemente construtores sobrecarregados que permitam criar instâncias de produtos de diferentes maneiras, como especificando apenas o nome ou especificando todas as propriedades.

            Produto produto1 = new Produto("Camiseta", 29.99, 10);
            Produto produto2 = new Produto("Caneca");
            Produto produto3 = new Produto("Caneta", 20);

            Console.WriteLine("Detalhes do Produto 1:");
            produto1.ExibirDetalhes();

            Console.WriteLine("\nDetalhes do Produto 2:");
            produto2.ExibirDetalhes();

            Console.WriteLine("\nDetalhes do Produto 3:");
            produto3.ExibirDetalhes();

        }
    }
}