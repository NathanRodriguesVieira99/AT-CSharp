class Ex3
{

    static void Main(string[] args)
    {
        Console.WriteLine("CALCULADORA");
        Console.WriteLine("============");

        // pergunta os numeros ao usuário
        double num1 = pegaNum("Digite o primeiro número: ");
        double num2 = pegaNum("Digite o segundo número: ");


        Console.WriteLine("\nQual a operação: ");
        Console.WriteLine("1 - SOMA");
        Console.WriteLine("2 - SUBTRAÇÃO");
        Console.WriteLine("3 - MULTIPLICAÇÃO");
        Console.WriteLine("4 - DIVISÃO");

        // pega a operação 
        int operacaoMatematica = operacao();

        // faz o cálculo 
        Calcular(num1, num2, operacaoMatematica);
    }

    // valida os numeros escolhidos
    static double pegaNum(string mensagem)
    {
        double num;
        while (true)
        {
            Console.Write(mensagem);
            if (double.TryParse(Console.ReadLine(), out num))
            {
                return num;
            }
            else
            {
                Console.WriteLine("Numero inválido!");
            }
        }
    }

    // escolhe a operação
    static int operacao()
    {
        int op;
        while (true)
        {
            Console.Write("Digite o número da operação: ");
            if (int.TryParse(Console.ReadLine(), out op) && op >= 1 && op <= 4)
            {
                return op;
            }
            else
            {
                Console.WriteLine("Operação inválida!");
            }
        }
    }

    // faz o cálculo baseado na operação escolhida
    static void Calcular(double num1, double num2, int operacao)
    {
        double resultado = 0;
        string simboloOperacao = "";
        string nomeOperacao = "";

        try
        {
            switch (operacao)
            {
                // Soma
                case 1:
                    resultado = num1 + num2;
                    simboloOperacao = "+";
                    nomeOperacao = "SOMA";
                    break;
                // Subtração
                case 2:
                    resultado = num1 - num2;
                    simboloOperacao = "-";
                    nomeOperacao = "SUBTRAÇÃO";
                    break;
                // Multiplicação
                case 3:
                    resultado = num1 * num2;
                    simboloOperacao = "x";
                    nomeOperacao = "MULTIPLICAÇÃO";
                    break;
                // Divisão
                case 4:
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    resultado = num1 / num2;
                    simboloOperacao = "÷";
                    nomeOperacao = "DIVISÃO";
                    break;
            }

            // Exibe o resultado 
            Console.WriteLine($"\n{nomeOperacao}: {num1} {simboloOperacao} {num2} = {resultado}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("\nERRO: Não é possível dividir por zero!");
        }
    }
}