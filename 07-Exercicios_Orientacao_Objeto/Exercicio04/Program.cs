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
            livro.exibirInfo();
            livro.Emprestar();
            livro.Devolver();
            livro.exibirInfo();

            //Console.WriteLine("Digite o titulo do segundo livro: ");
            //string tituloLivro2 = Console.ReadLine();

            //Console.WriteLine("Digite o autor do segundo livro: ");
            //string autorLivro2 = Console.ReadLine();

            //Console.WriteLine("Digite o ano de Publicacao do segundo livro: ");
            //int anoPublicacao2 = int.Parse(Console.ReadLine());

            //Livro livro2 = new Livro(tituloLivro2, autorLivro2, anoPublicacao2);
            //livro2.Emprestar();
            //livro2.Devolver();

        }
    }
}