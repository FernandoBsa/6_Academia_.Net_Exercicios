namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. 
            //Mostrar na tela qual dos professores tem o maior salário total.

            double horasAula, valorHora, salario, horasAula2, valorHora2, salario2;

            Console.WriteLine("Quantidade de horas aula do professor 1 : ");
            horasAula = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor por hora aula do professor 1: ");
            valorHora = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade de horas aula do professor 2: ");
            horasAula2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor por hora aula do professor 2: ");
            valorHora2 = double.Parse(Console.ReadLine());

            salario = horasAula * valorHora;

            salario2 = horasAula2 * valorHora2;

            if (salario > salario2)
            {
                Console.WriteLine("O primeiro professor tem o maior salário total.");
            }
            else if (salario2 > salario)
            {
                Console.WriteLine("O segundo professor tem o maior salário total.");
            }
            else
            {
                Console.WriteLine("Ambos os professores têm o mesmo salário total.");
            }
        }
    }
}