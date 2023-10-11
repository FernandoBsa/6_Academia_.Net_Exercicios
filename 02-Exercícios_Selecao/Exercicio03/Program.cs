namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os que são superiores à média.

            double valor1, valor2, valor3, valor4, media;

            Console.WriteLine("Digite o numero 1: ");
            valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero 2: ");
            valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero 3: ");
            valor3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero 4: ");
            valor4 = double.Parse(Console.ReadLine());

            media = (valor1 + valor2 + valor3 + valor4) / 4;
            Console.WriteLine("Sua media e: " + media);

            if (valor1 > media)
            {
                Console.WriteLine(valor1 + " maior que a media.");
            }
            if (valor2 > media)
            {
                Console.WriteLine(valor2 + " maior que a media.");
            }
            if (valor3 > media)
            {
                Console.WriteLine(valor3 + " maior que a media.");
            }
            if (valor4 > media)
            {
                Console.WriteLine(valor4 + " maior que a media.");
            }
            else
            {
                Console.WriteLine("Nenhum valor maior que a media");
            }
        }
    }
}