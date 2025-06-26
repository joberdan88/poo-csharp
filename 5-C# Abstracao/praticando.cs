/*Uma classe InformacaoTecnica com:
Propriedades TamanhoMB e SistemaOperacional.
Uma classe ProdutoDigital com:
Propriedades Nome, Preco e InfoTecnica (do tipo InformacaoTecnica).
Um método ExibirDetalhes() para mostrar tudo na tela.*/


using System;
public class InformacaoTecnica
{
    public int TamanhoMB { get; set; }
    public string SistemaOperacional { get; set; }

    public InformacaoTecnica(int tamanhoMB, string sistemaOperacional)
    {
        tamanhoMB = tamanhoMB;
        SistemaOperacional = sistemaOperacional;
    }

    public class ProdutoDigital
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public InformacaoTecnica InforTecnica { get; set; }

        public ProdutoDigital(string nome, double preco, InformacaoTecnica inforTecnica)
        {
            Nome = nome;
            Preco = preco;
            InforTecnica = inforTecnica;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Produto: {Nome}");
            Console.WriteLine($"Preco: R$ {Preco:F2}");
            Console.WriteLine($"Tamanho: {InforTecnica.TamanhoMB}MB");
            Console.WriteLine($"Compatível com: {InforTecnica.SistemaOperacional}");
        }   

        
    }

}


