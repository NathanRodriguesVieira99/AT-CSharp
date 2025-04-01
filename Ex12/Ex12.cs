class Ex12
{
    public static void Main(string[] args)
    {
        // lista dos contatos
        List<Contato> contatos = new List<Contato>
{
    new Contato("Nt", "(21) 9999-8888", "nathan.vieira@eal.infnet.edu.br"),
    new Contato("Piu Careca", "(21) 6666-7777", "piu@gmail.com")
};

        ContatoFormatter formatter;

        // Usando Markdown
        Console.WriteLine("Markdown");
        formatter = new MarkdownFormatter();
        formatter.ExibirContatos(contatos);

        // Usando Tabela
        Console.WriteLine("Tabela");
        formatter = new TabelaFormatter();
        formatter.ExibirContatos(contatos);

        // Usando Texto Puro
        Console.WriteLine("Texto Puro");
        formatter = new RawTextFormatter();
        formatter.ExibirContatos(contatos);
    }
}