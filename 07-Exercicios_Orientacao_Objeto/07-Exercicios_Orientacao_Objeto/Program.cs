namespace _07_Exercicios_Orientacao_Objeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.CadastrarPessoa("Fernando Barros", 28, "00011122269", "1234567");
            pessoa.ApresentarPessoa();
        }
    }
}