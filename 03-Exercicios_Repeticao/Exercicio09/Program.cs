using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja
            //informar um outro número. Caso positivo, o programa em VS deve ser repetido.

            //Exemplo:
            //Digite um número inteiro positivo: 8
            //Numero digitado: 8
            //Números inteiros pares entre 1 e 8: 2, 4, 6.

            //Deseja informar outro número(s/ n)? S

            //Digite um número inteiro positivo: 12
            //Numero digitado: 20
            //Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.

            //Deseja informar outro número(s/ n)? N

            int numero;
            string resposta = "s";

            while (resposta == "s")
            {
                Console.WriteLine("Digite um número inteiro positivo: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    Console.WriteLine("Números pares entre 1 e " + numero + ":");
                    for (int i = 1; i <= numero; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }

                    Console.WriteLine("Deseja informar outro número(s/ n)?");
                    resposta = Console.ReadLine().ToLower();

                    if (resposta == "n") 
                    {
                        Console.WriteLine("Programa encerrado.");
                        Console.ReadKey();
                        break;
                    }                    

                }
                else
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                }
            }

        }
    }
}