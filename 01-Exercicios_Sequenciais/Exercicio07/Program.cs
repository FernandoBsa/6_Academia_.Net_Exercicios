namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7 - Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
            //o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
            //Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.

            int numeroVendedor;
            decimal salario;
            decimal valorTotalDeVendas;
            decimal porcVendas;
            decimal comissao;
            decimal salarioTotal;

            Console.WriteLine("Digite o número do vendedor: ");
            numeroVendedor = int.Parse(Console.ReadLine());

            Console.Write("Digite o salário fixo do vendedor: ");
            salario = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o valor total de vendas efetuadas pelo vendedor: ");
            valorTotalDeVendas = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o percentual que o vendedor ganha sobre o total de vendas (%): ");
            porcVendas = decimal.Parse(Console.ReadLine());

            // Calcula o salário total do vendedor
            comissao = (porcVendas / 100) * valorTotalDeVendas;
            salarioTotal = salario + comissao;

            // Imprime o número do vendedor e o salário total
            Console.WriteLine("Número do vendedor:" + numeroVendedor);
            Console.WriteLine("Salário total do vendedor: " + salarioTotal);
        }
    }
}