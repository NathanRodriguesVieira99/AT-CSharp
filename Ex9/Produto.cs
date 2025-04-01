class Produto
{
    public string Nome { get; }
    public int Quantidade { get; }
    public decimal Preco { get; }

    public Produto(string nome, int quantidade, decimal preco)
    {
        Nome = nome;
        Quantidade = quantidade;
        Preco = preco;
    }

    public override string ToString()
    {
        return $"Produto: {Nome} | Quantidade: {Quantidade} | Preço: R$ {Preco:N2}";
    }
}