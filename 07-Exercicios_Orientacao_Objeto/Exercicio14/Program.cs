namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10 - Crie uma classe chamada Animal que tenha as propriedades Nome, Especie e Idade.
            //Crie também um método chamado EmitirSom, que imprime na tela o som do animal.

            Animal animal = new Animal();
            animal.Nome = "Thor";
            animal.Especie = "Cachorro";
            animal.Idade = 1;
            Console.WriteLine("Nome: " + animal.Nome + " \nEspecie: " + animal.Especie + " \nIdade: " + animal.Idade);
            animal.EmitirSom();
        }
    }
}