using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;

namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.Em uma cidadezinha do interior há dois candidatos para prefeito(JOAO e ZECA).
            //você foi contratado para fazer um programa em VS que conte os votos dos candidatos.
            //Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos.O mesmo para ZECA. 
            //Você também pode aceitar votos em branco(palavra BRANCO).O programa em VS termina quando o usuário
            //escrever FIM.Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número
            //de votos em branco. 

            int votosJoao = 0;
            int votosZeca = 0;
            int votosBranco = 0;

            Console.WriteLine("Eleição para prefeito (Digite 'FIM' para encerrar):");

            while (true)
            {
                Console.WriteLine("Digite o nome do candidato (JOAO, ZECA ou BRANCO): ");
                string candidato = Console.ReadLine().ToUpper();

                if (candidato == "FIM")
                {
                    break;
                }
                else if (candidato == "JOAO")
                {
                    votosJoao++;
                }
                else if (candidato == "ZECA")
                {
                    votosZeca++;
                }
                else if (candidato == "BRANCO")
                {
                    votosBranco++;
                }
                else
                {
                    Console.WriteLine("Candidato não reconhecido. Tente novamente.");
                }
            }

            Console.WriteLine("Resultado da eleição:");
            Console.WriteLine("JOAO: " + votosJoao + " votos");
            Console.WriteLine("ZECA: " + votosZeca + " votos");
            Console.WriteLine("BRANCO: " + votosBranco + " votos");

        }
    }
}