// crio a classe funcionario
class Funcionario
{
    // atributos
    private string nome;
    private string cargo;
    private double salarioBase;

    // construtor
    public Funcionario(string nome, string cargo, double salarioBase)
    {
        this.nome = nome;
        this.cargo = cargo;
        this.salarioBase = salarioBase;
    }

    // calcula o salario do funcionario normal 
    public virtual double CalcSalario()
    {
        return salarioBase;
    }

    // exibe os dados
    public void ExibirInformacoes()
    {
        Console.WriteLine("DADOS DO FUNCIONARIO:");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Cargo: {cargo}");
        Console.WriteLine($"Salário: {CalcSalario():C}");
        Console.WriteLine();
    }
}

// crio a classe gerente extendendo a funcionario
class Gerente : Funcionario
{
    // construtor (herdando apenas o nome e salarioBase pois o  cargo coloco um valor "fixo")
    // : base chama o construtor da classe pai e passa os parametros
    public Gerente(string nome, double salarioBase) : base(nome, "Gerente", salarioBase) 
    {
    }

    // calcula o salario com bonus
    public override double CalcSalario()
    {
        double salarioBase = base.CalcSalario();
        double bonus = salarioBase * 0.20;
        return salarioBase + bonus;
    }
}