class Ex2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe seu nome: ");
        string name = Console.ReadLine();

        // chama a função de deslocar a letra em 3 posições
        string nameLetrasDeslocadas = deslocaLetra(name, 3);

        Console.WriteLine($"Seu nome com as letras deslocadas: {nameLetrasDeslocadas}");
    }

    // essa é a função que desloca as letras
    static string deslocaLetra(String letra, int desloca)
    {
        String nameLetrasDeslocadas = "";

        // percorre cada letra
        foreach (char a in letra)

        {
            if (char.IsLetter(a))
            {
                // verifica se a inicial é maiuscula
                char letraInicial = char.IsUpper(a) ? 'A' : 'a';


                char letraDeslocada = (char)(letraInicial + ((a + desloca - letraInicial) % 26));
                nameLetrasDeslocadas += letraDeslocada;
            }

            else
            {
                nameLetrasDeslocadas += a;
            }

        }
        return nameLetrasDeslocadas;
    }
}
