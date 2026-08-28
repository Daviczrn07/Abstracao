namespace Abstracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria("Joao Souza", 202, 10000);

            Console.WriteLine($"Titular: {conta.Titular}");
            Console.WriteLine($"Numero da conta: {conta.NumeroConta}");
            Console.WriteLine($"saldo: R$ {conta.Saldo}");

            //deposito 100
            conta.Depositar(100);
            Console.WriteLine($"saldo: R$ {conta.Saldo}");


            //saque 500
            conta.Sacar(500);
            Console.WriteLine($"saldo: R$ {conta.Saldo}");






        }
    }
}
