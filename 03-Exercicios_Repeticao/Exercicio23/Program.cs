using System.Net;

namespace Exercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //17.Apresentar os quadrados dos números inteiros de 15 a 200.

            Console.WriteLine("Quadrados dos números inteiros de 15 a 200: ");

            for (int i = 15; i <= 200; i++)
            {
                int quadrado = i * i;
                Console.WriteLine(i + "² = " + quadrado);
            }
        }
    }
}