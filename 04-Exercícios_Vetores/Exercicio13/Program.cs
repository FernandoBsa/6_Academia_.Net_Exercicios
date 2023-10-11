namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13.Escreva um algoritmo para ler um vetor de inteiros e positivos e imprimir quantas vezes 
            //   aparecem os números 2, 4 e 8. O vetor terá no máximo 100 posições.
            //   Sair do programa quando for digitado - 1 ou quando atingir o máximo de posições do vetor.

            int tamanhoMaximo = 100;
            int[] vetor = new int[tamanhoMaximo];
            int contador2 = 0;
            int contador4 = 0;
            int contador8 = 0;

            for (int i = 0; i < tamanhoMaximo; i++)
            {
                Console.WriteLine("Digite o número inteiro e positivo ou digite -1 para sair:");
                int numero = int.Parse(Console.ReadLine());
                vetor[i] = numero;

                if (numero == -1)
                {
                    break;
                }

                else if (numero == 2)
                {
                    contador2++;
                }
                else if (numero == 4)
                {
                    contador4++;
                }
                else if (numero == 8)
                {
                    contador8++;
                }
            }

            Console.WriteLine("Números 2 encontrados: " + contador2);
            Console.WriteLine("Números 4 encontrados: " + contador4);
            Console.WriteLine("Números 8 encontrados: " + contador8);

        }
    }
}