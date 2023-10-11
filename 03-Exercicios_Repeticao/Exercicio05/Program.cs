namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.Escreva um algoritmo para calcular o fatorial de um número.

            Console.WriteLine("Digite um número para calcular o fatorial: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                int fatorial = 1;

                for (int i = 1; i <= n; i++)
                {
                    fatorial *= i;
                }

                Console.WriteLine("O fatorial de " + n + " é igual a " + fatorial);
            }
            else if (n == 0)
            {
                Console.WriteLine("O fatorial de 0 e igual a 1");
            }
            else
            {
                Console.WriteLine("Nao existe fatorial de numeros negativos");
            }
        }
    }
}