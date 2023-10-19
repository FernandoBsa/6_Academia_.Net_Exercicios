namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 - Crie uma função chamada SomaDiagonalPrincipal que recebe uma matriz
            //quadrada como parâmetro e retorna a soma dos elementos na diagonal principal.

            int[,] matriz = new int[2,2];

            Console.WriteLine("Digite os elementos da primeira matriz.");
            LerMatriz(matriz);
            Console.WriteLine();

            SomaDiagonalPrincipal(matriz);
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
        static void SomaDiagonalPrincipal(int[,] matriz)
        {
            int soma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                soma += matriz[i, i];
            }
            Console.WriteLine("Soma dos elementos da diagonal princial: " + soma);
        }
    }
}