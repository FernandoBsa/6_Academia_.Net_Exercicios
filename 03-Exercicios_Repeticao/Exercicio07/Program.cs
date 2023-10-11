namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7.Escreva um programa em C# leia 20 números e que conte a quantidade de números pares e ímpares digitados por 
            //um usuário. Apresente o resultado.

            int numerosPares = 0;
            int numerosImpares = 0;

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Digite o número " + i + ": ");
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    numerosPares++;
                }
                else
                {
                    numerosImpares++;
                }
            }

            Console.WriteLine("Quantidade de números pares: " + numerosPares);
            Console.WriteLine("Quantidade de números ímpares: " + numerosImpares);
        }
    }
}