using System.Xml.Linq;

namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //17) Fazer um algoritmo que leia uma matriz de 10 linhas por 10 colunas e escreva o elemento minimax, 
            //ou seja,o menor elemento da linha onde se encontra o
            //maior elemento da matriz.Escreva também a linha e a coluna onde foi encontrado.

            int[,] matriz = new int[10, 10];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Digite o valor da posição [" + i + "][" + j + "]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

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

            for (int j = 0; j < 10; j++)
            {
                if (matriz[linhaMaior, j] < menorElemento)
                {
                    menorElemento = matriz[linhaMaior, j];
                    colunaMenor = j;
                }
            }

            Console.WriteLine("Elemento minimax: " + menorElemento);
            Console.WriteLine("Linha do maior elemento: [" + linhaMaior + "]");
            Console.WriteLine("Coluna do maior elemento: [" + colunaMaior + "]");
            Console.WriteLine("Linha do menor elemento na linha do maior: [" + linhaMaior + "]");
            Console.WriteLine("Coluna do menor elemento na linha do maior: [" + colunaMenor + "]");
        }
    }
}