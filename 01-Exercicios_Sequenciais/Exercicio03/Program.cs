namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 - Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre si os valores de duas variáveis A e B.

            int a = 9;
            int b = 10;

            int tmp = a; // backup do conteudo a

            a = b; // a recebe o conteudo do b
            b = tmp; // o conteudo salvo em tmp vai para b

            Console.WriteLine("Digite uma frase qualquer: ");
            string frase = Console.ReadLine();

            Console.WriteLine("Voce digitou...: " + frase.ToUpper());
            Console.WriteLine("Esta frase tem " + frase.Length + " caracteres.");

            string palavra;
            Console.WriteLine("digite algo para pesquisar: ");
            palavra = Console.ReadLine();

            if (frase.Contains(palavra))
            {
                Console.WriteLine(palavra + " aparece na frase");
            }
            else
            {
                Console.WriteLine(palavra + " nao aparece na frase");
            }
        }
    }
}