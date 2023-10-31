namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
            //número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
            //R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento 
            //armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. 
            //No final do processamento, exibir o salário total e o salário excedente do operário.

            double salarioPorHora = 10.0;
            double salarioTotal;
            double salarioExcendete;
            double extra;
            int codigo, numeroHoras;

            Console.WriteLine("Digite o código do operário: ");
            codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de horas trabalhadas: ");
            numeroHoras = int.Parse(Console.ReadLine());

            if (numeroHoras > 50)
            {
                extra = (numeroHoras - 50);
                numeroHoras = 50;
                salarioTotal = salarioPorHora * numeroHoras;
                salarioExcendete = salarioTotal + (extra * 20);
                Console.WriteLine("Salario Total do Operario: " + salarioTotal);
                Console.WriteLine("Salario Total do Operario: " + salarioExcendete);
            }
            else
            {
                salarioTotal = salarioPorHora * numeroHoras;
                Console.WriteLine("Salario Total do Operario: " + salarioTotal);


            }
        }
    }
}