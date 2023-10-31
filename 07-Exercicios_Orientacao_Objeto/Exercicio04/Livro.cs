using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class Livro
    {       
        public string titulo;
        public string autor;
        public int anoPublicacao;
        public bool emprestado;

        public Livro(string titulo, string autor, int anoPublicacao)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anoPublicacao = anoPublicacao;
            this.emprestado = false;
        }

        public void Emprestar()
        {
            if (emprestado)
            {
                Console.WriteLine("Livro já emprestado.");
            }
            else
            {
                emprestado = true;
                Console.WriteLine("Livro emprestado com sucesso.");
            }
        }

        public void Devolver()
        {
            if (emprestado)
            {
                emprestado = false;
                Console.WriteLine("Livro devolvido com sucesso.");
            }
            else
            {
                Console.WriteLine("O livro não está emprestado no momento.");
            }
        }

        public void exibirInformacao()
        {
            Console.WriteLine("Titulo: " + titulo);
            Console.WriteLine("Autor: " + autor);
            Console.WriteLine("Ano de Publicacao: " + anoPublicacao);
            string mensagem = emprestado ? "O livro esta emprestado" : "O livro nao esta emprestado";
            Console.WriteLine(mensagem);
        }
    }
    
}
