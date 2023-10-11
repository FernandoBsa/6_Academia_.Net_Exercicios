using System.Net;
using System.Runtime.ConstrainedExecution;

namespace Exercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //20.Foi realizada uma pesquisa de algumas características físicas da população de uma
            //certa região, a qual coletou os seguintes dados referentes a cada habitante para
            //serem analisados:
            //-sexo(masculino e feminino)
            //- cor dos olhos(azuis, verdes ou castanhos)
            //-cor dos cabelos(louros, castanhos, pretos)
            //-idade

            //Faça um algoritmo que determine e escreva:
            //-a maior idade dos habitantes
            //-a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
            //e que tenham olhos verdes e cabelos louros.
            //O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.

            int maiorIdade = 0;
            int mulheresVerdesLouros = 0;

            Console.WriteLine("Digite os dados dos habitantes (idade = -1 para encerrar):");

            while (true)
            {
                Console.Write("Sexo (M/F): ");
                char sexo = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (sexo == 'M' || sexo == 'F')
                {
                    Console.Write("Cor dos olhos (A - azuis, V - verdes, C - castanhos): ");
                    char olhos = char.ToUpper(Console.ReadKey().KeyChar);
                    Console.WriteLine();

                    Console.Write("Cor dos cabelos (L - louros, C - castanhos, P - pretos): ");
                    char cabelos = char.ToUpper(Console.ReadKey().KeyChar);
                    Console.WriteLine();

                    Console.Write("Idade: ");
                    int idade = int.Parse(Console.ReadLine());

                    if (idade == -1)
                    {
                        break;
                    }

                    if (idade > maiorIdade)
                    {
                        maiorIdade = idade;
                    }

                    if (sexo == 'F' && idade >= 18 && idade <= 35 && olhos == 'V' && cabelos == 'L')
                    {
                        mulheresVerdesLouros++;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }
            }

            Console.WriteLine("Resultados da pesquisa:");
            Console.WriteLine("Maior idade dos habitantes: " + maiorIdade);
            Console.WriteLine("Quantidade de mulheres com idade entre 18 e 35 anos, olhos verdes e cabelos louros: " + mulheresVerdesLouros);
        }
    }
}