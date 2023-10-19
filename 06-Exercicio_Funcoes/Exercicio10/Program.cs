namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Na teoria dos Sistemas, define-se como elemento minimax de uma matriz,
            //o menor elemento da linha em que se encontra o maior elemento da matriz.
            //Escreva um programa que lê uma matriz [10 X 10] e em uma função encontre e
            //mostre o elemento minimax e sua posição na matriz.

            int[,] matriz = new int[10, 10];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Digite o valor da posição [" + i + "][" + j + "]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            EncontrarMinimax(matriz);
        }

        static void EncontrarMinimax(int[,] matriz)
        {
            int maiorElemento = matriz[0, 0];
            int linhaMaior = 0;
            int colunaMaior = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] > maiorElemento)
                    {
                        maiorElemento = matriz[i, j];
                        linhaMaior = i;
                        colunaMaior = j;
                    }
                }
            }

            int menorElemento = matriz[linhaMaior, 0];
            int colunaMenor = 0;

            for (int j = 0; j < matriz.GetLength(0); j++)
            {
                if (matriz[linhaMaior, j] < menorElemento)
                {
                    menorElemento = matriz[linhaMaior, j];
                    colunaMenor = j;
                }
            }

            Console.WriteLine("O elemento minimax da matriz é: " + menorElemento);
            Console.WriteLine("Sua posicao na matriz: [" + linhaMaior + "][" +colunaMenor + "]");
        }
    }
}