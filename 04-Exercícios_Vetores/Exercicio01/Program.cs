using System.Threading.Channels;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a quantidade de números pares e ímpares.

            int tamanho = 10;
            int[] v = new int[tamanho];
            int par = 0;
            int impar = 0;

            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine("Digite um valor " + (i + 1) + ":");
                v[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] % 2 == 0)
                {
                    par++;                    
                }
                else
                {
                    impar++;
                }
            }

            Console.WriteLine("Quantidade de numeros pares: " + par);
            Console.WriteLine("Quantidade de numeros impares: " + impar);




        }
    }
}