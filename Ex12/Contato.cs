// crio a class contato
public class Contato
{
    // atributos, getters e setters
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }

    // construtor
    public Contato(string nome, string telefone, string email)
    {
        Nome = nome;
        Telefone = telefone;
        Email = email;
    }
}

// classe pra formatar os contatos
public abstract class ContatoFormatter
{
    public abstract void ExibirContatos(List<Contato> contatos);
}

// Formata em Markdown
public class MarkdownFormatter : ContatoFormatter
{
    public override void ExibirContatos(List<Contato> contatos)
    {
        Console.WriteLine("## Lista de Contatos\n");

        foreach (var contato in contatos)
        {
            Console.WriteLine($"- **Nome:** {contato.Nome}");
            Console.WriteLine($"- 📞 Telefone: {contato.Telefone}");
            Console.WriteLine($"- 📧 Email: {contato.Email}\n");
        }
    }
}

// Formata em Tabela
public class TabelaFormatter : ContatoFormatter
{
    public override void ExibirContatos(List<Contato> contatos)
    {
        int nomeWidth = 20;
        int telefoneWidth = 15;
        int emailWidth = 30;

        foreach (var contato in contatos)
        {
            nomeWidth = Math.Max(nomeWidth, contato.Nome.Length + 2);
            emailWidth = Math.Max(emailWidth, contato.Email.Length + 2);
        }

        string linhaDivisoria = new string('-', nomeWidth + telefoneWidth + emailWidth + 4);
        Console.WriteLine(linhaDivisoria);


        Console.Write($"| {"Nome".PadRight(nomeWidth)}");
        Console.Write($"| {"Telefone".PadRight(telefoneWidth)}");
        Console.WriteLine($"| {"Email".PadRight(emailWidth)}|");

        Console.WriteLine(linhaDivisoria);

        foreach (var contato in contatos)
        {
            Console.Write($"| {contato.Nome.PadRight(nomeWidth)}");
            Console.Write($"| {contato.Telefone.PadRight(telefoneWidth)}");
            Console.WriteLine($"| {contato.Email.PadRight(emailWidth)}|");
        }

        Console.WriteLine(linhaDivisoria);
    }
}

// Formata em Texto Puro
public class RawTextFormatter : ContatoFormatter
{
    public override void ExibirContatos(List<Contato> contatos)
    {
        foreach (var contato in contatos)
        {
            Console.WriteLine($"Nome: {contato.Nome} | Telefone: {contato.Telefone} | Email: {contato.Email}");
        }
    }
}