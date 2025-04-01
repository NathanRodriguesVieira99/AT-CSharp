

class Ex6
{
    static void Main(string[] args)
    {
        // crio um novo aluno, exibo seus dados e verifico a situação
        Aluno aluno = new Aluno("Nathan Vieira", 666, "INFNET", 10);

        aluno.ExibirDados();

        Console.WriteLine($"Resultado: {aluno.VerificarSituacao()}");

    }
}