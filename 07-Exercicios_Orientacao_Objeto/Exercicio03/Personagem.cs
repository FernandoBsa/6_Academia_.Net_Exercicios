using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Personagem
    {
        public string nome;
        public int nivel;
        public string posicao;
        public int itensColetados;
        public Personagem()
        {
            Console.WriteLine("Digite o nome do personagem:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o nivel do personagem:");
            nivel = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a posição do personagem:");
            posicao = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de itens coletados:");
            itensColetados = int.Parse(Console.ReadLine());
        }

        public void Atacar(double dano)
        {
            Console.WriteLine("O personagem " + nome + " atacou com um dano de " + dano + "!");
        }

        public void Movimentar(int direcao)
        {
            switch (direcao)
            {
                case 1:
                    Console.WriteLine("O personagem " + nome + " se moveu para frente");
                    break;
                case 2:
                    Console.WriteLine("O personagem " + nome + " se moveu para trás");
                    break;
                case 3:
                    Console.WriteLine("O personagem " + nome + " se moveu para direita");
                    break;
                case 4:
                    Console.WriteLine("O personagem " + nome + " se moveu para esquerda");
                    break;
                default:
                    Console.WriteLine("direção inválida");
                    break;
            }
        }
    }
}
