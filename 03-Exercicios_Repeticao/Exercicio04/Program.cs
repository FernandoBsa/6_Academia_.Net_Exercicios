namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x
            //elevado na y sem utilizar a função pow.

            Console.WriteLine("Digite o valor de x: ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de y: ");
            double y = double.Parse(Console.ReadLine());

            double resultado = 1;

            for (int i = 1; i <= y; i++)
            {
                resultado *= x;
            }

            Console.WriteLine(x + " elevado a " + y + " é igual a " + resultado);
        }
    }
}