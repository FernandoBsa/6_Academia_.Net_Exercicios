namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 - Crie uma classe RegistroDeCompras com atributos para registrar informações de compras (data, produto, valor).
            //Implemente um construtor e métodos para adicionar e listar compras.

            RegistroDeCompra registroDeCompras = new RegistroDeCompra("26/10/2023", "Livro", 50.0);
            registroDeCompras.AdicionarCompra(new RegistroDeCompra("26/10/2023", "Caneta", 2.5));
            registroDeCompras.AdicionarCompra(new RegistroDeCompra("26/10/2023", "Caderno", 5.0));

            registroDeCompras.Listar();
        }
    }
}