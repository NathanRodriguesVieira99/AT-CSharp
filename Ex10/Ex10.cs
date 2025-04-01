class Ex10
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 51);
        int tentativas = 5;

        Console.WriteLine("Adivinhe um numero entre 1 e 50🎲: ");

        while (tentativas > 0)
        {
            Console.Write($"Você ainda tem {tentativas} tentativas");
            Console.Write("\n");

            try
            {
                int palpite = int.Parse(Console.ReadLine());

                if (palpite < 1 || palpite > 50)
                {
                    Console.WriteLine("O número deve estar entre 1 e 50.");
                    continue;
                }

                if (palpite == numeroSecreto)
                {
                    Console.WriteLine("Você adivinhou o numero secreto!");
                    return;
                }
                else if (palpite < numeroSecreto)
                {
                    Console.WriteLine("O número é maior!");
                }
                else
                {
                    Console.WriteLine("O número é menor!");
                }

                tentativas--;
            }
            catch (FormatException)
            {
                Console.WriteLine("Digite um número válido.");
            }
        }

        Console.WriteLine($"Acabram as chances, o número secreto era {numeroSecreto}.");
    }
}
