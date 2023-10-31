namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10.Escreva um algoritmo que leia um vetor inteiro de 20 posições.Crie um segundo vetor, 
            //substituindo os valores nulos por 2.Mostre os vetores lidos e o vetor resultado.

            int tamanho = 5;
            int[] vetor = new int[tamanho];
            int[] vetorResultado = new int[tamanho];

            for (int i = 0; i < vetor.Length; i++)
            {            
                Console.WriteLine("Digite um valor " + (i + 1) + ":");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < tamanho; i++)
            {
                if (vetor[i] == 0)
                {
                    vetorResultado[i] = 2;
                }
                else
                {
                    vetorResultado[i] = vetor[i];
                }
            }

            Console.WriteLine("Vetor lido:");
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write(vetor[i] + " ");
            }

            Console.WriteLine("Vetor resultado:");
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write(vetorResultado[i] + " ");
            }



        }
    }
}