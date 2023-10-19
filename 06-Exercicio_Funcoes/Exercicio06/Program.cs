namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6) Escreva uma função que calcule a média de um vetor de 10 números.
            double[] vetor = new double[10];
            Console.WriteLine("Digite 10 números: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Número " + (i + 1) + ": ");
                vetor[i] = double.Parse(Console.ReadLine());
            }
            CalcularMedia(vetor);
        }

        static void CalcularMedia(double[] vetor)
        {
            double resultado;
            double soma = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }
            resultado = soma / vetor.Length;

            Console.WriteLine("A media do vetor e: " + resultado);
        }
    }
}