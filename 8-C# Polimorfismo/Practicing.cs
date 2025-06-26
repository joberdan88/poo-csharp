//2
/*public class Funcionario
{
    public virtual string GerarRelatorio()
    {
        return "Relatório genérico do funcionário.";
    }
}

public class Gerente : Funcionario
{
    public override string GerarRelatorio()
    {
        return "Relatório do gerente: supervisiona a equipe.";
    }
}

public class Desenvolvedor : Funcionario
{
    public override global::System.String GerarRelatorio()
    {
        return "Relatório do desenvolvedor: escreve código e corrige bugs.";
    }
}*/

//3
/*public interface INotificacao
{
    void EnviarMensagem(string mensagem);
}

public class EmailNotificacao : INotificacao
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando E-MAIL: {mensagem}");
    }
}

public class SmsNotificacao : INotificacao
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando SMS {mensagem}");
    }
}

public class PushNotificacao : INotificacao
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando PUSH {mensagem}");
    }
}*/

//4
/*public abstract class TarefaAgendada
{
    public abstract void Executar();
}

public class BackupTarefa : TarefaAgendada
{
    public override void Executar()
    {
        Console.WriteLine("Executando tarefa de backup do sistema...");
    }
}

public class RelatorioTarefa : TarefaAgendada
{
    public override void Executar()
    {
        Console.WriteLine("Gerando e enviando relatório diário...");
    }
}

public class LimpezaTarefa : TarefaAgendada
{
    public override void Executar()
    {
        Console.WriteLine("Limpando arquivos temporários do servidor...");
    }
}*/

//5
/*public class Midia
{
    public string Nome { get; }

    public Midia(string nome)
    {
        Nome = nome;
    }

    public virtual void ExibirDetalhes()
    {
        Console.WriteLine($"Mídia: {Nome}");
    }
}

public class Imagem : Midia
{
    public string Resolucao { get; }

    public Imagem(string nome, string resolucao) : base(nome)
    {
        Resolucao = resolucao;
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Imagem: {Nome} - Resolução: {Resolucao}");
    }
}

public class Video : Midia
{
    public int Duracao { get; }

    public Video(string nome, int duracao) : base(nome)
    {
        Duracao = duracao;
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Vídeo: {Nome} - Duração {Duracao} minutos.");
    }
}*/

//6
/*public class Reserva
{
    public string Nome { get; }

    public Reserva(string nome)
    {
        Nome = nome;
    }

    public virtual void Confirmar()
    {
        Console.WriteLine($"Confirmando reserva: {Nome}");
    }
}

public class ReservaPresencial : Reserva
{
    public ReservaPresencial(string nome) : base(nome) { }

    public override void Confirmar()
    {
        Console.WriteLine($"Confirmado reserva presencial {Nome}");
        Console.WriteLine($"Praça Central, às 8h");
    }
}

public class ReservaOnline : Reserva
{
    public ReservaOnline(string nome) : base(nome) { }

    public override void Confirmar()
    {
        Console.WriteLine($"Confirmando reserva online: {Nome}");
        Console.WriteLine("Link de acesso enviado por e-mail!");
    }
}*/

//7
/*public class Conteudo
{
    public string Titulo { get; }

    public Conteudo(string titulo)
    {
        Titulo = titulo;
    }

    public virtual void ExibirInfo()
    {
        Console.WriteLine($"Título: {Titulo}");
    }
}

public class AulaGravada : Conteudo
{
    public int Duracao { get; }

    public AulaGravada(string titulo, int duracao) : base(titulo)
    {
        Duracao = duracao;
    }

    public override void ExibirInfo()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Duração: {Duracao} min\n");
    }
}

public class MaterialComplementar : Conteudo
{
    public int NumeroDePaginas { get; }

    public MaterialComplementar(string titulo, int numeroDePaginas) : base(titulo)
    {
        NumeroDePaginas = numeroDePaginas;
    }

    public override void ExibirInfo()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Páginas: {NumeroDePaginas}\n");
    }
}*/

//8
/*public class Transporte
{
    public virtual int CalcularTempo(int distanciaKm)
    {
        return 0;
    }
}

public class Onibus : Transporte
{
    public override int CalcularTempo(int distanciaKm)
    {
        return (distanciaKm * 2) + 5;
    }
}

public class Metro : Transporte
{
    public override int CalcularTempo(int distanciaKm)
    {
        return distanciaKm + 5;
    }
}

public class Bicicleta : Transporte
{
    public override int CalcularTempo(int distanciaKm)
    {
        return distanciaKm * 4;
    }
}*/

//9
/*public interface IEmprestimo
{
    decimal CalcularValorFinal(decimal valor, int meses);
}

public class EmprestimoEstudante : IEmprestimo
{
    public decimal CalcularValorFinal(decimal valor, int meses)
    {
        decimal taxa = 0.01m;
        return valor = valor + (valor * taxa * meses);
    }
}

public class EmprestimoEmpresario : IEmprestimo
{
    public decimal CalcularValorFinal(decimal valor, int meses)
    {
        decimal taxa = 0.025m;
        return valor = valor + (valor * taxa * meses);
    }
}

public class EmprestimoAposentado : IEmprestimo
{
    public decimal CalcularValorFinal(decimal valor, int meses)
    {
        decimal taxa = 0.015m;
        return valor = valor + (valor * taxa * meses);
    }
}*/

//10
public interface IAcaoBotao
{
    void Executar();
}

public class SalvarAcao : IAcaoBotao
{
    public void Executar()
    {
        Console.WriteLine("Salvando dados no banco...");
    }
}

public class EditarAcao : IAcaoBotao
{
    public void Executar()
    {
        Console.WriteLine("Editando informações do cadastro...");
    }
}

public class ExcluirAcao : IAcaoBotao
{
    public void Executar()
    {
        Console.WriteLine("Excluindo registro do sistema...");
    }
}