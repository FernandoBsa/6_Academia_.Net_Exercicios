namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //15) Escreva um programa em C# para ler os valores e somar duas matrizes 4 x 4. Mostrar a matriz resultante.

            int[,] matriz1 = new int[4, 4];
            int[,] matriz2 = new int[4, 4];
            int[,] matrizSoma = new int[4, 4];

            Console.WriteLine("Preencha a primeira matriz 4x4:");
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.Write("Digite o valor da posição [" + i + "][" + j + "]:");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

            Console.WriteLine("Preencha a segunda matriz 4x4:");
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(0); j++)
                {
                    Console.Write("Digite o valor da posição [" + i + "][" + j + "]:");
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < matrizSoma.GetLength(0); i++)
            {
                for (int j = 0; j < matrizSoma.GetLength(0); j++)
                {
                    matrizSoma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            Console.WriteLine();

            Console.WriteLine("Matriz resultante da soma:");
            for (int i = 0; i < matrizSoma.GetLength(0); i++)
            {
                for (int j = 0; j < matrizSoma.GetLength(1); j++)
                {
                    Console.Write("[" + matrizSoma[i, j] + "]");
                }
                Console.WriteLine();
            }
        }
    }
}