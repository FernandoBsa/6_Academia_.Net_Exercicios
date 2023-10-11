namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7) Leia duas matrizes A e B com 3x3 elementos. 
            //   Construir uma matriz C, onde cada elemento de C é a subtração do elemento correspondente de A com B.

            int[,] matrizA = new int[2, 3];
            int[,] matrizB = new int[2, 3];
            int[,] matrizC = new int[2, 3];

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.Write("Digite o valor da posição [" + i + "][" + j + "]:");
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Preencha a segunda matriz:");
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    Console.Write("Digite o valor da posição [" + i + "][" + j + "]:");
                    matrizB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < matrizC.GetLength(0); i++)
            {
                for (int j = 0; j < matrizC.GetLength(1); j++)
                {
                    matrizC[i, j] = matrizA[i, j] - matrizB[i, j];
                }
            }

            Console.WriteLine("Matriz C resultante da subtração da matriz A pela B:");

            for (int i = 0; i < matrizC.GetLength(0); i++)
            {
                for (int j = 0; j < matrizC.GetLength(1); j++)
                {
                    Console.Write("[" + matrizC[i, j] + "]");
                }
                Console.WriteLine();

            }
        }
    }
}