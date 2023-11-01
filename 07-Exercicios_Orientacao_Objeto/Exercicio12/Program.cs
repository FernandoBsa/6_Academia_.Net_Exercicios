using System;

namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8 - Crie classes chamadas Fabricante e Produto.Fabricante que tenha as propriedades Nome, Endereço e Cidade.
            //Produto que tenha as propriedades Nome, Fabricante(objeto da classe Fabricante) e Preco.
            //Utilize o encapsulamento para garantir que o nome não seja vazio e que o preço seja positivo.

            Fabricante fabricante = new Fabricante { nome = "Fernando", Endereco = "Rua barao, 115", Cidade = "Petrolina" };

            Produto produto = new Produto { nome = "Placa de Video", Fabricante = fabricante, preco = 20.5 };

            Console.WriteLine("Nome do Produto: " + produto.nome);
            Console.WriteLine("Fabricante: " + produto.Fabricante.nome);
            Console.WriteLine("Endereço do Fabricante: " + produto.Fabricante.Endereco);
            Console.WriteLine("Cidade do Fabricante: " + produto.Fabricante.Cidade);
            Console.WriteLine("Preço: R$" + produto.preco);

        }
    }
}