namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13 - Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
            //seu peso ideal, utilizando as seguintes fórmulas:
            //Para homens: (72.7 * h) - 58
            //Para mulheres: (62.1 * h) - 44.7

            double altura, pesoIdeal;
            string sexo;

            Console.WriteLine("Digite seu sexo: ");
            sexo = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite sua altura");
            altura = double.Parse(Console.ReadLine());

            if (sexo == "MASCULINO")
            {
                pesoIdeal = (72.7 * altura) - 58;
                Console.WriteLine("Seu peso ideal e: " + pesoIdeal);
            }
            else
            {
                pesoIdeal = (62.1 * altura) - 44.7;
                Console.WriteLine("Seu peso ideal e: " + pesoIdeal);
            }
        }
    }
}