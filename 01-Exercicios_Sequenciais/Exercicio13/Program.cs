namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13 - Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
            //preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
            //vendidas pelo vendedor, calcule e mostre: o salário do empregado

            double salarioMinimo;
            double precoCustoBicicleta;
            int numeroBicicletasVendidas;
            double salarioVendedor;
            double valorDeVenda;
            double comissao;

            Console.Write("Informe o valor do salário mínimo: ");
            salarioMinimo = double.Parse(Console.ReadLine());

            Console.Write("Informe o preço de custo de cada bicicleta: ");
            precoCustoBicicleta = double.Parse(Console.ReadLine());

            Console.Write("Informe o número de bicicletas vendidas pelo vendedor: ");
            numeroBicicletasVendidas = int.Parse(Console.ReadLine());

            valorDeVenda = precoCustoBicicleta * 0.5;
            comissao = (valorDeVenda * numeroBicicletasVendidas) * 0.15;
            salarioVendedor = (2 * salarioMinimo) + comissao;

            Console.WriteLine("O salário do empregado é: " + salarioVendedor);
        }
    }
}