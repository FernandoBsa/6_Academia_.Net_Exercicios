using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;

namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14.Escreva um algoritmo que leia um código numérico inteiro e um vetor de 50 posições de números.
            //Se o código for zero, termine o algoritmo.Se o código for 1, mostre o vetor na ordem em que foi lido.
            //Se o código for 2, mostre o vetor na ordem inversa, do último elemento até o primeiro.

            int tamanho = 50;
            int[] vetor = new int[tamanho];
            int codigo;
            int tamanhoAtual = 0;   

            // Preencha o vetor com valores fornecidos pelo usuário
            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Digite um valor para o vetor na posição " + (i + 1) + " ou digite -1 para sair:");
                int numero = int.Parse(Console.ReadLine());

                if (numero == -1)
                {
                    break; // Sair do loop se -1 for digitado
                }

                vetor[i] = numero;
                tamanhoAtual++;
            }

            Console.WriteLine("Digite o código 0 para sair, 1 para mostrar na ordem, 2 para mostrar na ordem inversa):");
            codigo = int.Parse(Console.ReadLine());

            switch (codigo)
            {
                case 0:
                    Console.WriteLine("Programa encerrado.");
                    break;
                case 1:
                    Console.WriteLine("Vetor na ordem em que foi lido:");
                    for (int i = 0; i < tamanhoAtual; i++)
                    {
                        Console.Write(vetor[i] + " ");
                    }
                    Console.WriteLine(); // Pular linha após a impressão do vetor
                    break;
                case 2:
                    Console.WriteLine("Vetor na ordem inversa:");
                    for (int i = tamanhoAtual - 1; i >= 0; i--)
                    {
                        Console.Write(vetor[i] + " ");
                    }
                    Console.WriteLine(); // Pular linha após a impressão do vetor inverso
                    break;
                default:
                    Console.WriteLine("Código inválido.");
                    break;

            }
        }
    }
}