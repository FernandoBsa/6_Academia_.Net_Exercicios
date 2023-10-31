using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    internal class Gerenciador
    {
        public class Tarefas
        {
            public string Descricao;
            public DateTime DataDeVencimento;
        }

        public class GerenciadorDeTarefas
        {
            public List<Tarefas> listaDeTarefas = new List<Tarefas>();

            public GerenciadorDeTarefas()
            {
                listaDeTarefas = new List<Tarefas>();
            }

            public void AdicionarTarefa(string descricao, DateTime dataDeVencimento)
            {
                Tarefas novaTarefa = new Tarefas();
                novaTarefa.Descricao = descricao;
                novaTarefa.DataDeVencimento = dataDeVencimento;
                listaDeTarefas.Add(novaTarefa);
            }

            public void RemoverTarefa(int indice)
            {
                if (indice >= 0 && indice < listaDeTarefas.Count)
                {
                    listaDeTarefas.RemoveAt(indice);
                }
                else
                {
                    Console.WriteLine("Índice inválido. Não foi possível remover a tarefa.");
                }
            }

            public void ListarTarefas()
            {
                if (listaDeTarefas.Count == 0)
                {
                    Console.WriteLine("Nenhuma tarefa encontrada.");
                }
                else
                {
                    Console.WriteLine("Lista de Tarefas:");
                    for (int i = 0; i < listaDeTarefas.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. Descrição: {listaDeTarefas[i].Descricao}, Data de Vencimento: {listaDeTarefas[i].DataDeVencimento}");
                    }
                }
            }

            public bool VerificarTarefaParaHoje(int indice)
            {
                if (indice >= 0 && indice < listaDeTarefas.Count)
                {
                    Tarefas tarefa = listaDeTarefas[indice];
                    if (tarefa.DataDeVencimento.Date == DateTime.Today)
                    {
                        Console.WriteLine("A tarefa selecionada é para hoje.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("A tarefa selecionada não é para hoje.");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("Índice inválido. Não foi possível verificar a tarefa.");
                    return false;
                }
            }

        }
    }
}
