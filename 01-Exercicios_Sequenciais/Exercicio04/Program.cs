namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 - Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na forma AAAAMMDD e AAMMDD.
            // Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.

            Console.WriteLine("Digite a dia(DD): ");
            string dia = Console.ReadLine();

            Console.WriteLine("Digite o mes(MM): ");
            string mes = Console.ReadLine();

            Console.WriteLine("Digite o ano(AAAA): ");
            string ano = Console.ReadLine();

            Console.WriteLine("Data: " + ano + "/" + mes + "/" + dia);
            Console.WriteLine("Data: " + ano.Substring(2) + "/" + mes + "/" + dia);
        }
    }
}