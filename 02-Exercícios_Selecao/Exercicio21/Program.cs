namespace Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //21 - Crie um programa que permita que o usuário selecione uma unidade de medida de entrada (metros, centímetros, polegadas ou pés) e uma unidade de 
            //medida de saída usando um menu com o comando switch case. O programa deve, em seguida, pedir ao usuário um valor de entrada e converter esse 
            //valor para a unidade de saída selecionada.

            Console.WriteLine("Selecione a unidade de medida de entrada:");
            Console.WriteLine("1 - Metros");
            Console.WriteLine("2 - Centímetros");
            Console.WriteLine("3 - Polegadas");
            Console.WriteLine("4 - Pés");
            int entrada = int.Parse(Console.ReadLine());

            Console.WriteLine("Selecione a unidade de medida de saída:");
            Console.WriteLine("1 - Metros");
            Console.WriteLine("2 - Centímetros");
            Console.WriteLine("3 - Polegadas");
            Console.WriteLine("4 - Pés");
            int saida = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor que deseja converter:");
            double valor = double.Parse(Console.ReadLine());

            double resultado = 0;

            switch (entrada)
            {
                case 1: // metros
                    switch (saida)
                    {
                        case 1: // metros
                            resultado = valor;
                            break;
                        case 2: // centímetros
                            resultado = valor * 100;
                            break;
                        case 3: // polegadas
                            resultado = valor * 39.37;
                            break;
                        case 4: // pés
                            resultado = valor * 3.281;
                            break;
                    }
                    break;
                case 2: // centímetros
                    switch (saida)
                    {
                        case 1: // metros
                            resultado = valor / 100;
                            break;
                        case 2: // centímetros
                            resultado = valor;
                            break;
                        case 3: // polegadas
                            resultado = valor / 2.54;
                            break;
                        case 4: // pés
                            resultado = valor / 30.48;
                            break;
                    }
                    break;
                case 3: // polegadas
                    switch (saida)
                    {
                        case 1: // metros
                            resultado = valor / 39.37;
                            break;
                        case 2: // centímetros
                            resultado = valor * 2.54;
                            break;
                        case 3: // polegadas
                            resultado = valor;
                            break;
                        case 4: // pés
                            resultado = valor / 12;
                            break;
                    }
                    break;
                case 4: // pés
                    switch (saida)
                    {
                        case 1: // metros
                            resultado = valor / 3.281;
                            break;
                        case 2: // centímetros
                            resultado = valor * 30.48;
                            break;
                        case 3: // polegadas
                            resultado = valor * 12;
                            break;
                        case 4: // pés
                            resultado = valor;
                            break;
                    }
                    break;
            }

            Console.WriteLine("O valor convertido é " + resultado);
        }
    }
}