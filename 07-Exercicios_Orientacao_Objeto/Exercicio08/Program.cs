namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgendaTelefonica agenda = new AgendaTelefonica();

            bool exibirMenu = true;
            while (exibirMenu)
            {
                Console.WriteLine("Bem vindo a sua agenda telefonica!");
                Console.WriteLine("1 - Listar contatos.");
                Console.WriteLine("2 - Adicionar contato.");
                Console.WriteLine("3 - Remover contato.");
                Console.WriteLine("4 - Buscar contato.");
                Console.WriteLine("5 - Sair");
                Console.WriteLine("Digite o numero para acessar a funcao.");
                string numero = Console.ReadLine();

                switch (numero)
                {
                    case "1":
                        agenda.ListarContato();
                        break;
                    case "2":
                        Console.WriteLine("Digite o nome do contato: ");
                        string nomeContato = Console.ReadLine();
                        Console.WriteLine("Digite o telefone do contato: ");
                        string telefoneContato = Console.ReadLine();
                        Console.WriteLine("Digite o email do contato: ");
                        string emailContato = Console.ReadLine();
                        Contato li = new Contato(nomeContato, telefoneContato, emailContato);
                        agenda.Adicionar(li);
                        break;
                    case "3":
                        Console.WriteLine("Digite o nome do contato para remover: ");
                        string contatoRemover = Console.ReadLine();
                        agenda.Remover(contatoRemover);
                        break;
                    case "4":
                        Console.WriteLine("Digite o nome do contato para remover: ");
                        string buscar = Console.ReadLine();
                        agenda.BuscarContato(buscar);
                        break;
                    case "5":
                        exibirMenu = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }

        }
    }
}