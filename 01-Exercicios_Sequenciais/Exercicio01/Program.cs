namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.

            int valor1;
            int valor2;
            float total;

            Console.WriteLine("Digite um valor inteiro: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor inteiro: ");
            valor2 = int.Parse(Console.ReadLine());

            total = (valor1 + valor2) / 2;

            Console.WriteLine("A media dos valores e: " + total);
        }
    }
}