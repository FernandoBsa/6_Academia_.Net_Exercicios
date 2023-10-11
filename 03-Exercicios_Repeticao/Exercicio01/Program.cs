﻿namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Escreva um algoritmo para ler um número n, e em seguida ler pelo teclado a idade de n
            //pessoas e calcular a média das idades.

            Console.Write("Digite o número de pessoas (n): ");
            int n = int.Parse(Console.ReadLine());

            int somaIdades = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Digite a idade da pessoa " + i + ": ");
                int idade = int.Parse(Console.ReadLine());
                somaIdades += idade;
            }

            double mediaIdades = (double)somaIdades / n;

            Console.WriteLine("A média das idades é: " + mediaIdades);
        }
    }
}