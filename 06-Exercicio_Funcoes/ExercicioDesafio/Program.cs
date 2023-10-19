namespace ExercicioDesafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            Console.WriteLine("Digite 10 números inteiros: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Elemento " + (i + 1) + ": ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            EncontrarMenorElemento(vetor);
        }
        static void EncontrarMenorElemento(int[] vetor)
        {
            int menor = vetor[0];
            for (int i = 1; i < vetor.Length; i++)
            {
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                }
            }
            Console.WriteLine("O menor elemento do vetor e: " + menor);
        }
    }
}