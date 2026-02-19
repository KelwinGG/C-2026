using static System.Console;//importação para deixar fixo
//Declaração de variaveis 
double largura, comprimento, valor, area , preco;
//entrada de dados 
Write("Digite a largura do terreno :");
largura = double.Parse(ReadLine());
Write("Digite o comprimento do terreno: ");
comprimento = double.Parse(ReadLine());
Write("Digite o valor do m² do terreno: ");
valor = double.Parse(ReadLine());
//^ Entrada de dados
//Processamnto de dados 
area = largura * comprimento;
preco = area * valor;
//Saida de Dados 
WriteLine($"A área do terreno é de {area} e o preço do terreno é de R${preco}");

