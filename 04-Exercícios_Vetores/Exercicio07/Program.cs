namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7.Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e escreva primeiramente 
            //    todos os números pares lidos e após todos os ímpares. Exemplo:
            //a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
            //b.escreve: 	| 40 | 0 | 22 | 7 | 3 | 9 | 21 | 63 | 31 | 7 |

            int tamanho = 10;
            int[] vetor = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Digite um valor para o vetor na posição " + (i + 1) + ":");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Números pares seguidos pelos números ímpares:");

            for (int i = 0; i < tamanho; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.WriteLine(vetor[i]);
                }
            }

            for (int i = 0; i < tamanho; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
        }
    }
}