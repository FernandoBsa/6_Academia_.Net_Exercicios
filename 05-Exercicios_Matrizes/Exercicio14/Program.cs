using System.Runtime.Intrinsics.Arm;

namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14) Escreva um programa que leia uma matriz de ordem 5 e verifique se os elementos da diagonal principal(da esquerda para a direita)
            //são os mesmos da diagonal
            //secundária(direita pra esquerda).

            int[,] matriz = new int[5, 5];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Digite o valor da posição [" + i + "][" + j + "]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Valores da diagonal principal:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(matriz[i, i]);
            }

            Console.WriteLine("Valores da diagonal secundária:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(matriz[i, 4 - i]);
            }

            bool saoIguais = true;

            for (int i = 0; i < 5; i++)
            {
                if (matriz[i, i] != matriz[i, 4 - i])
                {
                    saoIguais = false;
                    break;
                }
            }

            if (saoIguais)
            {
                Console.WriteLine("Os elementos da diagonal principal são os mesmos da diagonal secundária.");
            }
            else
            {
                Console.WriteLine("Os elementos da diagonal principal não são os mesmos da diagonal secundária.");
            }
        }
    }
}