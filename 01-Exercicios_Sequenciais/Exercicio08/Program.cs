namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8 - Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
            //A fórmula da conversão é F=(9*C+160)/ 5.

            double c;
            double f;

            Console.WriteLine("Digite a temperatura em Celsius: ");
            c = double.Parse(Console.ReadLine());
            f = (9 * c + 160) / 5;

            Console.WriteLine("A temperatura em Fahrenheit é: " + f);

            Console.ReadKey();
        }
    }
}