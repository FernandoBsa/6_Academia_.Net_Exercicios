namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 - Escreva uma função chamada MultiplicarMatrizes que recebe duas matrizes
            //como parâmetros e retorna a matriz resultante da multiplicação.

            int[,] matriz1 = new int[2, 2];
            int[,] matriz2 = new int[2, 2];
            int[,] matrizResultado = new int[2, 2];

            Console.WriteLine("Digite os elementos da primeira matriz.");
            LerMatriz(matriz1);
            Console.WriteLine();

            Console.WriteLine("Digite os elementos da segunda matriz.");
            LerMatriz(matriz2);
            Console.WriteLine();

            MultiplicarMatrizes(matriz1, matriz2, matrizResultado);
            Console.WriteLine("Matriz Resultado: ");
            ImprimirMatriz(matrizResultado);

        }
        static void LerMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Digite o valor da posição [" + i + "][" + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void ImprimirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("[" + matriz[i, j] + "]");
                }
                Console.WriteLine();
            }
        }
        static void MultiplicarMatrizes(int[,] matriz1, int[,] matriz2, int[,] matrizResultado)
        {
            for (int i = 0; i < matrizResultado.GetLength(0); i++)
            {
                for (int j = 0; j < matrizResultado.GetLength(0); j++)
                {
                    matrizResultado[i, j] = matriz1[i, j] * matriz2[i, j];
                }
            }
        }
    }
}