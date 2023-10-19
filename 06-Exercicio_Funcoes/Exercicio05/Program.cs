using System.Text.RegularExpressions;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5) Desenvolva uma função que converta uma temperatura em graus Celsius para Fahrenheit.
            Console.WriteLine("Conversor de Celsius para Fahrenheit.");
            double c;
            Console.WriteLine("Digite o valor Celsius: ");
            c = double.Parse(Console.ReadLine());
            Conversor(c);
        }

        static void Conversor(double c)
        {
            double f = (9 * c + 160) / 5;       
            Console.WriteLine("A temperatura em Fahrenheit é: " + f);
        }
    }
}