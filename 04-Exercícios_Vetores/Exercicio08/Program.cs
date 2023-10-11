using System.Runtime.Intrinsics.X86;

namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8.Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após 
            //    escreva a posição de cada número menor que zero desse vetor. Exemplo:
            //a.lê:          	| 5.1 | 0 | -3.6 | 4.1 | -2.5 | -1.3 | -4 | 1.39 | -128 | -6.9 | 8.2 | 9 | 154 | -88 | 6.4 | 7.1 | ...|
            //b.escreve: 	| 3 | 5 | 6 | 7 | 9 | 10 | 14 |. . .

            int tamanho = 3;
            double[] vetor = new double[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Digite um número real para o vetor na posição " + (i + 1) + ":");
                vetor[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Posição dos números menores que zero:");

            for (int i = 0; i < tamanho; i++)
            {
                if (vetor[i] < 0)
                {
                    Console.WriteLine(i + 1);
                }
            }
        }
    }
}