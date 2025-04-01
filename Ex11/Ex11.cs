using System;
using System.IO;
using System.Collections.Generic;

class Ex11
{
    static void Main(string[] args)
    {
        // caminho do arquivo onde salva os contatos 
        string arquivoContatos = "contatos.txt";


        while (true)
        {
            // Exibe o menu de opções
            ExibirMenu();

            // roda a opção escolhida pelo usuário
            string opcao = Console.ReadLine();


            switch (opcao)
            {
                // add ncontato
                case "1":
                    AdicionarContato(arquivoContatos);
                    break;
                // lista contatos 
                case "2":
                    ListarContatos(arquivoContatos);
                    break;
                // sair 
                case "3":
                    Console.WriteLine("Encerrando...");
                    return;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Console.WriteLine();
        }
    }

    // exibir o menu de opções
    static void ExibirMenu()
    {
        Console.WriteLine("Gerenciador de Contatos");
        Console.WriteLine("1 - Adicionar novo contato");
        Console.WriteLine("2 - Listar contatos cadastrados");
        Console.WriteLine("3 - Sair");
        Console.Write("Escolha uma opção: ");
    }

    //  adicionar um novo contato ao arquivo txt
    static void AdicionarContato(string caminhoArquivo)
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Telefone: ");
        string telefone = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        // valida se todos os campos foram preenchidos
        if (string.IsNullOrWhiteSpace(nome) ||
            string.IsNullOrWhiteSpace(telefone) ||
            string.IsNullOrWhiteSpace(email))
        {
            Console.WriteLine("Todos os campos devem ser preenchidos!");
            return;
        }

        try
        {
            using (StreamWriter sw = new StreamWriter(caminhoArquivo, true))
            {
                sw.WriteLine($"{nome},{telefone},{email}");
            }
            Console.WriteLine("Contato cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao salvar contato: {ex.Message}");
        }
    }

    // listar todos os contatos
    static void ListarContatos(string caminhoArquivo)
    {
        // Verifica se o arquivo existe
        if (!File.Exists(caminhoArquivo))
        {
            Console.WriteLine("Nenhum contato cadastrado.");
            return;
        }

        try
        {
            string[] linhas = File.ReadAllLines(caminhoArquivo);

            // Verifica se há contatos cadastrados
            if (linhas.Length == 0)
            {
                Console.WriteLine("Nenhum contato cadastrado.");
                return;
            }
            Console.WriteLine("Contatos cadastrados:");
            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(',');

                if (partes.Length == 3)
                {

                    Console.WriteLine($"Nome: {partes[0]} | Telefone: {partes[1]} | Email: {partes[2]}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao ler contatos: {ex.Message}");
        }
    }
}