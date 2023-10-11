using System.Runtime.Intrinsics.X86;

namespace Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //15.Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado
            //ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente.
            //Considerar nota 7,0 como mínima para aprovação.

            Console.WriteLine("Digite a primeira nota do aluno:");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota do aluno:");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota do aluno:");
            double nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota do aluno:");
            double nota4 = double.Parse(Console.ReadLine());

            double mediaPonderada = (nota1 * 2 + nota2 * 1 + nota3 * 2 + nota4 * 4) / 9;

            Console.WriteLine("Média Ponderada: " + mediaPonderada);

            if (mediaPonderada >= 7.0)
            {
                Console.WriteLine("Aluno aprovado!");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }

        }
    }
}