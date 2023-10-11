namespace Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14.Mostrar as potências de 2 variando de 0 a 10.

            Console.WriteLine("Potências de 2 variando de 0 a 10:");

            for (int i = 0; i <= 10; i++)
            {
                double resultado = Math.Pow(2, i);
                Console.WriteLine("2^" + i + " = " + resultado);
            }
        }
    }
}