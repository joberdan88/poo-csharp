/*public class Veiculo
{
    public string Placa { get; }
    private double velocidadeAtual;

    public Veiculo(string placa)
    {
        Placa = placa;
        velocidadeAtual = 0;
    }

    public double VelocidadeAtual
    {
        get { return velocidadeAtual; }
    }

    public void AtualizarVelocidade(double novaVelocidade)
    {
        if (VelocidadeAtual >= 0)
        {
            VelocidadeAtual = novaVelocidade;
        }
        else
        {
            Console.WriteLine("A velocidade não pode ser negativa.");
        }
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Veículo: {Placa}");
        Console.WriteLIne($"Velocidade Atual: {VelocidadeAtual}km/h");
    }
}

class Program
{
    static void Main()
    {
        Veiculo veiculo = new Veiculo("ABC-1234");
        veiculo.AtualizarVelocidade(72.5);
        veiculo.ExibirDetalhes();
    }
}*/


//2
/*public class Avaliacao
{
    public string Aluno { get; }
    public double Nota { get; set; }

    public Avaliacao(string aluno)
    {
        Aluno = aluno;
        Nota = 0;
    }

    public void AtribuirNota(double novaNota)
    {
        if (novaNota >= 0)
        {
            Nota = novaNota;
        }
        else
        {
            Console.WriteLine("A nota deve estar entre 0 e 10.");
        }
    }
}*/

//3
/*public class Paciente
{
    public string Nome { get; }
    public int Idade { get; }

    public Paciente(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Paciente: {Nome}, Idade: {Idade}");
    }
}

internal class HistoricoMedico
{
    private string CodigoProntuario { get; }
    public HistoricoMedico(string codigo)
    {
        CodigoProntuario = codigo;
    }

    public void ExibirCodigo()
    {
        Console.WriteLine($"Código do prontuário: {CodigoProntuario}");
    }
}

class Program
{
    static void Main()
    {
        Paciente paciente = new Paciente("Luiz Costa", 42);
        HistoricoMedico historico = new HistoricoMedico("XPT-9987");

        paciente.ExibirDetalhes();
        historico.ExibirCodigo();
        
    }
}*/

//4
/*public class Funcionario
{
    public string Nome { get; }
    private double Salario;

    public Funcionario(string nome, double salarioInicial)
    {
        Nome = nome;
        Salario = salarioInicial;
    }

    public void ReajustarSalario(double novoValor)
    {
        if (novoValor > salario)
        {
            salario = novoValor;
        }
        else
        {
            Console.WriteLine("O novo salário deve ser maior que o salário atual.");
        }
    }

    public double Salario
    {
        get { return salario; }
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Funcioário: {Nome} ");
        Console.WriteLine($"Salário atual: R${Salario:F2}");
    }
}

class Program
{
    static void Main()
    {
        Funcionario f = new Funcionario("Fernanda Lima", 4000);
        f.ReajustarSalario(3500); // Inválido
        f.ReajustarSalario(4200); // Válido
        f.ExibirDetalhes();
    }
}*/

//5
/*public class Projeto
{
    public string Nome { get; }
    private List<string> tarefas;

    public Projeto(string nome, string tarefas)
    {
        Nome = nome;
        tarefas = new List<string>();
    }

    public void AdicionarTarefa(string tarefa)
    {
        tarefas.Add(tarefa);
    }

    public void QuantidadeTarefas
    {
        get { return tarefas.Count; }
    }

    public void ExibirTarefas()
    {
        Console.WriteLine($"Projeto: {Nome}");
        Console.WriteLine("Tarefas:");
        foreach (string tarefa in tarefas)
        {
            Console.WriteLine($"- {tarefa}");
        }
        Console.WriteLine($"Total{QuantidadeTarefas} tarefas");
    }
}

class Program
{
    static void Main()
    {
        Projeto projeto = new Projeto("Sistema de Inventário");
        projeto.AdicionarTarefa("Criar tela de login");
        projeto.AdicionarTarefa("Implementar banco de dados");
        projeto.ExibirTarefas();
        projeto.ExibirDetalhes();
    }
}*/

//6
/*public class ContaBancaria
{
    public string Titular { get; }
    private double saldo;
    private SegurancaConta seguranca;

    public double Saldo
    {
        get { return saldo; }
    }

    public ContaBancaria(string titular, double saldoInicial)
    {
        Titular = titular;
        saldo = saldoInicial;
        seguranca = new SegurancaConta();
    }

    public void Sacar(double valor)
    {
        if (seguranca.ValidarSaque(valor))
        {
            saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso.");
            Console.WriteLine($"Saldo atual: {saldo:F2}");
        }
        else
        {
            Console.WriteLine("Saque negado pela política de segurança.");
        }
    }

    internal class SegurancaConta
    {
        public bool ValidarSaque(double valor)
        {
            return valor <= 1000;
        }
    }
}

class Program
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria("Carlos Silva", 2500);
        conta.Sacar(1500); // inválido
        conta.Sacar(800);  // válido
    }
}*/

