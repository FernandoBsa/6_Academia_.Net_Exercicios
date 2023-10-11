using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //15.Faça um programa em C# que declare um vetor de 20 elementos inteiros, leia os conteúdos do vetor, 
            //   e copie estes conteúdos para outro vetor, invertendo sua ordem.Assim, 
            //   o valor do primeiro elemento do primeiro vetor deve ser o valor do último elemento do segundo vetor, por exemplo.
            //   Mostrar os conteúdos do primeiro vetor em uma linha e os do segundo uma linha abaixo.

            int tamanho = 20;
            int[] vetor = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Digite um valor para o vetor na posição " + (i + 1) + ":");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Números na ordem original de leitura:");

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write(vetor[i] + " ");
            }

            Console.WriteLine(" ");

            Console.WriteLine("Números na ordem contrária:");

            for (int i = tamanho - 1; i >= 0; i--)
            {
                Console.Write(vetor[i] + " ");
            }

        }
    }
}