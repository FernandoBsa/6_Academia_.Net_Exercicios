namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9 - Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
            //do que ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis. 
            //Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00;
            //se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
            //Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
            //da entrada e das duas prestações, de acordo com as regras acima. 
            //Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
            //conseqüente pagamento dos boletos das duas prestações.

            double valorMercadoria;
            double entrada;
            double prestacao;
            double resto;

            Console.Write("Digite o valor da mercadoria: R$ ");
            valorMercadoria = double.Parse(Console.ReadLine());

            // Calcula a entrada e as duas prestações
            resto = valorMercadoria % 3;
            prestacao = (valorMercadoria - resto) / 3;
            entrada = prestacao + resto;

            Console.WriteLine("Valor da entrada: " + entrada);
            Console.WriteLine("Valor das prestaçoes: " + prestacao);
        }
    }
}