public class Hospede
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
}