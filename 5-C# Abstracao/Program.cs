/*
string nome1 = "Teclado";
string descricao1 = "Modelo compacto e silencioso, " +
                    "perfeito para produtividade diária.";
decimal preco1 = 80.00m;
int estoque1 = 15;

Console.WriteLine($@"Dados do item 1:
Nome: {nome1},
Descrição: {descricao1}
Preço: {preco1},
Estoque: {estoque1}
");

string nome2 = "Cadeira gamer";
string descricao2 = "Conforto ergonômico com design" +
                    " moderno para longas sessões de jogo.";
decimal preco2 = 600.00m;
int estoque2 = 5;

Console.WriteLine($@"Dados do item 2:
Nome: {nome2},
Descrição: {descricao2}
Preço: {preco2},
Estoque: {estoque2}
");
*/

ProdutoFisico item1 = new ProdutoFisico("Teclado", "Modelo compacto e silencioso, " +
                    "perfeito para produtividade diária.", 80.00m, 15, "Imagem");

item1.Avaliar(10, "Excelente!");

Console.WriteLine($@"Dados do item 1:
Nome: {item1.Nome},
Descrição: {item1.Descricao}
Preço: {item1.Preco},
Estoque: {item1.Estoque}
Nota: {(item1.Avaliacao != null ? item1.Avaliacao.Nota.ToString() : "Sem avaliação")}
Comentário: {(item1.Avaliacao != null ? item1.Avaliacao.Comentario : "Sem comentário")}
");


item1.AlterarPrecoComDesconto(10.0m);
Console.WriteLine(item1.Preco);
item1.AlterarPrecoComDesconto(10);
Console.WriteLine(item1.Preco);


item1.Entregar("endereço físico");

/*ProdutoFisico item2 = new ProdutoFisico("Teclado", "Modelo compacto e silencioso, " +
                    "perfeito para produtividade diária.", 80.00m, "Imagem", 20);

item1.Avaliar(10, "Excelente!");

Console.WriteLine($@"Dados do item 1:
Nome: {item2.Nome},
Descrição: {item2.Descricao}
Preço: {item2.Preco},
Estoque: {item2.Estoque}
Nota: {(item2.Avaliacao != null ? item2.Avaliacao.Nota.ToString() : "Sem avaliação")}
Comentário: {(item2.Avaliacao != null ? item2.Avaliacao.Comentario : "Sem comentário")}
");*/

/*Console.WriteLine($"Imagem: {item1.Imagem}");
item1.Imagem = "Nova Imagem";
Console.WriteLine($"Imagem:{item1.Imagem}");*/



ProdutoDigital item2 = new ProdutoDigital("Curso", "OO em C#", 100.00m, "Imagem Ilustrativa",
    "Link", DateTime.Now);

Console.WriteLine($@"Dados do item 2:
Nome: {item2.Nome},
Descrição: {item2.Descricao}
Preço: {item2.Preco},
Link: {item2.LinkDownload}
Está Expirado: {item2.EstaExpirado()}
");

Pedido pedido = new Pedido(1, "Jonas", 100.00m);
pedido.AdicionarProduto(item1);
pedido.AdicionarProduto(item2);
pedido.ExibirResumo();

item2.Entregar("jonasoberdan@gmail.com");


BancoDeDados banco = new BancoDeDados();
var produto = (ProdutoFisico)banco.BuscarProdutoPeloNome("Teclado");

Console.WriteLine($@"Dados do item 1:
Nome: {produto.Nome},
Descrição: {produto.Descricao}
Preço: {produto.Preco},
Estoque: {produto.Estoque}
");


/*if (item1.EstaDisponivel())
{
    Console.WriteLine("Produto está disponível!");
}

item1.AlterarPrecoComDesconto(0.2m);*/

/*Console.WriteLine($@"Dados do item 1:
Nome: {item1.nome},
Descrição: {item1.descricao}
Preço: {item1.preco},
Estoque: {item1.estoque}
");*/