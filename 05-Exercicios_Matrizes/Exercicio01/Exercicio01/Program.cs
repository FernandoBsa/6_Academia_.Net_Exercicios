using System.Net;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Crie uma Matriz 5x3.Na primeira coluna, solicite que o usuário preencha.
            //A 2ª coluna, some 10 aos elementos da 1ª coluna. Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.

            int[,] matriz = new int[5, 3];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write("Digite o valor da " + (i + 1) + "ª linha, 1ª coluna: ");
                matriz[i, 0] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                matriz[i, 1] = matriz[i, 0] + 10;
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                matriz[i, 2] = matriz[i, 0] * 2;
            }

            Console.WriteLine("Matriz Resultante:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + matriz[i, j] + "]");
                }
                Console.WriteLine();
            }

        }
    }
}