namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 - Escreva uma função chamada CalcularMedia que recebe um vetor de números,
            //a informação se o usuário deseja escolher os pares ou os impares,
            //e retorna a média dos valores conforme a escolha do usuário.

            Console.WriteLine("Insira o tamanho do vetor:");
            int tamanho = int.Parse(Console.ReadLine());
            int[] vetor = new int[tamanho];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite o valor " + (i + 1) + ":");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Escolha 'par' para calcular a média dos números pares ou 'impar' para números ímpares:");
            string escolha = Console.ReadLine().ToLower();

            CalcularMedia(vetor, escolha);
        }

        static void CalcularMedia(int[] vetor, string escolha)
        {
            int soma = 0;
            int contador = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                if (escolha == "par" && vetor[i] % 2 == 0)
                {
                    soma += vetor[i];
                    contador++;
                }
                else if (escolha == "impar" && vetor[i] % 2 != 0)
                {
                    soma += vetor[i];
                    contador++;
                }
            }
            double resultado = soma / contador;

            Console.WriteLine("Sua media dos numeros " + escolha + " é: " + resultado);
        }
    }
}