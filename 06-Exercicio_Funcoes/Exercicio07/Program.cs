namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7) Crie uma função que determine se um número é primo ou não.

            Console.WriteLine("Digite um numero para verificar se ele é primo: ");
            int a = int.Parse(Console.ReadLine());
            VerificarPrimo(a);

        }
        private static void VerificarPrimo(int a)
        {
            if (a % 2 == 0) 
            {
                Console.WriteLine("O numero nao é Primo.");
            }           
            else
            {
                Console.WriteLine("O numero é Primo.");
            }
        }
    }
}