namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] matrizA = new double[3, 3];
            double[,] matrizResultado = new double[3, 3];

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.Write("Digite o valor da posição [" + i + "][" + j + "]:");
                    matrizA[i, j] = double.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    int somaIndices = i + j;


                    if (somaIndices != 0)
                    {
                        matrizResultado[i, j] = matrizA[i, j] / somaIndices;
                    }
                    else
                    {
                        matrizResultado[i, j] = 0.0;
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine("Matriz Resultado da divisao da matriz A pela Soma dos Índices:");

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.Write("[" + matrizResultado[i, j] + "]");
                }
                Console.WriteLine();
            }
        }
    }
}