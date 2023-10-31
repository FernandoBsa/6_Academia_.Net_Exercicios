namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Personagem personagem = new Personagem();
            personagem.Atacar(8);
            personagem.Movimentar(1);
        }
    }
}