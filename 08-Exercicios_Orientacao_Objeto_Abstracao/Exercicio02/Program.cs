using System.Reflection;
using System.Text.RegularExpressions;
using System;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 - Criar uma classe Veiculo que contém as propriedades Marca e Modelo.Criar um método abstrato chamado Dirigir. Criar duas classes derivadas, Carro e Moto, que herdam de Veiculo.
            //A classe Carro deve ter uma propriedade adicional QuantidadeDePortas, enquanto a classe Moto deve ter uma propriedade adicional Cilindrada. 
            //Criar um método abstrato Dirigir na classe Veiculo. 
            //Em seguida, criar um método Dirigir na classe Carro que imprime "Dirigindo o <marca> <modelo> com <quantidadeDePortas> portas" e um método Dirigir na classe Moto que imprime "Dirigindo a <marca> <modelo> com <cilindrada> cilindradas"

            Carro carro = new Carro { Marca = "Toyota", Modelo = "Corolla", QuantidadeDePortas = 4 };
            carro.Dirigir();

            Moto moto = new Moto { Marca = "Honda", Modelo = "CBR500R", Cilindrada = "500" };
            moto.Dirigir();

        }
    }
}