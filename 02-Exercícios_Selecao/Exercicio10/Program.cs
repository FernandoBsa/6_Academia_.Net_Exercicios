namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
            //O programa deve mostrar os dados do atleta mais novo e mais alto.

            string nome1, nome2;
            double idade1, altura1, idade2, altura2;

            Console.WriteLine("Digite o nome do atleta: ");
            nome1 = Console.ReadLine();

            Console.WriteLine("Digite a idade do atleta: ");
            idade1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do atleta: ");
            altura1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do atleta: ");
            nome2 = Console.ReadLine();

            Console.WriteLine("Digite a idade do atleta: ");
            idade2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do atleta: ");
            altura2 = double.Parse(Console.ReadLine());

            if (idade1 < idade2)
            {
                Console.WriteLine("Nome do Atleta: " + nome1);
                Console.WriteLine("Idade do Atleta: " + idade1);
                Console.WriteLine("Altura do Atleta: " + altura1);
            }
            else
            {
                Console.WriteLine("Nome do Atleta: " + nome2);
                Console.WriteLine("Idade do Atleta: " + idade2);
                Console.WriteLine("Altura do Atleta: " + altura2);
            }
            if (altura1 > altura2)
            {
                Console.WriteLine("Nome do Atleta: " + nome1);
                Console.WriteLine("Idade do Atleta: " + idade1);
                Console.WriteLine("Altura do Atleta: " + altura1);
            }
            else
            {
                Console.WriteLine("Nome do Atleta: " + nome2);
                Console.WriteLine("Idade do Atleta: " + idade2);
                Console.WriteLine("Altura do Atleta: " + altura2);
            }
        }
    }
}