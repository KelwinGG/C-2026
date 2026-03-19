using static System.Console;
using terreno;

 

Console.WriteLine("Digite a largura do terreno: ");
double largura = double.Parse(ReadLine());
Console.WriteLine("Digite o comprimento do terreno: ");
double comprimento = double.Parse(ReadLine());
Console.WriteLine("Digite o valor  do terreno: ");
double valor = double.Parse(ReadLine());


Terreno t = new Terreno(largura,comprimento, valor);

t.Saida();
ReadKey();