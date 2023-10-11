namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8.Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados
            //(informando se ele estiver errado e repetindo a solicja correto). 
            //Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.itação até que este.

            int numero;

            while (true)
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
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                }
            }





        }
    }
}