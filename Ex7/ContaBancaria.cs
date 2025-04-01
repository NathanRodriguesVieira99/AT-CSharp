// crio a classe conta bancaria
public class ContaBancaria
{
    // atributos
    public String titular;

    private double saldo;

    // metodos
    public double depositar(double valor)
    {
        if (valor > 0)
        {
            saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor} realizado com secesso!");
        }

        else
        {
            Console.WriteLine("Valor invalido");

        }
        return saldo;

    }


    public double sacar(double valor)
    {
        if (valor > 0)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de R$: {valor} realizado");

            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }
        else
        {
            Console.WriteLine("Valor invalido");
        }
        return saldo;
    }


    public void exibirSaldo()
    {
        Console.WriteLine($"seu saldo é:  R$ {saldo}");
    }
}