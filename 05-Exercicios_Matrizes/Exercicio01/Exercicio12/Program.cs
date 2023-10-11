using System.Runtime.Intrinsics.X86;

namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //12) Escreva um programa que leia os valores de uma matriz 4x3, 
            //e em seguida mostre na tela apenas os valores cuja soma dos índices(i + j) seja um número par.

            int[,] matriz = new int[4, 3];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Digite o valor da posição [" + i + "][" + j + "]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Valores cuja soma dos índices (i + j) é par:");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.WriteLine("matriz[" + i + "][" + j + "] = " + matriz[i, j]);
                    }
                }
            }
        }
    }
}