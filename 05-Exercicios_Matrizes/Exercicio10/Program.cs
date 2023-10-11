using System.Net;

namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10) Leia duas matrizes A e B de 4x4 elementos,
            //calcule a média dos mesmos, 
            //em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.

            int[,] matrizA = new int[4, 4];
            int[,] matrizB = new int[4, 4];
            int totalElementos = 4 * 4;
            int somaTotal = 0;

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

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    somaTotal += matrizA[i, j] + matrizB[i, j];
                }
            }

            double media = (double)somaTotal / (totalElementos * 2);

            Console.WriteLine("A média dos elementos das matrizes A e B é: " + media);

            int abaixoDaMedia = 0;
            int acimaDaMedia = 0;
            int naMedia = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int elemento = matrizA[i, j];
                    if (elemento < media)
                    {
                        abaixoDaMedia++;
                    }
                    else if (elemento > media)
                    {
                        acimaDaMedia++;
                    }
                    else
                    {
                        naMedia++;
                    }

                    elemento = matrizB[i, j];
                    if (elemento < media)
                    {
                        abaixoDaMedia++;
                    }
                    else if (elemento > media)
                    {
                        acimaDaMedia++;
                    }
                    else
                    {
                        naMedia++;
                    }
                }
            }

            Console.WriteLine("Elementos abaixo da média: " + abaixoDaMedia);
            Console.WriteLine($"Elementos acima da média: " + acimaDaMedia);
            Console.WriteLine($"Elementos na média: " + naMedia);
        }
    }
}