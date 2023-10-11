namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9.	Escreva um algoritmo que leia os valores para um vetor de 10 elementos,
            //em seguida ordene em ordem crescente os valores desse vetor, utilizando um vetor auxiliar.

            int[] vetor = new int[10] { 10, 7, 3, 6, 9, 1, 2, 5, 8, 4 };
            int aux = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; j < (vetor.Length - 1); j++)
                {
                    if (vetor[j + 1] < vetor[j])
                    {
                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                    }
                }
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Vetor[" + i + "] = " + vetor[i]);
            }



        }
    }
}