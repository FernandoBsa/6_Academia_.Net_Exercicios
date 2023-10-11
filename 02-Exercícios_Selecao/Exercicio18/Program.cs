namespace Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.

            Console.WriteLine("Digite o primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor: ");
            double valor3 = double.Parse(Console.ReadLine());

            if (valor1 > valor2 && valor1 > valor3)
            {
                Console.WriteLine("O maior valor é: " + valor1);
            }
            else if (valor2 > valor1 && valor2 > valor3)
            {
                Console.WriteLine("O maior valor é: " + valor2);
            }
            else
            {
                Console.WriteLine("O maior valor é: " + valor3);
            }
        }
    }
}