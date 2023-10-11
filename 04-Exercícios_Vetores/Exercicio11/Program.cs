using System.Runtime.Intrinsics.Arm;

namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11.Escreva um programa que leia valores em um vetor de 5 posições.
            //Escrever os elementos do vetor e após escrever os elementos na ordem inversa.

            int tamanho = 5;
            int[] vetor = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Digite um valor para o vetor na posição " + (i + 1) + ":");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Numeros na ordem de leitura:");
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write(vetor[i] + " ");
            }

            Console.WriteLine("");

            Console.WriteLine("Números na ordem contrária à ordem de leitura:");

            for (int i = tamanho - 1; i >= 0; i--)
            {
                Console.Write(vetor[i] + " ");
            }

        }
    }
}