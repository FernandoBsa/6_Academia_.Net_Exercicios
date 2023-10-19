namespace Exercicio01
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //1) Fazer uma calculadora das 4 operações (soma, subtração, multiplicação e divisão)
            //Para isso, precisaremos aceitar números com vírgula.
            double a, b;
            Console.WriteLine("Digite dois numeros: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Selecione a operação (+, -, *, /): ");
            char operador = char.Parse(Console.ReadLine());
            switch (operador)
            {
                case '+':
                    Somar(a, b);
                    break;

                case '-':
                    Subtrair(a, b);
                    break;

                case '*':
                    Multiplicar(a, b);
                    break;

                case '/':
                    if (b != 0)
                    {
                        Dividir(a, b);
                    }
                    else
                    {
                        Console.WriteLine("Erro! Divisão por zero não é permitida.");
                        return;
                    }
                    break;

                default:
                    Console.WriteLine("Operação inválida!");
                    return;
            }

        }
        static void Multiplicar(double a, double b)
        {
            double multiplicacao = a * b;
            Console.WriteLine("A multiplicacao dos numeros é: " + multiplicacao);
        }
        static void Somar(double a, double b)
        {
            double soma = a + b;
            Console.WriteLine("A soma dos numero é: " + soma);
        }
        static void Subtrair(double a, double b)
        {
            double subtracao = a - b;
            Console.WriteLine("A subtracao dos numeros é: " + subtracao);
        }
        static void Dividir (double a, double b)
        {
            double divisao = a / b;
            Console.WriteLine("A divisao dos numeros é: " + divisao);
        }
    }
}