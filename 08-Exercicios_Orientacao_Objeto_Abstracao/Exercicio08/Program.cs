namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8 - Crie uma classe chamada "Calculadora" com métodos para somar, subtrair, multiplicar e dividir números.
            //Implemente sobrecargas desses métodos para aceitar diferentes números de argumentos e tipos, como inteiros e decimais.

            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.Somar(5, 3));
        }
    }
}