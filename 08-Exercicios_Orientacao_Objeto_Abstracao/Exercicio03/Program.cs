using System.Runtime.Intrinsics.X86;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 - Crie uma interface chamada "IFormaGeometrica" com dois métodos abstratos: "CalcularArea()" e "CalcularPerimetro()". 
            //Em seguida, crie duas classes que implementam essa interface: "Retangulo" e "Circulo". 
            //Implemente os métodos "CalcularArea()" e "CalcularPerimetro()" para cada uma dessas classes, 
            //de forma que o "Retangulo" calcule a área e o perímetro de um retângulo e o "Circulo" calcule a área e o perímetro de um círculo.

            Retangulo retangulo = new Retangulo { Largura = 5, Altura = 3 };
            Console.WriteLine("Retângulo:");
            Console.WriteLine("Área: " + retangulo.CalcularArea());
            Console.WriteLine("Perímetro: " + retangulo.CalcularPerimetro());

            Circulo circulo = new Circulo { Raio = 2.5 };
            Console.WriteLine("Círculo:");
            Console.WriteLine("Área: " + circulo.CalcularArea());
            Console.WriteLine("Perímetro: " + circulo.CalcularPerimetro());
        }
    }
}