namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //12.Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N, fornecido pelo usuário, existe no vetor. 
            //Se existir, indicar a(s) posição(ões), senão escrever a mensagem "O número fornecido não existe no vetor!".

            int tamanho = 4;
            int[] vetor = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Digite um valor para o vetor na posição " + (i + 1) + ":");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite um número para verificar se existe no vetor:");
            int numeroVerificar = int.Parse(Console.ReadLine());

            bool encontrado = false;

            //Console.Write("Posições onde o número foi encontrado: ");
            for (int i = 0; i < tamanho; i++)
            {
                if (vetor[i] == numeroVerificar)
                {
                    Console.Write("Posições onde o número foi encontrado: ");
                    Console.Write(i + " ");
                    encontrado = true;
                }
            }

            if(encontrado == false)
            {
                Console.WriteLine("O número fornecido não existe no vetor!");
            }

        }
    }
}