namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.	Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.

            int tamanho = 80;
            int[] vetor = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Digite um valor para o vetor na posição " + (i + 1) + ":");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            int menorValor = vetor[0]; 
            int posicaoMenorValor = 0;

            for (int i = 1; i < tamanho; i++)
            {
                if (vetor[i] < menorValor)
                {
                    menorValor = vetor[i];
                    posicaoMenorValor = i;
                }
            }

            Console.WriteLine("Posição do menor elemento: " + posicaoMenorValor);
            Console.WriteLine("Menor elemento: " + menorValor);



        }
    }
}