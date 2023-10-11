namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. Para que os lados
            //formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos
            //os lados iguais), isoceles(somente 2 lados são iguais) ou escaleno(os 3 lados são diferentes).

            double a, b, c;

            Console.WriteLine("Digite o valor do lado a: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado b: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado c: ");
            c = double.Parse(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine("Os lados formam um triângulo equilátero.");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Os lados formam um triângulo isósceles.");
            }
            else if (a != b && b != c)
            {
                Console.WriteLine("Os lados formam um triângulo escaleno.");
            }
            else
            {
                Console.WriteLine("Os lados não podem formar um triângulo.");
            }
        }
    }
}