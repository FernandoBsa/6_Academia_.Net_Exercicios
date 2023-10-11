using System.Reflection;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!

            int[,] matriz = new int[4, 4];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Digite o valor da posição [" + i + "][" + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Elementos da Diagonal Principal:");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(matriz[i, i]);
            }

        }
    }
}