namespace Exercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //16.Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da
            //multiplicação sucessiva de N por 3 enquanto o produto for menor que 250
            //(N * 3; N * 3 * 3; N * 3 * 3 * 3; etc).

            Console.WriteLine("Digite um número N menor ou igual a 50: ");
            int N = int.Parse(Console.ReadLine());

            int produto = N;
            int contador = 1;
            int resultado = produto * 3;

            Console.WriteLine(produto + "*3 = " + resultado);

            while (produto * 3 < 250)
            {
                produto *= 3;
                contador++;
                Console.WriteLine(produto + "*3 = " + produto);
            }
        }
    }
}