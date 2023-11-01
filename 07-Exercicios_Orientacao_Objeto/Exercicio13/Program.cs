namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9 - Crie uma classe chamada Livro que tenha as propriedades Titulo e Autor (outra classe).
            //Utilize o encapsulamento  para garantir que o título e o autor não sejam vazios.

            Autor autor = new Autor { nome = "Autor 1" };
            Livro livro = new Livro { titulo = "Livro 1", Autor = autor };

            Console.WriteLine("Título do Livro: " + livro.titulo);
            Console.WriteLine("Autor: " + livro.Autor.nome);
        }
    }
}