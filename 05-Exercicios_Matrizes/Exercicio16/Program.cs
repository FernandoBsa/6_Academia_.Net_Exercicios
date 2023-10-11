using System.Security.Cryptography;

namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //16) Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3.
            //    Transpor uma matriz significa transformar suas linhas em colunas e vice - versa.

            int[,] matrizO = new int[3, 4];
            int[,] matrizT = new int[4, 3];

            Console.WriteLine("Preencha a primeira matriz 3x4:");
            for (int i = 0; i < matrizO.GetLength(0); i++)
            {
                for (int j = 0; j < matrizO.GetLength(1); j++)
                {
                    Console.Write("Digite o valor da posição [" + i + "][" + j + "]:");
                    matrizO[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < matrizT.GetLength(1); i++)
            {
                for (int j = 0; j < matrizT.GetLength(0); j++)
                {
                    matrizT[j, i] = matrizO[i, j];
                }
            }

            Console.WriteLine();

            Console.WriteLine("Matriz Original 3x4:");
            for (int i = 0; i < matrizO.GetLength(0); i++)
            {
                for (int j = 0; j < matrizO.GetLength(1); j++)
                {
                    Console.Write("[" + matrizO[i, j] + "]");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Matriz transposta 4x3:");
            for (int i = 0; i < matrizT.GetLength(0); i++)
            {
                for (int j = 0; j < matrizT.GetLength(1); j++)
                {
                    Console.Write("[" + matrizT[i, j] + "]");
                }
                Console.WriteLine();
            }
        }
    }
}