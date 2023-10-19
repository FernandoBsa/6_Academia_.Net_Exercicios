namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3) Desenvolva uma função que calcule a média de três números fornecidos como argumentos.

            double a, b , c;
            Console.WriteLine("Digite tres numeros para receber a media: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            Media(a, b, c);
        }
        static void Media (double a, double b, double c)
        {
            double media = (a + b + c) / 3;
            Console.WriteLine("A media dos valores é:" + media);
        } 
    }
}