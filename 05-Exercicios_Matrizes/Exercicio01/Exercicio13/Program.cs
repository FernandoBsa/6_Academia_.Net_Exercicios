using System.Runtime.Intrinsics.Arm;

namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13) Escreva um programa que leia uma matriz de ordem 5(ou seja, 5x5) e
            //verifique se a soma dos elementos da diagonal principal é igual a soma dos elementos da
            //diagonal secundária.

            int[,] matriz = new int[5, 5];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Digite o valor da posição [" + i + "][" + j + "]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int somaDiagonalPrincipal = 0;
            int somaDiagonalSecundaria = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        somaDiagonalPrincipal += matriz[i, j];
                    }

                    if (i + j == 4)
                    {
                        somaDiagonalSecundaria += matriz[i, 4 - i];
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Soma dos elementos da diagonal principal: " + somaDiagonalPrincipal);
            Console.WriteLine("Soma dos elementos da diagonal secundária: " + somaDiagonalSecundaria);

            if (somaDiagonalPrincipal == somaDiagonalSecundaria)
            {
                Console.WriteLine("A soma dos elementos da diagonal principal é igual à soma dos elementos da diagonal secundária.");
            }
            else
            {
                Console.WriteLine("A soma dos elementos da diagonal principal não é igual à soma dos elementos da diagonal secundária.");
            }

        }

    }
}