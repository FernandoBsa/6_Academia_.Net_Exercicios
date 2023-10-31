using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    public class Contato
    {
        public string nome;
        public string telefone;
        public string email;


        public Contato(string nome, string telefone, string email)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
        }
    }

    public class AgendaTelefonica
    {
        public List<Contato> lista = new List<Contato>();

        public void Adicionar(Contato contato)
        {
            lista.Add(contato);
        }

        public void Remover(string nome)
        {
            Contato contato = lista.FirstOrDefault(x => x.nome == nome);

            if (contato != null)
            {
                lista.Remove(contato);
            }
        }

        public Contato BuscarContato(string nome)
        {
            Contato buscador = lista.FirstOrDefault(x => x.nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if (buscador == null)
            {
                Console.WriteLine("Nome incorreto ou nao existe!");
                return null;
            }
            else
            {
                return buscador;
            }

        }

        public void ListarContato()
        {
            foreach (var l in lista)
            {
                Console.WriteLine("Nome: " + l.nome + ", Telefone: " + l.telefone + ", E-mail: " + l.email);
            }
        }
    }
}
