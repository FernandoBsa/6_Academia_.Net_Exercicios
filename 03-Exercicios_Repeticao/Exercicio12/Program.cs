namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.Modifique o programa em VS anterior para aceitar votos nulos
            //(qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
            //Ao final, informe o nome do candidato vencedor, o número de votos nulos
            //e o número de pessoas que votaram.

            int votosJoao = 0;
            int votosZeca = 0;
            int votosBranco = 0;
            int votosNulos = 0;

            Console.WriteLine("Eleição para prefeito (Digite 'FIM' para encerrar):");

            while (true)
            {
                Console.WriteLine("Digite o nome do candidato (JOAO, ZECA ou BRANCO), qualquer nome diferente sera considerado nulo: ");
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
                    votosNulos++;
                }
            }

            Console.WriteLine("Resultado da eleição:");
            Console.WriteLine("JOAO: " + votosJoao + " votos");
            Console.WriteLine("ZECA: " + votosZeca + " votos");
            Console.WriteLine("BRANCO: " + votosBranco + " votos");
            Console.WriteLine("NULOS: " + votosNulos + " votos");
        }
    }
}