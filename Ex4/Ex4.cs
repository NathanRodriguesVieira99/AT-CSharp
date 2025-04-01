class Ex4
{
    static void Main()
    {
        // armazena os valores
        DateTime dataNascimento;
        DateTime dataAtual = DateTime.Now;
        DateTime proximoAniversario;

        // solicita a data ao usuario
        Console.WriteLine("Informe sua data de nascimento: ");
        dataNascimento = DateTime.Parse(Console.ReadLine());


        proximoAniversario = new DateTime(dataAtual.Year, dataNascimento.Month, dataNascimento.Day);

        // veriica se o aniversario ja aconteceu
        if (proximoAniversario < dataAtual)
        {
            proximoAniversario = proximoAniversario.AddYears(1);
        }

        TimeSpan diasAniversario = proximoAniversario - dataAtual;

        // verifica se faltam 7 dias 
        if (diasAniversario.Days <= 7)
        {
            Console.WriteLine($"faltam só {diasAniversario.Days} dias até seu  aniversario!");
        }

        else
        {
            Console.WriteLine($"faltam {diasAniversario.Days} dias para seu aniversario");

        }
    }
}