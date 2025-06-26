class ProdutoFisico : Produto
{
    public int Estoque { get; }

    public ProdutoFisico(string nome, string descricao, decimal preco, int estoque, string imagem)
        : base(nome, descricao, preco, imagem)
    {
        this.Estoque = 0;
    }

    public ProdutoFisico(string nome, string descricao, decimal preco, string imagem, int estoque)
        : base(nome, descricao, preco, imagem)
    {
        this.Estoque = estoque;
    }

    public bool EstaDisponivel()
    {
        return Estoque > 0;
    }

    public override void Entregar(string endereco)
    {
        Console.WriteLine($"Calculando frete com base no {endereco} " +
        $"e enviando {Nome}");
    }
}


