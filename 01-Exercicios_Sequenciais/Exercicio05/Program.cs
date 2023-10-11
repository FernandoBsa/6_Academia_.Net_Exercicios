namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 - Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
            //(medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
            //consumido para percorrê-la (medido em l).

            int distancia;
            int litros;
            int media;

            Console.WriteLine("Digite a distancia percorrida: ");
            distancia = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o volume de combustivel consumido: ");
            litros = int.Parse(Console.ReadLine());

            media = distancia / litros;

            Console.WriteLine("A media de consumo do automovel foi: " + media);
        }
    }
}