namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
            //se a média das duas notas for maior ou igual a 7,0. 
            //Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
            //é a média entre a nota do exame e a média das 2 notas. 
            //Se esta média final for maior ou igual a 5,0, o programa deve escrever “Aprovado”, caso contrário deve 
            //escrever “Reprovado”.


            double nota1, nota2, notaExame, media, mediaFinal;

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            Console.WriteLine("Sua media foi: " + media);

            if (media > 7)
            {
                Console.WriteLine("Voce foi aprovado.");
            }

            Console.WriteLine("Digite sua nota do exame: ");
            notaExame = double.Parse(Console.ReadLine());

            mediaFinal = (notaExame + media) / 2;

            Console.WriteLine("Sua media final foi: " + mediaFinal);

            if (mediaFinal >= 5)
            {
                Console.WriteLine("Voce foi aprovado.");
            }
            else
            {
                Console.WriteLine("Voce foi reprovado");
            }
        }
    }
}