namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11.Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa,
            //a média aritmética da turma e a quantidade de alunos da turma. Usar - 1 para encerrar a leitura.

            double nota;
            double somaNotas = 0;
            double notaMaisAlta = double.MinValue;
            double notaMaisBaixa = double.MaxValue;
            int quantidadeAlunos = 0;

            Console.WriteLine("Digite as notas dos alunos. Digite -1 para encerrar.");

            while (true)
            {
                
                Console.Write("Digite a nota do aluno: ");
                string entrada = Console.ReadLine();

                if (entrada == "-1")
                {
                    break; 
                }

                if (double.TryParse(entrada, out nota))
                {
                    somaNotas += nota;
                    quantidadeAlunos++;
                    notaMaisAlta = Math.Max(notaMaisAlta, nota);
                    notaMaisBaixa = Math.Min(notaMaisBaixa, nota);
                }
                else
                {
                    Console.WriteLine("Nota inválida. Tente novamente.");
                }
            }

            if (quantidadeAlunos > 0)
            {
                double media = somaNotas / quantidadeAlunos;

                Console.WriteLine("Estatísticas da turma:");
                Console.WriteLine("Nota mais alta: " + notaMaisAlta);
                Console.WriteLine("Nota mais baixa: " + notaMaisBaixa);
                Console.WriteLine("Média aritmética: " + media);
                Console.WriteLine("Quantidade de alunos: " + quantidadeAlunos);
            }
            else
            {
                Console.WriteLine("Nenhuma nota válida foi inserida.");
            }
        }
    }
}