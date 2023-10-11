using System.Reflection;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //4) Popule uma matriz 5x5 e informe:
            //-Quantos números são pares
            //- Quantos números são impares
            //- Quantos números são positivos
            //- Quantos números são negativos
            //- Quantos zeros existem!

            int[,] matriz = new int[5, 5];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Digite o valor da posição [" + i + "][" + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int pares = 0;
            int impares = 0;
            int positivos = 0;
            int negativos = 0;
            int zeros = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int valor = matriz[i, j];

                    if (valor % 2 == 0)
                    {
                        pares++;
                    }
                    else
                    {
                        impares++;
                    }

                    if (valor > 0)
                    {
                        positivos++;
                    }
                    else if (valor < 0)
                    {
                        negativos++;
                    }
                    else
                    {
                        zeros++;
                    }
                }
            }

            Console.WriteLine("Quantidade de números pares: " + pares);
            Console.WriteLine("Quantidade de números ímpares: " + impares);
            Console.WriteLine("Quantidade de números positivos: " + positivos);
            Console.WriteLine("Quantidade de números negativos: " + negativos);
            Console.WriteLine("Quantidade de zeros: " + zeros);
        }
    }
}