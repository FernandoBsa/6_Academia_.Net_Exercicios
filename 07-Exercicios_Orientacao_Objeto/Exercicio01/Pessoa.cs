using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Pessoa
    {
        public string nome;
        public int idade;
        public string cpf;
        public string rg;

        public void CadastrarPessoa(string nome, int idade, string cpf, string rg)
        {
            this.nome = nome;
            this.idade = idade;
            this.cpf = cpf;
            this.rg = rg;
        }

        public void ApresentarPessoa()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("RG: " + rg);
        }
    }
}
