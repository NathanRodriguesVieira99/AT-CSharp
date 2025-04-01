
class Ex7
{
    static void Main(string[] args)
    {
        // crio uma nova conta
        ContaBancaria contaBancaria = new ContaBancaria();

        // exibo os dados e aplico os metodos de deposito e saque
        Console.WriteLine($"Titular da Conta: {contaBancaria.titular = "Nathan Vieira"}");

        contaBancaria.depositar(1000);
        contaBancaria.exibirSaldo();

        contaBancaria.sacar(500);
        contaBancaria.exibirSaldo();
    }
}