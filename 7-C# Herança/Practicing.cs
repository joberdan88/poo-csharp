/*public class Pessoa
{
    public string Nome { get; }
    public int Idade { get; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}

public class ClienteVip : Pessoa
{
    public string NivelFidelidade { get; }
    public string CodigoVip { get; }

    public ClienteVip(string nome, int idade, string nivelFidelidade, string codigoVip)
        : base(nome, idade)
    {
        NivelFidelidade = nivelFidelidade;
        CodigoVip = codigoVip;
    }

    public void ExibirInfo()
    {
        Console.WriteLine($"Bem-vindo, cliente VIP: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Nível de fidelidade: {NivelFidelidade}");
        Console.WriteLine($"Código VIP: {CodigoVip}");
        Console.WriteLine();
    }
}*/

//2:
/*public class Funcionario
{
    public string Nome { get; }
    public string Cargo { get; }

    public Funcionario(string nome, string cargo)
    {
        Nome = nome;
        Cargo = cargo;
    }
}

public class Freelancer : Funcionario
{
    public decimal ValorProjeto { get; }

    public Freelancer(string nome, string cargo, decimal valorProjeto)
        : base(nome, cargo)
    {
        ValorProjeto = valorProjeto;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Freelancer {Nome} - Cargo {Cargo} - Projeto atual: R$ {ValorProjeto:F2}");
    }
}

public class Interno : Funcionario
    {
        public decimal Salario { get; }

        public Interno(string nome, string cargo, decimal salario)
            : base(nome, cargo)
        {
            Salario = salario;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Funcionária {Nome} - Cargo: {Cargo} - Salário R$ {Salario:F2}");
        }
    }*/

//3:
/*public class Pessoa
{
    public string Nome { get; }
    public int Idade { get; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}

public class Passageiro : Pessoa
{
    public int QuantidadedeBilhetes { get; }

    public Passageiro(string nome, int idade, int quantidadedeBilhetes)
        : base(nome, idade)
    {
        QuantidadedeBilhetes = quantidadedeBilhetes;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Passageiro: {Nome} - Idade: {Idade} - Bilhetes: {QuantidadedeBilhetes}");      
    }

}*/

//4
/*public abstract class Profissao
{
    public string Titulo { get; }

    protected Profissao(string titulo)
    {
        Titulo = titulo;
    }
}

public class Analista : Profissao
{
    public Analista(string titulo)
        : base(titulo)
    {
        
    }
}

public class Docente : Profissao
{
    public Docente(string titulo) : base(titulo) { }
}

public class Certificado
{
    public Certificado(Profissao profissao)
    {
        Console.WriteLine($"Certificado emitido para {profissao.Titulo}");
    }
}*/

//5:
/*public class ItemDigital
{
    public string Titulo { get; }

    public ItemDigital(string titulo)
    {
        Titulo = titulo;
    }
}

public class Pergaminho : ItemDigital
{
    public string Conteudo { get; }

    public Pergaminho(string titulo, string conteudo)
        : base(titulo)
    {
        Conteudo = conteudo;
    }

    public void MostrarDetalhes()
    {
        Console.WriteLine($"Detalhes do Pergaminho:");
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Descrição: {Conteudo}");
    }
}*/

//6:
/*public interface ISensor
{
    void Ativar();
    void Desativar();
}

public class SensorTemperatura : ISensor
{
    public void Ativar()
    {
        Console.WriteLine($"Sensor de temperatura ativado.");
    }

    public void Desativar()
    {
        Console.WriteLine($"Sensor de temperatura desativado.");
    }
}

public class SensorPresenca : ISensor
{
    public void Ativar()
    {
        Console.WriteLine($"Sensor de presença ativado.");
    }

    public void Desativar()
    {
        Console.WriteLine($"Sensor de presença desativado.");
    }
}*/

