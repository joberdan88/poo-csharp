//Executar o 10:
class Program
{
    static void Main()
    {
        List<IAcaoBotao> acoes = new List<IAcaoBotao>
        {
            new SalvarAcao(),
            new EditarAcao(),
            new ExcluirAcao(),
        };

        foreach (var acao in acoes)
        {
            acao.Executar();
        }
    }
}

