namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10 - Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
            //para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
            //realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
            //notas de menor valor fossem distribuídas em número mínimo possível. 
            //Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00,
            //uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
            //Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
            //de acordo com o critério da “distribuição ótima”.


            Console.WriteLine("Digite o valor que deseja retirar: R$");
            int valor = int.Parse(Console.ReadLine());
            int n200 = 0, n100 = 0, n50 = 0, n20 = 0, n10 = 0, n5 = 0, n2 = 0, n1 = 0;

            n100 = valor / 100;
            valor = valor - (n100 * 100);
            Console.WriteLine("Notas de 100: " + n100);

            n50 = valor / 50;
            valor = valor - (n50 * 50);
            Console.WriteLine("Notas de 50: " + n50);

            n20 = valor / 20;
            valor = valor - (n20 * 20);
            Console.WriteLine("Notas de 20: " + n20);

            n10 = valor / 10;
            valor = valor - (n10 * 10);
            Console.WriteLine("Notas de 10: " + n10);

            n5 = valor / 5;
            valor = valor - (n5 * 5);
            Console.WriteLine("Notas de 5: " + n5);

            n2 = valor / 2;
            valor = valor - (n2 * 2);
            Console.WriteLine("Notas de 2: " + n2);

            n1 = valor / 1;
            valor = valor - (n1 * 1);
            Console.WriteLine("Notas de 1: " + n1);
        }
    }
}