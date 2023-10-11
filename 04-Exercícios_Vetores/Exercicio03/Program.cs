namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então
            //mostre na tela o índice da posição dos valores correspondentes a números primos.

            int tamanho = 20;
            int[] vetor = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Digite um valor para o vetor na posição " + (i + 1) + ":");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Índices das posições dos valores primos:");

            for (int i = 0; i < tamanho; i++)
            {
                int valor = vetor[i];
                bool primo = true;

                if (valor <= 1)
                {
                    primo = false;
                }
                else
                {
                    for (int j = 2; j * j <= valor; j++)
                    {
                        if (valor % j == 0)
                        {
                            primo = false;
                            break;
                        }
                    }
                }

                if (primo)
                {
                    Console.Write(i + " ");
                }
            }


        }
    }
}