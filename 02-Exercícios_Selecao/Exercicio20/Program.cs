namespace Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
            //plus: você pode gerar o número de forma randomica (função random c#).

            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            int tentativa = 1;

            Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
            Console.WriteLine("Tente adivinhar o número secreto entre 1 e 100.");

            Console.WriteLine("Digite o seu primeiro palpite: ");
            int palpite1 = int.Parse(Console.ReadLine());

            if (palpite1 == numeroSecreto)
            {
                Console.WriteLine("Parabéns! Você acertou o número secreto.");
            }
            else if (palpite1 < numeroSecreto)
            {
                Console.WriteLine("O número secreto é maior.");
            }
            else
            {
                Console.WriteLine("O número secreto é menor.");
            }

            if (palpite1 != numeroSecreto)
            {
                tentativa++;

                Console.WriteLine("Digite o seu segundo palpite: ");
                int palpite2 = int.Parse(Console.ReadLine());

                if (palpite2 == numeroSecreto)
                {
                    Console.WriteLine("Parabéns! Você acertou o número secreto.");
                }
                else if (palpite2 < numeroSecreto)
                {
                    Console.WriteLine("O número secreto é maior.");
                }
                else
                {
                    Console.WriteLine("O número secreto é menor.");
                }

                if (palpite2 != numeroSecreto)
                {
                    tentativa++;

                    Console.WriteLine("Digite o seu terceiro palpite: ");
                    int palpite3 = int.Parse(Console.ReadLine());

                    if (palpite3 == numeroSecreto)
                    {
                        Console.WriteLine("Parabéns! Você acertou o número secreto.");
                    }
                    else
                    {
                        Console.WriteLine("Suas tentativas acabaram. O número secreto era: " + numeroSecreto);
                    }
                }
            }
        }
    }
}