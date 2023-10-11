using System.Net;

namespace Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13.Elaborar um programa que apresente o somatório dos valores pares existentes
            //entre 1 e 500.

            int soma = 0;

            for (int i = 2; i <= 500; i += 2)
            {
                soma += i;
            }

            Console.WriteLine("O somatório dos valores pares entre 1 e 500 é: " + soma);
        }
    }
}