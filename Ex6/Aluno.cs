// crio a classe aluno
public class Aluno
{
    // atributos
    public String nome;
    public int matricula;
    public String curso;
    public float notas;


    // metodos
    public Aluno(string nome, int matricula, string curso, float notas)
    {
        this.nome = nome;
        this.matricula = matricula;
        this.curso = curso;
        this.notas = notas;
    }

    public string VerificarSituacao()
    {
        if (notas >= 7)
        {
            return "Aprovado";
        }
        else
        {
            return "Reprovado";
        }

    }


    public void ExibirDados()
    {
        Console.WriteLine("Dados do aluno: ");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Matricula: {matricula}");
        Console.WriteLine($"Curso: {curso}");
        Console.WriteLine($"Media do aluno: {notas}");
    }
}



