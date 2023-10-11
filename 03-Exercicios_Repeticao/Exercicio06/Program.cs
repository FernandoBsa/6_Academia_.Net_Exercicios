namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6.Escreva um algoritmo que leia o número de alunos de uma turma e em seguida leia a quantidade de avaliações
            //aplicadas para aquela turma.Por fim, leia as notas das avaliações de cada aluno e mostre sua nota final
            //(média das notas das avaliações).

            Console.WriteLine("Digite o número de alunos: ");
            int numeroDeAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de avaliações: ");
            int quantidadeDeAvaliacoes = int.Parse(Console.ReadLine());

            for (int aluno = 1; aluno <= numeroDeAlunos; aluno++)
            {
                double somaDasNotas = 0;

                for (int avaliacao = 1; avaliacao <= quantidadeDeAvaliacoes; avaliacao++)
                {
                    Console.Write("Digite a nota da avaliação " + avaliacao + " para o aluno " + aluno + ": ");
                    double nota = double.Parse(Console.ReadLine());
                    somaDasNotas += nota;
                }

                double mediaDasNotas = somaDasNotas / quantidadeDeAvaliacoes;

                Console.WriteLine("A média das notas do aluno " + aluno + " é: " + mediaDasNotas);
            }
        }
    }
}