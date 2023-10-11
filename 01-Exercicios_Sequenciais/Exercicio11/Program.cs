namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11 - Escreva um algoritmo para ler o número de eleitores de um município,
            //o número de votos brancos, nulos e válidos. 
            //Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.

            int totalEleitores;
            int votosBrancos;
            int votosNulos;
            int votosValidos;


            Console.WriteLine("Digite o número de eleitores no município: ");
            totalEleitores = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de votos brancos: ");
            votosBrancos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de votos nulos: ");
            votosNulos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de votos válidos: ");
            votosValidos = int.Parse(Console.ReadLine());

            double percentualBrancos = (votosBrancos * 100) / totalEleitores;
            double percentualNulos = (votosNulos * 100) / totalEleitores;
            double percentualValidos = (votosValidos * 100) / totalEleitores;

            Console.WriteLine("Resultados total de eleitores: " + totalEleitores);
            Console.WriteLine("Percentual de votos brancos: " + percentualBrancos);
            Console.WriteLine("Percentual de votos nulos: " + percentualNulos);
            Console.WriteLine("Percentual de votos válidos: " + percentualValidos);
        }
    }
}