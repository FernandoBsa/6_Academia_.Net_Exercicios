namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10.Ler nome, sexo e idade de 50 pessoas e após imprimir:
            //Número de pessoas do sexo masculino.
            //Número de pessoas do sexo feminino.
            //Número de pessoas com idade inferior a 30 anos.
            //Número de pessoas com idade superior a 60 anos.
            //Média de idade das mulheres.

            int totalMasculino = 0;
            int totalFeminino = 0;
            int abaixoDe30 = 0;
            int acimaDe60 = 0;
            int somaIdadeMulheres = 0;
            int totalMulheres = 0;

            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("Informações da pessoa " + i + ":");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Sexo (M/F): ");
                char sexo = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine());

                if (sexo == 'M')
                {
                    totalMasculino++;
                }
                else if (sexo == 'F')
                {
                    totalFeminino++;
                    somaIdadeMulheres += idade;
                    totalMulheres++;
                }

                if (idade < 30)
                {
                    abaixoDe30++;
                }
                else if (idade > 60)
                {
                    acimaDe60++;
                }
            }

            Console.WriteLine("Estatísticas:");
            Console.WriteLine("Número de pessoas do sexo masculino: " + totalMasculino);
            Console.WriteLine("Número de pessoas do sexo feminino: " + totalFeminino);
            Console.WriteLine("Número de pessoas com idade inferior a 30 anos: " + abaixoDe30);
            Console.WriteLine("Número de pessoas com idade superior a 60 anos: " + acimaDe60);
            double mediaIdadeMulheres = somaIdadeMulheres / totalMulheres; 
            Console.WriteLine("Média de idade das mulheres: " + mediaIdadeMulheres);
        }
    }
}