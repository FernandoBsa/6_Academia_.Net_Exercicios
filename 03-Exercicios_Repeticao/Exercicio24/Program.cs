namespace Exercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //18.Elaborar um programa que apresente o valor de uma potência de uma base qualquer
            //elevada a um expoente qualquer, ou seja, NM.

            Console.Write("Digite a base (N): ");
            double baseN = double.Parse(Console.ReadLine());

            Console.Write("Digite o expoente (M): ");
            int expoenteM = int.Parse(Console.ReadLine());

            double resultado = 1;

            for (int i = 1; i <= expoenteM; i++)
            {
                resultado *= baseN;
            }

            Console.WriteLine(baseN + "^" + expoenteM + " = " + resultado);
        }
    }
}