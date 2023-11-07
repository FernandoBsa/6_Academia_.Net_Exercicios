namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10 -
            //a) Crie uma classe base "Funcionario" com propriedades como "Nome" e "Salario."
            //b) Crie classes derivadas, como "Gerente" e "Desenvolvedor," que herdem de "Funcionario" e forneçam implementações específicas para calcular bônus ou mostrar funções.

            Gerente gerente = new Gerente("João", 5000);
            gerente.CalcularBonus();

            Desenvolvedor desenvolvedor = new Desenvolvedor("Mario", 4000);
            desenvolvedor.MostrarFuncao();
        }
    }
}