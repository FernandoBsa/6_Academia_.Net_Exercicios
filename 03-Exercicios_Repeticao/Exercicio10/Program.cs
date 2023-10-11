namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.Fazer um laço(repetição) que fique solicitando números ao usuário. 
            //Se o usuário digitar 0 o programa em VS deve parar. 
            //Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.
      
            while (true)
            {
                Console.Write("Digite um número ou digite 0 para fechar o programa: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    Console.WriteLine("Programa encerrado.");
                    break;
                }
                else if (numero % 2 == 0)
                {
                    Console.WriteLine(numero + "é par.");
                }
                else
                {
                    Console.WriteLine(numero + " é ímpar.");               
                }

                if (primo(numero))
                {
                    Console.WriteLine(numero + " é um número primo.");
                }
                else
                {
                    Console.WriteLine(numero + " não é um número primo.");
                }
            }

            static bool primo(int numero)
            {
                if (numero <= 1)
                {
                    return false;
                }
                for (int i = 2; i * i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

        }
    }
}