//7
/*public class Contato
{
    public string Nome { get; }
    public string Telefone { get; }

    public Contato(string nome, string telefone)
    {
        Nome = nome;
        Telefone = telefone;
    }

}

public class Agenda
{
    public string Proprietario { get; }
    private readonly List<Contato> contatos;

    public int QuantidadeContatos
    {
        get { return contatos.Count; }
    }

    public Agenda(string proprietario)
    {
        Proprietario = proprietario;
        contatos = new List<Contato>();
    }

    //Methods
    public bool AdicionarContato(Contato contato)
    {
        foreach (Contato c in contatos)
        {
            if (c.Nome == contato.Nome)
            {
                Console.WriteLine("Contato já existe.");
                return false;
            }
        }
        contatos.Add(contato);
        return true;
    }

    public void ListarContatos()
    {
        Console.WriteLine($"Agenda de: {Proprietario}");
        Console.WriteLine($"Contatos: ");
        foreach (Contato c in contatos)
        {
            Console.WriteLine($"- {c.Nome} | {c.Telefone}");
        }
        Console.WriteLine($"Total de contatos: {QuantidadeContatos}");
    }
}

class Program
{
    static void Main()
    {
        Agenda agenda = new Agenda("Marina Souza");
        agenda.AdicionarContato(new Contato("Carlos", "11998887777"));
        agenda.AdicionarContato(new Contato("Carlos", "11991112222")); // duplicado
        agenda.AdicionarContato(new Contato("Julia", "21988776655"));
        agenda.ListarContatos();
    }
}*/

//8
/*public class Estudante
{
    public string Nome { get; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }

    public double Media
    {
        get { return (Nota1 + Nota2) / 2; }
    }

    public string Situacao
    {
        get { return Media >= 6 ? "Aprovado" : "Reprovado"; }
    }

    //Construtor
    public Estudante(string nome)
    {
        Nome = nome;
        Nota1 = 0;
        Nota2 = 0;
    }

    public void ExibirBoletim()
    {
        Console.WriteLine($"Estudante: {Nome}");
        Console.WriteLine($"Média: {Media:F2}");
        Console.WriteLine($"Situação: {Situacao}");
    }
}

class Program
{
    static void Main()
    {
        Estudante estudante = new Estudante("Lucas Rocha");
        estudante.Nota1 = 7.5;
        estudante.Nota2 = 5.0;
        estudante.ExibirBoletim();
    }
}*/

//9
/*public class Estudante
{
    public string Nome { get; }

    public Estudante(string nome)
    {
        Nome = nome;
    }
}

public class Curso
{
    public string Nome { get; }
    public int VagasTotais { get; }
    private List<Estudante> matriculas;

    public Curso(string nome, int vagasTotais)
    {
        Nome = nome;
        VagasTotais = vagasTotais;
        matriculas = new List<Estudante>();
    }

    public int VagasDisponiveis
    {
        get { return VagasTotais - matriculas.Count; }
    }

    public bool Matricular(Estudante estudante)
    {
        if (VagasDisponiveis > 0)
        {
            matriculas.Add(estudante);
            Console.WriteLine("Estudante matriculado com sucesso!");
            return true;
        }
        else
            Console.WriteLine("Erro: Não há vagas disponíveis.");
        return false;
    }

    public void ListarMatriculados()
    {
        Console.WriteLine($"Estudantes matriculados em {Nome}:");
        foreach (Estudante estudante in matriculas)
        {
            Console.WriteLine($"- {estudante.Nome}");
        }
        Console.WriteLine($"Vagas disponíveis: {VagasDisponiveis}");
    }
}

class Program
{
    static void Main()
    {
        Curso curso = new Curso("Lógica de Programação", 2);
        curso.Matricular(new Estudante("Rafaela"));
        curso.Matricular(new Estudante("João"));
        curso.Matricular(new Estudante("Mirela")); // excede o limite
        curso.ListarMatriculados();
    }
}*/

//10
/*public class Hospede
{
    public string Nome { get; }

    public Hospede(string nome)
    {
        Nome = nome;
    }
}

public class Quarto
{
    public int Numero { get; }
    private double valorDiaria;

    public double ValorDiaria
    {
        get { return valorDiaria; }
        set
        {
            if (value > 0)
            {
                valorDiaria = value;
            }
            else
            {
                throw new ArgumentException("O valor da diária deve ser positivo.");
            }
        }
    }

    public Quarto(int numero)
    {
        Numero = numero;
        valorDiaria = 1;
    }
}

public class Reserva
{
    private int diarias;
    public Hospede Hospede { get; }
    public Quarto Quarto { get; }

    public double ValorTotal
    {
        get { return Quarto.ValorDiaria * diarias; }
    }

    public Reserva(Hospede hospede, Quarto quarto, int diarias)
    {
        if (diarias <= 0)
        {
            throw new ArgumentException("A quantidade de diárias deve ser maior que zero.");
        }

        Hospede = hospede;
        Quarto = quarto;
        this.diarias = diarias;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Reserva para: {Hospede.Nome}");
        Console.WriteLine($"Quarto: {Quarto.Numero}");
        Console.WriteLine($"Valor total: R${ValorTotal:F2}");
    }
}

class Program
{
    static void Main()
    {
        Hospede hospede = new Hospede("Juliana Moura");
        Quarto quarto = new Quarto(101);
        quarto.ValorDiaria = 250;

        Reserva reserva = new Reserva(hospede, quarto, 3);
        reserva.ExibirDetalhes();
    }
}*/