//7:
/*public class Processador
{
    public string Marca { get; }
    public string Modelo { get; }

    public Processador(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }
}

public class PlacaMae
{
    public string Fabricante { get; }
    public string Socket { get; }

    public PlacaMae(string fabricante, string socket)
    {
        Fabricante = fabricante;
        Socket = socket;
    }
}

public class Computador
{
    private Processador processador;
    private PlacaMae placaMae;

    public Computador(Processador processador, PlacaMae placaMae)
    {
        this.processador = processador;
        this.placaMae = placaMae;
    }

    public void ExibirConfiguracao()
    {
        Console.WriteLine($"Computador configurado com:");
        Console.WriteLine($"Processador: {processador.Marca} - {processador.Modelo}");
        Console.WriteLine($"Placa-mãe: {placaMae.Fabricante} - {placaMae.Socket}");       
    }
}*/

//8:
/*public class Pessoa
{
    public string Nome { get; }
    public string Email { get; }

    public Pessoa(string nome, string email)
    {
        Nome = nome;
        Email = email;
    }
}

public interface IPagamento
{
    void ProcessarPagamento();    
}

public class PagamentoCredito : Pessoa, IPagamento
{
    public PagamentoCredito(string nome, string email)
        : base(nome, email)
    {
    }

    public void ProcessarPagamento()
    {
        Console.WriteLine($"Processando pagamento com cartão de crédito para {Nome} - {Email}");
    }
}

public class PagamentoBoleto : Pessoa, IPagamento
{
    public PagamentoBoleto(string nome, string email)
        : base(nome, email)
    {

    }

    public void ProcessarPagamento()
    {
        Console.WriteLine($"Processando pagamento via boleto para {Nome} - {Email}");
    }
}*/

//9:
/*public interface IServico
{
    void ExecutarServico();
}

public class Funcionario
{
    public string Nome { get; }
    public string Departamento { get; }

    public Funcionario(string nome, string departamento)
    {
        Nome = nome;
        Departamento = departamento;
    }
}

public class Manutencao : IServico
{
    private string Tarefa;
    private Funcionario Responsavel;

    public Manutencao(string tarefa, Funcionario responsavel)
    {
        Tarefa = tarefa;
        Responsavel = responsavel;
    }

    public void ExecutarServico()
    {
        Console.WriteLine($"Executando serviço de manutenção: {Tarefa}");
        Console.WriteLine($"Nome: {Responsavel.Nome} - Departamento: {Responsavel.Departamento}");
        Console.WriteLine();
    }
}

public class Consultoria : IServico
{
    private string Tarefa;
    private Funcionario Responsavel;

    public Consultoria(string tarefa, Funcionario responsavel)
    {
        Tarefa = tarefa;
        Responsavel = responsavel;
    }

    public void ExecutarServico()
    {
        Console.WriteLine($"Executando serviço de consultoria: {Tarefa}");
        Console.WriteLine($"Responsável: {Responsavel.Nome} - Departamento: {Responsavel.Departamento}");
    }
}*/

//10:
public interface ICurso
{
    void ValidarConteudo();
    void PublicarCurso();
}

public class Instrutor
{
    public string Nome { get; }
    public string Especialidade { get; }

    public Instrutor(string nome, string especialidade)
    {
        Nome = nome;
        Especialidade = especialidade;
    }
}

public class CursoProgramacao : ICurso
{
    private string Titulo;
    private Instrutor Instrutor;

    public CursoProgramacao(string titulo, Instrutor instrutor)
    {
        Titulo = titulo;
        Instrutor = instrutor;
    }

    public void ValidarConteudo()
    {
        Console.WriteLine($"Validando conteúdo do curso de programação: {Titulo}");
    }

    public void PublicarCurso()
    {
        Console.WriteLine($"Curso publicado com sucesso: {Titulo} - Instrutora: {Instrutor.Nome} ({Instrutor.Especialidade})");
        Console.WriteLine();
    }
}

public class CursoDesign : ICurso
{
    private string Titulo;
    private Instrutor Instrutor;

    public CursoDesign(string titulo, Instrutor instrutor)
    {
        Titulo = titulo;
        Instrutor = instrutor;
    }

    public void ValidarConteudo()
    {
        Console.WriteLine($"Validando conteúdo do curso de design: {Titulo}");
    }

    public void PublicarCurso()
    {
        Console.WriteLine($"Curso publicado com sucesso: {Titulo} - Instrutor: {Instrutor.Nome} ({Instrutor.Especialidade})");

    }
}

