namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9 -
            //a) Crie uma classe base "Pessoa" com propriedades como "Nome" e "Idade."
            //b) Crie uma classe derivada "Estudante" que herde de "Pessoa" e adicione propriedades específicas, como "Matricula" e "Curso."
            //c) Certifique - se de que a classe derivada chame o construtor da classe base

            Pessoa pessoa = new Pessoa("João", 30);
            Console.WriteLine("Nome: " + pessoa.Nome + " \nIdade: " + pessoa.Idade);

            Estudante estudante = new Estudante("Maria", 25, 12345, "Ciência da Computação");
            Console.WriteLine("Nome: " + estudante.Nome + " \nIdade: " + estudante.Idade + " \nMatrícula: " + estudante.Matricula + " \nCurso: " + estudante.Curso);
        }
    }
}