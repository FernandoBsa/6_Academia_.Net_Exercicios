namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola sejam bem vindos ao sistema da biblioteca!");

            Console.WriteLine("Digite o titulo do primeiro livro: ");
            string tituloLivro = Console.ReadLine();

            Console.WriteLine("Digite o autor do primeiro livro: ");
            string autorLivro = Console.ReadLine();

            Console.WriteLine("Digite o ano de Publicacao do primeiro livro: ");
            int anoPublicacao = int.Parse(Console.ReadLine());

            Livro livro = new Livro(tituloLivro, autorLivro, anoPublicacao);
            livro.exibirInformacao();
            livro.Emprestar();
            livro.Devolver();
            livro.exibirInformacao();

        }
    }
}