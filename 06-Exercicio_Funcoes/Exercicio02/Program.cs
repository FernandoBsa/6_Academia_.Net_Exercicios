namespace Exercicio02
{
    internal class Program
    {
        static int[] vetor = new int[10];
        static void Main(string[] args)
        {
            //2) Fazer programa que tenha duas funções. i) para ler um vetor de 10 elementos (variável global) e ii)
            //para verificar e apresentar a quantidade de elementos pares que este vetor possui.
            LerVetor();
            verificarPares();
        }

        static void LerVetor()
        {
            Console.WriteLine("Digite 10 números inteiros: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Elemento " + (i + 1) + ":");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }

        static void verificarPares()
        {
            int pares = 0;
            Console.Write("Os elementos pares são: ");
            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.Write(vetor[i] + " ");
                    pares++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Quantidade de numeros pares: " + pares);
        }
    }
}