namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6.Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura.Exemplo:
            //a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
            //b.escreve: 	| 22 | 7 | 31 | 63 | 0 | 21 | 9 | 3 | 40 | 7 |

            int tamanho = 10;
            int[] vetor = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Digite um valor para o vetor na posição " + (i + 1) + ":");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Números na ordem contrária à ordem de leitura:");

            for (int i = tamanho - 1; i >= 0; i--)
            {
                Console.Write(vetor[i] + " ");
            }
        }
    }
}