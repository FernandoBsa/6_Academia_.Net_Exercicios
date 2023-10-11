namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
            //Área do triangulo = (base * altura) / 2;
            //Teste se a base ou a altura digitada não foi igual a zero. 


            Console.WriteLine("Entre com um valor inteiro para a base do triangulo: ");

            int baseTriangulo = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com um valor inteiro para a altura do triangulo: ");

            int alturaTriangulo = int.Parse(Console.ReadLine());

            if (baseTriangulo != 0 && alturaTriangulo != 0)
            {
                float areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
                Console.WriteLine("Area do triangulo: " + areaTriangulo);
            }
            else
            {
                Console.WriteLine("Um dos valores de base ou altura esta igual 0!");
            }
        }
    }
}