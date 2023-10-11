namespace Exercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //19.A prefeitura de uma cidade fez uma pesquisa entre seus habitantes,
            //coletando dados sobre o salário e número de filhos. A prefeitura deseja saber: 

            //a) média do salário da população;
            //b) média do número de filhos;
            //c) maior salário;
            //d) percentual de pessoas com salário até R$ 100,00.
            //O final da leitura de dados se dará com a entrada de um salário negativo.

            double salario;
            int numeroDeFilhos;
            double somaSalario = 0;
            int somaFilhos = 0;
            double maiorSalario = double.MinValue;
            int totalPessoas = 0;
            int pessoasComSalarioAte100 = 0;

            Console.WriteLine("Digite os dados dos habitantes (salário negativo para encerrar):");

            while (true)
            {
                Console.Write("Salário: ");
                salario = double.Parse(Console.ReadLine());

                if (salario < 0)
                {
                    break;
                }

                Console.Write("Número de filhos: ");
                numeroDeFilhos = int.Parse(Console.ReadLine());

                somaSalario += salario;
                somaFilhos += numeroDeFilhos;
                totalPessoas++;

                if (salario <= 100)
                {
                    pessoasComSalarioAte100++;
                }

                if (salario > maiorSalario)
                {
                    maiorSalario = salario;
                }
            }

            if (totalPessoas > 0)
            {
                double mediaSalario = somaSalario / totalPessoas;
                double mediaFilhos = (double)somaFilhos / totalPessoas;
                double percentualSalarioAte100 = (double)pessoasComSalarioAte100 / totalPessoas * 100;

                Console.WriteLine("Resultados da pesquisa:");
                Console.WriteLine("Média do salário da população: " + mediaSalario);
                Console.WriteLine("Média do número de filhos: " + mediaFilhos);
                Console.WriteLine("Maior salário: " + maiorSalario);
                Console.WriteLine("Percentual de pessoas com salário até R$ 100,00: " + percentualSalarioAte100);
            }
            else
            {
                Console.WriteLine("Nenhum dado foi inserido.");
            }
        }
    }
}