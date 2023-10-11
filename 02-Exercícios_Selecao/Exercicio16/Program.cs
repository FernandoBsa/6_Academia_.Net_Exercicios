namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
            //na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. Caso contrário, mostre uma mensagem indicando que os dois times irão se
            //enfrentar novamente em um novo jogo.
            //ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
            //ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
            //plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.

            int timeCasa, timeCasa2, timeFora, timeFora2;

            Console.WriteLine("Digite o placar do primeiro jogo do time de casa: ");
            timeCasa = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o placar do primeiro jogo do time de fora: ");
            timeFora = int.Parse(Console.ReadLine());

            if (timeFora > timeCasa + 2)
            {
                Console.WriteLine("O time de fora já se classificou para a próxima fase.");
            }
            else
            {
                Console.WriteLine("Os dois times se enfrentarão em um novo jogo.");
            }

            Console.WriteLine("Digite o placar do primeiro jogo do time de casa: ");
            timeCasa2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o placar do primeiro jogo do time de fora: ");
            timeFora2 = int.Parse(Console.ReadLine());

            if (timeFora + timeFora2 > timeCasa + timeCasa2)
            {
                Console.WriteLine("O time de fora passou de fase.");
            }
            else
            {
                Console.WriteLine("O time da casa passou de fase.");
            }
        }
    }
}