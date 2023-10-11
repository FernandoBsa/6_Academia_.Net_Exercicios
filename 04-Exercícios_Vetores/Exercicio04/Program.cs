namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice, 
            //colocando o resultado em um terceiro vetor. Mostre o vetor resultante.


            int tamanho = 10;
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
                resultado[i] = vetor1[i] * vetor2[i];
                Console.WriteLine("Vetor resultado " + (i + 1) + ": " + resultado[i]);
            }
        }
    }
}