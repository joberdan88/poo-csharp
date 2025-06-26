public class Pedido : IExpiravel
{
    private bool pago;
    public int Id { get; }
    public string Cliente { get; }
    public DateTime Data { get; }
    public decimal ValorTotal { get; }
    public List<Produto> Produtos { get; private set; }

    public Pedido(int id, string cliente, decimal valorTotal)
    {
        Id = id;
        Cliente = cliente;
        Data = DateTime.Now;
        ValorTotal = valorTotal;
        pago = false;
        Produtos = new List<Produto>();
    }

    public void ExibirResumo()
    {
        Console.WriteLine($"Pedido #{Id} - Cliente: {Cliente}");
        Console.WriteLine($"Valor Total: R${ValorTotal:F2}");
        Console.WriteLine($"Status: {(EstaExpirado() ? "Expirado" : "Válido")}");

        Console.WriteLine("Produtos do pedido:");
        foreach (var produto in Produtos)
        {
            Console.WriteLine(produto.Nome);
        }
    }

    public bool EstaExpirado()
    {
        return !pago && DateTime.Now > Data.AddMinutes(15);
    }

    public void Pagar()
    {
        pago = true;
    }

    public void AdicionarProduto(Produto produto)
    {
        Produtos.Add(produto);
    }
}