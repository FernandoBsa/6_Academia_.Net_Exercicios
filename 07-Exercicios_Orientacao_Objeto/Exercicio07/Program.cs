namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 - Crie uma classe CorretoraDeImóveis com atributos para armazenar informações sobre imóveis (endereço, preço, tipo).
            //Implemente um construtor e métodos para listar imóveis disponíveis e calcular o valor médio.
            //Crie um menu que contenha as opções de inserir imoveis, alterar preço do imovel e apresentar todos os imoveis.
            //Insira os imoveis numa lista para facilitar o trabalho.

            CorretoraDeImoveis corretora = new CorretoraDeImoveis();

            bool exibirMenu = true;
            while (exibirMenu)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1) Inserir imóvel");
                Console.WriteLine("2) Alterar preço do imóvel");
                Console.WriteLine("3) Apresentar todos os imóveis");
                Console.WriteLine("4) Sair");
                Console.Write("Digite o número da opção desejada: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Digite o endereço do imóvel:");
                        string endereco = Console.ReadLine();
                        Console.WriteLine("Digite o preço do imóvel:");
                        double preco = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o tipo do imóvel:");
                        string tipo = Console.ReadLine();
                        corretora.imoveis.Add(new Imovel(endereco, preco, tipo));
                        break;
                    case "2":
                        Console.WriteLine("Selecione o imóvel cujo preço deseja alterar:");
                        for (int i = 0; i < corretora.imoveis.Count; i++)
                        {
                            Console.WriteLine("Imovel " + (i + 1) + ":");
                            Console.WriteLine("Endereço: " + corretora.imoveis[i].endereco + ", Preço: " + corretora.imoveis[i].preco + ", Tipo: " + corretora.imoveis[i].tipo);
                        }
                        int indice = Convert.ToInt32(Console.ReadLine());
                        if (indice >= 1 && indice <= corretora.imoveis.Count)
                        {
                            Console.WriteLine("Digite o novo preço:");
                            corretora.imoveis[indice - 1].preco = double.Parse(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Índice inválido.");
                        }
                        break;
                    case "3":
                        corretora.ListarImoveis();
                        Console.WriteLine($"Valor médio dos imóveis: {corretora.CalcularValorMedio()}");
                        break;
                    case "4":
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