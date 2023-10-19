namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9) Escrever um programa com uma função que receba por parâmetro dois números (n1 e n2) e
            //retorna a soma dos números inteiros que existem entre n1 e n2 (inclusive ambos). Apresente o resultado na main.

            Console.WriteLine("Digite o primeiro numero: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());

            SomarNumerosInteiros(n1, n2);

        }

        static void SomarNumerosInteiros(int n1, int n2)
        {
            int soma = 0;

            for (int i = n1; i <= n2; i++)
            {
                soma += i;
            }
            Console.WriteLine("O resultado da soma é: " + soma);
        }

    }
}