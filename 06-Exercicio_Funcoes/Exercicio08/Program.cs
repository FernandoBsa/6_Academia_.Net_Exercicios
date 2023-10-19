namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8) Ler um número inteiro e passar por parâmetro para uma função e 0,
            //se o número é par, ou 1, se o número é ímpar.

            Console.WriteLine("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            VerificarParImpar(numero);
        }

        static void VerificarParImpar(int numero)
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("");
            }
        }

        /*static void Main(string[] args)
        {
            //8) Ler um número inteiro e passar por parâmetro para uma função e 0,
            //se o número é par, ou 1, se o número é ímpar.

            Console.WriteLine("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (VerificaParImpar(numero))
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("1");
            }
        }

        static bool VerificaParImpar(int numero)
        {
            if (numero % 2 == 0)
                return true;
             else
                return false;
        }*/

    }
}