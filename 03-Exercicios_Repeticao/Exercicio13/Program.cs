using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7.Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa.
            //A cada solicitação, teste se o usuário informou um valor válido. 
            //Por exemplo: se o nome não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
            //informe que ele está incorreto e saia do programa em VS.
            //Se o nome for lido corretamente, solicite a idade.Se ela for incorreta(menor ou igual a zero),
            //informe que está errada e saia.Se estiver correta, solicite o salário.
            //Se ele estiver incorreto(menor ou igual a zero), informe que está incorreto e saia.
            //Se estiver correto, mostre todos os valores lidos.

            string nome;
            int idade;
            double salario;

            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nome) || double.TryParse(nome, out _))
            {
                Console.WriteLine("Nome incorreto.");
                return;
            }

            Console.WriteLine("Digite a idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade <= 0)
            {
                Console.WriteLine("Idade incorreta.");
                return;
            }

            Console.WriteLine("Digite o salário: ");
            salario = double.Parse(Console.ReadLine());

            if (salario <= 0)
            {
                Console.WriteLine("Salário incorreto.");
                return;
            }

            Console.WriteLine("Valores informados:");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Salário: " + salario);

        }
    }
}