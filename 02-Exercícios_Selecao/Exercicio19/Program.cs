namespace Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.

            Console.WriteLine("Digite o primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor: ");
            double valor3 = double.Parse(Console.ReadLine());

            if (valor1 <= valor2 && valor1 <= valor3)
            {
                Console.Write(valor1 + ", ");
                if (valor2 <= valor3)
                {
                    Console.Write(valor2 + ", ");
                    Console.WriteLine(valor3);
                }
                else
                {
                    Console.Write(valor3 + ", ");
                    Console.WriteLine(valor2);
                }
            }
            else if (valor2 <= valor1 && valor2 <= valor3)
            {
                Console.Write(valor2 + ", ");
                if (valor1 <= valor3)
                {
                    Console.Write(valor1 + ", ");
                    Console.WriteLine(valor3);
                }
                else
                {
                    Console.Write(valor3 + ", ");
                    Console.WriteLine(valor1);
                }
            }
            else
            {
                Console.Write(valor3 + ", ");
                if (valor1 <= valor2)
                {
                    Console.Write(valor1 + ", ");
                    Console.WriteLine(valor2);
                }
                else
                {
                    Console.Write(valor2 + ", ");
                    Console.WriteLine(valor1);
                }
            }
        }
    }
}