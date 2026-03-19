using static System.Console;
using exemplo1;



Console.WriteLine("Entre com os dados do Produto: ");
Write("Nome:  ");
string nome = Console.ReadLine();
Write("Preço: ");
double preco = double.Parse(ReadLine());
Write("Quantidade: ");
int qtd = int.Parse(ReadLine());

 Produto p = new Produto(nome, preco , qtd);

Console.WriteLine($"Dados do produto {p.Dados_do_Produto()}");

Console.WriteLine($"Digite a quantidade de produtos a ser adicionado no estoque: ");
qtd = int.Parse(ReadLine());   
p.Adicionar_Produtos(qtd);
Console.WriteLine($"Dados atualizados: {p.Dados_do_Produto()}");
Console.WriteLine("Digite a quantidade de produtos a ser removida do estoque: ");
qtd = int.Parse(ReadLine());
p.Remover_Produtos(qtd);
Write($"Dados atualizados : {p.Dados_do_Produto()}");

ReadKey();