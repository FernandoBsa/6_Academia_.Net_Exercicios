using System.Runtime.Intrinsics.X86;
using static Exercicio10.Produto;

namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6 - Utilize o exercício 5 para criar uma lista de produtos e faça métodos para apresentar na tela e para consultar produtos pelo código.

            ListaProdutos listaProdutos = new ListaProdutos();

            Produto p1 = new Produto("Coca-Cola", 9, 20);
            Produto p2 = new Produto("Guarana", 8, 15);
            Produto p3 = new Produto("Fanta", 8, 30);

            listaProdutos.AdicionarProdutoNaLista(p1);
            listaProdutos.AdicionarProdutoNaLista(p2);
            listaProdutos.AdicionarProdutoNaLista(p3);

            listaProdutos.ExibirProdutos();


            Console.WriteLine("Digite o codigo do produto: ");
            int codigoConsulta = int.Parse(Console.ReadLine());
            Produto produtoConsultado = listaProdutos.ConsultarProdutoPorCodigo(codigoConsulta);
            if (produtoConsultado != null)
            {
                Console.WriteLine($"Produto com código {codigoConsulta}: Nome: {produtoConsultado.nome}, Preço: {produtoConsultado.preco}, Quantidade em Estoque: {produtoConsultado.quantidadeEstoque}");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }
    }
}