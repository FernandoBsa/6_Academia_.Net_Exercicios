namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //15 - Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados 
            //da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados 
            //e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. 
            //Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.

            double areaParaPintar, litrosNecessarios, latasNecessarias, precoTotal;

            Console.Write("Digite o tamanho da área a ser pintada (em metros quadrados): ");
            areaParaPintar = double.Parse((Console.ReadLine()));

            //Calcula a quantidade de tinta necessária em litros
            litrosNecessarios = areaParaPintar / 3.0;

            //Calcula a quantidade de latas de tinta necessárias
            latasNecessarias = Math.Ceiling(litrosNecessarios / 18.0);

            //Calcula o preço total das latas de tinta
            precoTotal = latasNecessarias * 80.0;

            Console.WriteLine("Quantidade de latas de tinta necessárias: " + latasNecessarias);
            Console.WriteLine("Preço total: R$" + precoTotal);

        }
    }
}