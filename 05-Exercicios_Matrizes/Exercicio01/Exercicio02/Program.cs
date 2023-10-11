namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2) Solicite ao usuário, preencher uma Matriz 3x3

            //Informe ao usuário:
            //*A soma dos elementos de cada linha

            //    -Ex: Linha 1: 30

            //         Linha 2: 17
            //* A soma dos elementos de cada coluna

            //    -Ex: Coluna 1: 23

            //         Coluna 2: 36

            int[,] matriz = new int[3, 3];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Digite o valor da posição [" + i + "][" + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int somaLinha = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    somaLinha += matriz[i, j];
                }
                Console.WriteLine("Soma dos elementos da Linha [" + i + "]:" + somaLinha);
            }

            Console.WriteLine();

            for (int j = 0; j < matriz.GetLength(0); j++)
            {
                int somaColuna = 0;
                for (int i = 0; i < matriz.GetLength(1); i++)
                {
                    somaColuna += matriz[i, j];
                }
                Console.WriteLine("Soma dos elementos da Coluna [" + j + "]:" + somaColuna);
            }

        }
    }
}