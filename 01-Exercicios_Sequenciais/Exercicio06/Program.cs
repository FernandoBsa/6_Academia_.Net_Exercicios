namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6 - Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
            //isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem 
            //de IPI (única) a ser acrescentada. 

            int codigoA;
            int quantidadeParafusoA;
            float valorParafusoA;
            int porcentagemIpiA;

            Console.WriteLine("Digite o codigo do parafuso A: ");
            codigoA = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quantidade de parafusos A: ");
            quantidadeParafusoA = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor unitario do parafuso A: ");
            valorParafusoA = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a porcentagem do IPI do parafuso A: ");
            porcentagemIpiA = int.Parse(Console.ReadLine());

            int codigoB;
            int quantidadeParafusoB;
            float valorParafusoB;
            int porcentagemIpiB;

            Console.WriteLine("Digite o codigo do parafuso B: ");
            codigoB = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quantidade de parafusos B: ");
            quantidadeParafusoB = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor unitario do parafuso B: ");
            valorParafusoB = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a porcentagem do IPI do parafuso B: ");
            porcentagemIpiB = int.Parse(Console.ReadLine());

            Console.WriteLine("Informacoes do parafuso A: " + "\n Codigo do Parafuso A: " + codigoA + "\n Quatidade de Parafusos A: " + quantidadeParafusoA + "\n Valor Do Parafuso A: " + valorParafusoA + "\n Porcentagem do IPI: " + porcentagemIpiA);

            Console.WriteLine("Informacoes do parafuso B: " + "\n Codigo do Parafuso B: " + codigoB + "\n Quatidade de Parafusos B: " + quantidadeParafusoB + "\n Valor Do Parafuso B: " + valorParafusoB + "\n Porcentagem do IPI: " + porcentagemIpiB);

            Console.ReadKey();
        }
    }
}