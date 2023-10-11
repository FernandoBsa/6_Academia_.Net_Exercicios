namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5) Leia duas matrizes 2x3 de números double.
            //Imprima a soma destas duas matrizes.

            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[2, 3];
            int[,] matrizSoma = new int[2, 3];

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.Write("Digite o valor da posição [" + i + "]["+ j + "]:" );
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Preencha a segunda matriz:");
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    Console.Write("Digite o valor da posição [" + i + "][" + j + "]:");
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < matrizSoma.GetLength(0); i++)
            {
                for (int j = 0; j < matrizSoma.GetLength(1); j++)
                {
                    matrizSoma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            Console.WriteLine("Matriz resultante da soma das matrizes):");
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