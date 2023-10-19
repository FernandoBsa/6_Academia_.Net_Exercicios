using System.Runtime.Intrinsics.X86;

namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 - Escreva uma função chamada TransporMatriz que recebe uma matriz
            //como parâmetro e retorna a matriz transposta.
            int[,] matriz = new int[3, 3];

            Console.WriteLine("Insira os elementos da matriz 3x3: ");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Digite o valor da posição [" + i + "][" + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());                  
                }
            }

            Console.WriteLine();
            Console.WriteLine("Matriz Original");
            Console.WriteLine();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("[" + matriz[i, j] + "]");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            TransporMatriz(matriz);
        }

        static void TransporMatriz(int[,] matriz)
        {
            int[,] transposta = new int[3, 3];
            Console.WriteLine("Matriz Transposta");
            Console.WriteLine();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    transposta[j, i] = matriz[i, j];
                }
            }

            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                for (int i = 0; i < matriz.GetLength(1); i++)
                {
                    Console.Write("[" + matriz[i, j] + "]");
                }
                Console.WriteLine();
            }
        }
    }
}