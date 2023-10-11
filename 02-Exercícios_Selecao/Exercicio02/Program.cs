namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 

            int numero;

            Console.WriteLine("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
            }
        }
    }
}