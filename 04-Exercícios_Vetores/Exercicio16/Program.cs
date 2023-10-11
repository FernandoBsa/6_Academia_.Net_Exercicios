namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //16.Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os escreva.Crie, a seguir, um vetor para cada uma das operações:
            //•	A união de X com Y
            //•	A diferença entre X e Y
            //•	A interseção entre X e Y
            //Escreva o vetor resultado de cada uma das operações.
            
            int[] x = new int[10];
            int[] y = new int[10];
            int[] uniao = new int[20];
            int[] diferenca = new int[10];
            int[] intersecao = new int[10];

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("Digite um valor para o vetor X na posição " + (i + 1) + ":");
                x[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine("Digite um valor para o vetor Y na posição " + (i + 1) + ":");
                y[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("X[" + i + "] = " + x[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine("Y[" + i + "] = " + y[i]);
            }

            Console.WriteLine();

            //UNIÃO 
            x.CopyTo(uniao, 0);

            int aux = 4;

            for (int i = 0; i < y.Length; i++)
            {
                for (int j = 0; j < x.Length; j++)
                {
                    if (y[i] == x[j])
                    {
                        break;
                    }

                    if (j == (x.Length - 1))
                    {
                        uniao[aux] = y[i];
                        aux++;
                    }
                }
            }

            for (int i = 0; i < aux; i++)
            {
                Console.WriteLine("união[" + i + "] = " + uniao[i]);
            }

            //DIFERENÇA
            Console.WriteLine();

            int aux2 = 0;

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        break;
                    }

                    if (j == (y.Length - 1))
                    {
                        diferenca[aux2] = x[i];
                        aux2++;
                    }
                }
            }

            for (int i = 0; i < aux2; i++)
            {
                Console.WriteLine("Diferença[" + i + "] = " + diferenca[i]);
            }

            Console.WriteLine();


            //INTERSECÇÃO

            int aux3 = 0;

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        intersecao[aux3] = x[i];
                        aux3++;
                        break;
                    }
                }
            }

            for (int i = 0; i < aux3; i++)
            {
                Console.WriteLine("Intersecção[" + i + "] = " + intersecao[i]);
            }

        }
    }
}