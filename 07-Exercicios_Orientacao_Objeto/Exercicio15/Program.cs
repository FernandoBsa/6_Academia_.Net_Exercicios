namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11 - Crie uma classe "Carro" com os atributos "modelo", "ano" e "velocidade".
            //Em seguida, crie um método para acelerar o carro (aumentando a velocidade em 10)
            //e outro para frear o carro (diminuindo a velocidade em 10, mas nunca deixando a  velocidade negativa).

            Carro carro = new Carro
            {
                Modelo = "Fusca",
                Ano = 1990,
                Velocidade = 120
            };

            Console.WriteLine("Modelo: " + carro.Modelo + " \nAno: " + carro.Ano + " \nVelocidade: " + carro.Velocidade);

            carro.Acelerar();
            Console.WriteLine("Velocidade após acelerar: " + carro.Velocidade);

            carro.Frear();
            Console.WriteLine("Velocidade após frear: " + carro.Velocidade);

        }
    }
}