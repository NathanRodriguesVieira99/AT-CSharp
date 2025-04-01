class Ex5
{
    static void Main(String[] args)
    {
        // pega a data atual
        DateTime dataAtual = DateTime.Now;

        // diz a data da formatura 
        DateTime dataFormatura = new DateTime(2026, 12, 22);

        //  usuário digita a data atual 
        Console.WriteLine("Digite sua data atual: ");
        dataAtual = DateTime.Parse(Console.ReadLine());

        // calcula a diferença entre as datas 
        int diasParaFormatura = dataFormatura.Day - dataAtual.Day;
        int mesesParaFormatura = dataFormatura.Month - dataAtual.Month;
        int anosParaFormatura = dataFormatura.Year - dataAtual.Year;

        // verifica se o ano digitado é valido
        if (dataAtual.Year > dataFormatura.Year)
        {
            Console.WriteLine("Data invalida!");
            return;
        }

        // verifica se a data  é igual ou maior à data da formatura
        if (dataAtual >= dataFormatura)
        {
            Console.WriteLine("Parabéns! (ja era para ter se formado!!)");
            return; 
        }

        // Verifica se faltam menos de 5 meses e 10 dias 
        if (anosParaFormatura == 0 & mesesParaFormatura <= 5 & diasParaFormatura <= 10)
        {
            Console.WriteLine($"Faltam {anosParaFormatura} ano(s), {mesesParaFormatura} meses e {diasParaFormatura} dias para a sua formatura!");
            Console.WriteLine($"A reta final chegou! Prepare-se para a formatura!");
        }
        else
        {
            //  mostra os dias que faltam
            Console.WriteLine($"Faltam {anosParaFormatura} ano(s), {mesesParaFormatura} meses e {diasParaFormatura} dias para sua formatura!");
        }
        Console.ReadKey();
    }
}