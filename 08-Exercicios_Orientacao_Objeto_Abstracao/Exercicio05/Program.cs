namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////5 - Crie uma classe abstrata "Produto" com propriedades para "Nome", "Preço" e um método abstrato "CalcularDesconto".
            ////Crie classes derivadas para diferentes tipos de produtos, como "Livro" e "Eletrônico", que implementam o método "CalcularDesconto"
            ////de acordo com as regras específicas de desconto para cada tipo de produto.
            //Livro – 5 % de desconto
            //Eletrônico - 12.5 % de desconto

            Livro livro = new Livro { Nome = "Dom Casmurro", Preco = 50 };
            Eletronico eletronico = new Eletronico { Nome = "Smartphone", Preco = 1000 };

            Console.WriteLine("Desconto do livro " + livro.Nome + ": " + livro.CalcularDesconto());
            Console.WriteLine($"Desconto do eletrônico " + eletronico.Nome + ": " + eletronico.CalcularDesconto());
        }
    }
}