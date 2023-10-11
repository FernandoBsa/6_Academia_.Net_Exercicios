using System.Net;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a soma dos elementos da mesma posição, 
            //armazenando o resultado em um outro vetor.

            int tamanho = 20;
            int[] vetor1 = new int[tamanho];
            int[] vetor2 = new int[tamanho];
            int[] resultado = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Digite um valor para o vetor1 na posição " + (i + 1) + ":");
                vetor1[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite um valor para o vetor2 na posição " + (i + 1) + ":");
                vetor2[i] = int.Parse(Console.ReadLine());
            }
          
            for (int i = 0; i < tamanho; i++)
            {
                resultado[i] = vetor1[i] + vetor2[i];
                Console.WriteLine("Vetor resultado " + (i + 1) + ": " + resultado[i]);
            }

        }
    }
}