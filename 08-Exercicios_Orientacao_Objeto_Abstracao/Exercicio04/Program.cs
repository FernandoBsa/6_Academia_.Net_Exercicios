namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 - Crie uma classe abstrata "ContaBancaria" com propriedades para "Saldo" e métodos abstratos "Depositar" e "Sacar".
            //Crie classes derivadas, como "ContaCorrente" e "ContaPoupanca", que implementam os métodos de depósito e saque de acordo com as regras de cada tipo de conta.

            ContaCorrente contaCorrente = new ContaCorrente();
            contaCorrente.Depositar(1000);
            Console.WriteLine("Saldo da conta corrente: " + contaCorrente.Saldo);
            contaCorrente.Sacar(500);
            Console.WriteLine("Saldo da conta corrente após saque: " + contaCorrente.Saldo);

            ContaPoupanca contaPoupanca = new ContaPoupanca();
            contaPoupanca.Depositar(2000);
            Console.WriteLine("Saldo da conta poupança: " + contaPoupanca.Saldo);
            contaPoupanca.Sacar(500);
            Console.WriteLine("Saldo da conta poupança após saque: " + contaPoupanca.Saldo);

        }
    }
}