using System.Runtime.Intrinsics.X86;
using System;

namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////7 -
            // a) Crie uma classe base chamada "Veiculo" com propriedades como "Marca" e "Ano."ok
            // b) Crie classes derivadas como "Carro" e "Moto" que herdem de "Veiculo" e adicionem propriedades específicas, como "Número de Portas" para carros e "Cilindrada" para motos.ok
            // c) Crie uma lista de Veículos que inclui instâncias de "Veiculo", "Carro" e "Moto." Use um loop para percorrer a lista e chamar um método "Apresentar"
            // que exibe informações sobre cada veículo, demonstrando o polimorfismo.ok
            // d) Modifique a classe "Veiculo" para ter um método virtual "Apresentar" que exiba informações gerais do veículo.
            // e) Sobrescreva o método "Apresentar" nas classes derivadas para incluir informações específicas, como o número de portas para carros ou a cilindrada para motos.

            List<Veiculo> veiculos = new List<Veiculo>
            {
                new Veiculo { Marca = "Ford", Ano = 2020 },
                new Carro { Marca = "Porsche", Ano = 2018, NumeroPortas = 4 },
                new Moto { Marca = "Honda", Ano = 2019, Cilindrada = "300cc" }
            };

            foreach (var veiculo in veiculos)
            {
                veiculo.Apresentar();
                Console.WriteLine();
            }


        }
    }
}