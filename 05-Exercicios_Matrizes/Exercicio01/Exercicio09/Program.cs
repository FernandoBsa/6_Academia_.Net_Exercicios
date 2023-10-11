namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9) Leia uma matriz 3x3.Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.
            //Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.

            int[,] matriz = new int[3, 3];

            Console.WriteLine("Preencha a matriz 3x3:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Digite o valor da posição [" + i + "][" + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

            Console.Write("Digite o número a ser pesquisado: ");
            int numero = int.Parse(Console.ReadLine());

            bool encontrado = false;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matriz[i, j] == numero)
                    {
                        encontrado = true;
                        break; 
                    }
                }

                if (encontrado)
                {
                    break;
                }
            }

            if (encontrado)
            {
                Console.WriteLine("O número existe na matriz.");
            }
            else
            {
                Console.WriteLine("Número inexistente na matriz.");
            }
        }

    }
    
}