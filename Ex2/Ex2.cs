class Ex2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe seu nome: ");
        string name = Console.ReadLine();

        string nameLetrasDeslocadas = deslocaLetra(name, 3);

        Console.WriteLine($"Seu nome com as letras deslocadas: {nameLetrasDeslocadas}");
    }

    static string deslocaLetra(String letra, int desloca)
    {
        String nameLetrasDeslocadas = "";

        foreach (char a in letra)

        {
            if (char.IsLetter(a))
            {
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
