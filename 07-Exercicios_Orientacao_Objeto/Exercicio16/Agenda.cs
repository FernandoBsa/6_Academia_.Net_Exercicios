using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio16
{
    public class Agenda
    {
        private List<Pessoa> pessoas = new List<Pessoa>();
        public void ArmazenaPessoa(string nome, int idade, float altura)
        {
            Pessoa pessoa = new Pessoa { Nome = nome, Idade = idade, Altura = altura };
            pessoas.Add(pessoa);
        }

        public Pessoa BuscaPessoa(string nome)
        {
            foreach (var pessoa in pessoas)
            {
                if (pessoa.Nome == nome)
                {
                    return pessoa;
                }
            }
            return null;
        }
        public void RemovePessoa(string nome)
        {
            Pessoa pessoa = BuscaPessoa(nome);
            if (pessoa != null)
            {
                pessoas.Remove(pessoa);
                Console.WriteLine("Pessoa removida com sucesso.");
            }
            else
            {
                Console.WriteLine("Pessoa não encontrada na agenda.");
            }
        }
        public void ImprimeAgenda()
        {
            Console.WriteLine("Lista de Pessoas na Agenda:");
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("Nome: " + pessoa.Nome + ", Idade: " + pessoa.Idade + ",  Altura: " + pessoa.Altura);
            }
        }





    }
}
