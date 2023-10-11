namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
            //O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
            //exemplo, A palavra encontra-se na frase ou A palavra não se encontra na frase.

            string frase, palavra;
            bool palavraEncontrada;

            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();

            Console.WriteLine("Digite uma palavra de pesquisa: ");
            palavra = Console.ReadLine();

            palavraEncontrada = frase.Contains(palavra);

            if (palavraEncontrada = true)
            {
                Console.WriteLine("A palavra encontra-se na frase");
            }
            else
            {
                Console.WriteLine("A palavra não se encontra na frase");
            }
        }
    }
}