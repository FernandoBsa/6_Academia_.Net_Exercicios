namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //12 - Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
            //marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) recebido
            //dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.
            //Fórmulas: Total quilometragem = marcação odômetro final do dia - marcação odômetro inicio do dia 
            //Média do consumo = Total quilometragem/ quantidade de combustível gasto
            //Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)

            decimal quilometragemInicial;
            decimal quilometragemFinal;
            decimal litrosCombutivelGasto;
            decimal valorRecebido;
            decimal quilometragemTotal;
            decimal mediaDeConsumo;
            decimal lucroDia;

            Console.WriteLine("Digite a quilometragem inicial do dia: ");
            quilometragemInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quilometragem final do dia: ");
            quilometragemFinal = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade em litros de combustivel gasto: ");
            litrosCombutivelGasto = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor recebido dos passageiros: ");
            valorRecebido = decimal.Parse(Console.ReadLine());

            quilometragemTotal = quilometragemFinal - quilometragemInicial;

            mediaDeConsumo = quilometragemTotal / litrosCombutivelGasto;

            lucroDia = valorRecebido - (litrosCombutivelGasto * 6.90m);

            Console.WriteLine("O consumo medio e: " + mediaDeConsumo);
            Console.WriteLine("O lucro do dia foi: " + lucroDia);
        }
    }
}