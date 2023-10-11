namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Faça um algoritmo que leia 10 números pelo teclado, e que no final mostre o maior deles. Não usar vetor.

            int maiorNumero = 0;

            for (int i = 0; i <= 10; i++)
            {
                Console.Write("Digite o número de " + i + " a 100: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero > maiorNumero)
                {
                    maiorNumero = numero;
                }
            }

            Console.WriteLine("O maior número entre os digitados é: " + maiorNumero);
        }
    }
}