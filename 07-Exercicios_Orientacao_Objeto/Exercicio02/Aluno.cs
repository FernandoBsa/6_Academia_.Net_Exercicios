using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exercicio02
{
    internal class Aluno
    {
        public string nome;
        public int idade;
        public string matricula;
        public string curso;
        public Aluno()
        {
            Console.WriteLine("Digite o nome do aluno:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a idade do aluno:");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a matrícula do aluno:");
            matricula = Console.ReadLine();

            Console.WriteLine("Digite o curso do aluno:");
            curso = Console.ReadLine();
        }
        public void ApresentarAluno()
        {
            Console.WriteLine("Nome do Aluno: " + nome);
            Console.WriteLine("Idade do Aluno: " + idade);
            Console.WriteLine("Matrícula do Aluno: " + matricula);
            Console.WriteLine("Curso do Aluno: " + curso);
        }
    }

 
}
