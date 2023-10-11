namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
            //Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
            //Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
            //E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
            //total de vendas. 

            double codigo, salario, valorTotalVendas;
            string nomeFunc;

            Console.WriteLine("Digite nome: ");
            nomeFunc = Console.ReadLine();

            Console.WriteLine("Digite o codigo de funcionario: ");
            codigo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o salario: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor total das vendas: ");
            valorTotalVendas = double.Parse(Console.ReadLine());

            if (valorTotalVendas > 500.00)
            {
                double bonus = valorTotalVendas * 0.05;
                double salarioTotal = salario + bonus;
                Console.WriteLine("Salario final: " + salarioTotal);
            }
            else if (valorTotalVendas > 1000.00)
            {
                double bonus = valorTotalVendas * 0.07;
                double salarioTotal = salario + bonus;
                Console.WriteLine("Salario final: " + salarioTotal);
            }
            else if (valorTotalVendas > 5000.00)
            {
                double bonus = valorTotalVendas * 0.1;
                double salarioTotal = salario + bonus;
                Console.WriteLine("Salario final: " + salarioTotal);
            }
            else
            {
                Console.WriteLine("Salario final: " + salario);
            }
        }
    }
}