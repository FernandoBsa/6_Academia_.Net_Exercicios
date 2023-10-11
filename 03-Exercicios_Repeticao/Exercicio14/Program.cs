namespace Exercicio14
{
    internal class Program
    {
        static void Main()
        {
            //8.Faça um programa em VS que solicite um numero inteiro.S
            //e o numero não for inteiro, solicite - o até que seja.após, informe se ele é par ou impar.
            //Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.

            while (true)
            {
                int numero;

                while (true)
                {
                    Console.Write("Digite um número inteiro: ");

                    if (int.TryParse(Console.ReadLine(), out numero))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Número não é inteiro. Tente novamente.");
                    }
                }

                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero + " é par.");
                }
                else
                {
                    Console.WriteLine(numero + " é ímpar.");
                }

                Console.Write("Deseja repetir o programa? (S/N): ");
                string resposta = Console.ReadLine().ToLower();

                if (resposta == "n")
                {
                    Console.WriteLine("Programa encerrado!");
                    break; 
                }
            }
        }
    }

}
