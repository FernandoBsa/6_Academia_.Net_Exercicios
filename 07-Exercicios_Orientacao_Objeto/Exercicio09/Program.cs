using static Exercicio09.Gerenciador;

namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 - Crie uma classe GerenciadorDeTarefas com atributos para armazenar uma lista de tarefas
            //(descrição, data de vencimento). Implemente um construtor e métodos para adicionar,
            //remover e listar tarefas. Adicione um método para verificar se a tarefa deverá ser executada no dia de hoje. 

            GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();

            gerenciador.AdicionarTarefa("Tarefa 1", new DateTime(2023, 10, 28));
            gerenciador.AdicionarTarefa("Tarefa 2", new DateTime(2023, 10, 27));
            gerenciador.AdicionarTarefa("Tarefa 3", new DateTime(2023, 10, 26));

            gerenciador.ListarTarefas();

            gerenciador.RemoverTarefa(1);

            gerenciador.ListarTarefas();

            gerenciador.VerificarTarefaParaHoje(0);
        }
    }
}