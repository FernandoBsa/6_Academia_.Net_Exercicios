namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7 - Crie uma função chamada VerificarNumeroPrimo que recebe um vetor de números inteiros
            //como parâmetro e retorna verdadeiro se pelo menos um número primo estiver presente no vetor,
            //e falso caso contrário.

            Console.WriteLine("Insira o tamanho do vetor:");
            int tamanho = int.Parse(Console.ReadLine());

            int[] vetor = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Digite um valor para o vetor na posição " + (i + 1) + ":");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            if (VerificarNumeroPrimo(vetor))
            {
                Console.WriteLine("O vetor contém números primos.");
            }
            else
            {
                Console.WriteLine("O vetor não contém números primos.");
            }
        }

        static bool VerificarNumeroPrimo(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                int valor = vetor[i];
                bool primo = true;

                if (valor <= 1)
                {
                    primo = false;
                }
                else
                {
                    for (int j = 2; j * j <= valor; j++)
                    {
                        if (valor % j == 0)
                        {
                            primo = false;
                            break;
                        }
                    }
                }
                if (primo)
                {
                    return true;
                }

            }
            return false;
        }
    }
}