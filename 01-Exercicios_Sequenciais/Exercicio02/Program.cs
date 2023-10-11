namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 - Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.

            int valor1;
            int valor2;
            int valor3;
            int valor4;
            float media;

            Console.WriteLine("Digite um valor inteiro: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor inteiro: ");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor inteiro: ");
            valor3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor inteiro: ");
            valor4 = int.Parse(Console.ReadLine());

            media = (valor1 + valor2 + valor3 + valor4) / 2;

            Console.WriteLine("A media dos valores e: " + media);
        }
    }
}