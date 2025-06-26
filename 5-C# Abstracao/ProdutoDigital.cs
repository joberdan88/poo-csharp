class ProdutoDigital : Produto, IExpiravel
{
    private string? linkDownload;
    public DateTime DataCompra { get; set; }


    public ProdutoDigital(string nome, string descricao, decimal preco, string imagem,
        string linkDownload, DateTime dataCompra)
        : base(nome, descricao, preco, imagem)
    {
        this.LinkDownload = linkDownload;
        DataCompra = dataCompra;
    }

    public string LinkDownload
    {
        get
        {
            return linkDownload ?? string.Empty;
        }

        set
        {
            if (value.Length > 0)
            {
                this.linkDownload = value;
            }
        }
    }

    public bool EstaExpirado()
    {
        return DateTime.Now > DataCompra.AddYears(2);
    }

    public override void Entregar(string endereco)
    {
        Console.WriteLine($"Enviando {Nome} para o email {endereco}");
    }

}


