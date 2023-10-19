namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4) Escreva uma função que calcule o fatorial de um número inteiro positivo.
            Console.WriteLine("Digite um número inteiro positivo: ");
            int a = int.Parse(Console.ReadLine());
            CalcularFatorial(a);
        }

        static void CalcularFatorial(int a)
        {
            if (a > 0)
            {
                int fatorial = 1;
                for (int i = 1; i <= a; i++)
                {
                    fatorial *= i;
                }
                Console.WriteLine("O fatorial de " + a + " é igual a " + fatorial);
            }
            else if (a == 0)
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