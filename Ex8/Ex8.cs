class Ex8
{
    static void Main(string[] args)
    {
        Funcionario funcionario = new Funcionario("Nathan Vieira", "Desenvolvedor Back-End", 5000.00);

        funcionario.ExibirInformacoes();

        Gerente gerente = new Gerente("José Maicon", 10000.00);
        gerente.ExibirInformacoes();

    }
}