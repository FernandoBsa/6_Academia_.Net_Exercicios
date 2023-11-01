namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //12 - Crie uma classe Agenda que pode armazenar inúmeras pessoas e que seja capaz de realizar as seguintes operações:
            //void armazenaPessoa(String nome, int idade, float altura);
            //void removePessoa(String nome);
            //Pessoa buscaPessoa(String nome); // retorna a pessoa com o nome informado
            //void imprimeAgenda(); // imprime os dados de todas as pessoas da agenda
            //Faça um menu para navegar entre as opções infinitamente.

            Agenda agenda = new Agenda();

            bool agendaAtiva = true;
            while (agendaAtiva)
            {
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1. Adicionar Pessoa");
                Console.WriteLine("2. Remover Pessoa");
                Console.WriteLine("3. Buscar Pessoa");
                Console.WriteLine("4. Imprimir Agenda");
                Console.WriteLine("5. Sair");

                string opcao = Console.ReadLine();
                switch (opcao)
                {                 
                    case "1":
                        Console.WriteLine("Digite o nome:");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite a idade:");
                        int idade = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a altura:");
                        float altura = float.Parse(Console.ReadLine());
                        agenda.ArmazenaPessoa(nome, idade, altura);
                        break;
                    case "2":
                        Console.WriteLine("Digite o nome da pessoa a ser removida:");
                        string nomeRemover = Console.ReadLine();
                        agenda.RemovePessoa(nomeRemover);
                        break;
                    case "3":
                        Console.WriteLine("Digite o nome da pessoa a ser buscada:");
                        string nomeBuscar = Console.ReadLine();
                        Pessoa pessoaEncontrada = agenda.BuscaPessoa(nomeBuscar);
                        if (pessoaEncontrada != null)
                        {
                            Console.WriteLine("Pessoa encontrada: \nNome: " + pessoaEncontrada.Nome + " \nIdade: " + pessoaEncontrada.Idade + " \nAltura: " + pessoaEncontrada.Altura);
                        }
                        else
                        {
                            Console.WriteLine("Pessoa não encontrada na agenda.");
                        }
                        break;
                    case "4":
                        agenda.ImprimeAgenda();
                        break;
                    case "5":
                        agendaAtiva = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                        break;
                }
            }
        }
    }
}