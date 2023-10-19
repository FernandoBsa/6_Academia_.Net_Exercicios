namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6 - Escreva uma função chamada MediaColunaMatriz que recebe uma matriz e um número de coluna como parâmetros,
            //e retorna a soma dos elementos nessa coluna.

            Console.WriteLine("Insira o número de linhas da matriz:");
            int linhas = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o número de colunas da matriz:");
            int colunas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linhas, colunas];

            Console.WriteLine();

            Console.WriteLine("Digite os elementos da matriz.");
            LerMatriz(matriz);

            Console.WriteLine();

            Console.WriteLine("Insira o número da coluna que deseja calcular a média:");
            int numColuna = int.Parse(Console.ReadLine());

            Console.WriteLine();

            MediaColunaMatriz(matriz, numColuna);

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
        static void MediaColunaMatriz(int[,] matriz, int numColuna)
        {
            int soma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                soma += matriz[i, numColuna];
            }
            Console.WriteLine("Soma do elementos da coluna: " + soma);
        }
    }
}