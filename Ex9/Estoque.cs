class GerenciadorEstoque
{
    // armazena o caminho do arquivo que ira surgir
    private const string CaminhoArquivo = "estoque.txt";

    // cria uma lista do "tipo" produto
    private List<Produto> listaProdutos = new List<Produto>();

    // salvo o limite de produtos
    private const int LimiteProdutos = 5;

    // função para executar a função de mostrar os produtos 
    public void Executar()
    {
        CarregarProdutos();

        // se carregar acontece isso
        while (true)
        {
            Console.WriteLine("Menu de Opções:");
            Console.WriteLine("------------------");
            Console.WriteLine("1. Inserir Produto");
            Console.WriteLine("2. Listar Produtos");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            // surgem 3 opçoes do que fazer com os produtos
            switch (opcao)
            {
                case "1":
                    InserirProduto();
                    break;
                case "2":
                    ListarProdutos();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    private void InserirProduto()
    {
        // se os produtos armazenados na lista forem  maior que 5 da esse erro 
        if (listaProdutos.Count >= LimiteProdutos)
        {
            Console.WriteLine("Limite de produtos atingido!");
            return;
        }

        // exibe o nome
        Console.Write("Nome do Produto: ");
        string nome = Console.ReadLine();

        // exibe a quantidade
        Console.Write("Quantidade em estoque: ");
        if (!int.TryParse(Console.ReadLine(), out int quantidade) || quantidade < 0)
        {
            Console.WriteLine("Quantidade inválida.");
            return;
        }

        // exibe preço
        Console.Write("Preço unitário: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal preco) || preco < 0)
        {
            Console.WriteLine("Preço inválido.");
            return;
        }

        // cria o produto em si e adiciona na lista
        Produto produto = new Produto(nome, quantidade, preco);
        listaProdutos.Add(produto);

        // tenta cadastrar o novo produto e salvar no arquivo
        try
        {
            File.AppendAllText(CaminhoArquivo, $"{nome},{quantidade},{preco}\n");
            Console.WriteLine("Produto cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao salvar produto: {ex.Message}");
            listaProdutos.Remove(produto);
        }
    }

    // exibe todos os produtos
    private void ListarProdutos()
    {
        // ve se tem algum cadastrado, se nao tiver ocorre esse erro
        if (listaProdutos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado.");
            return;
        }

        // se tiver, exibe
        Console.WriteLine("Lista de Produtos Cadastrados:");
        foreach (var produto in listaProdutos)
        {
            Console.WriteLine(produto.ToString());
        }
    }

    // basicamente carrega se tiver o arquivo
    private void CarregarProdutos()
    {
        if (!File.Exists(CaminhoArquivo))
        {
            return;
        }

        try
        {
            string[] linhas = File.ReadAllLines(CaminhoArquivo);
            foreach (string linha in linhas)
            {
                string[] detalhes = linha.Split(',');
                if (detalhes.Length == 3)
                {
                    listaProdutos.Add(new Produto(
                        detalhes[0],
                        int.Parse(detalhes[1]),
                        decimal.Parse(detalhes[2])));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao carregar produtos: {ex.Message}");
        }
    }
}