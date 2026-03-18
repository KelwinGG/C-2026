using ExemploComOOP;
using static System.Console;
Triangulo x = new Triangulo();
Triangulo y = new Triangulo();

Console.WriteLine("Digite as medidadas do triangulo X ");
Console.WriteLine("Digite a medida A:  ");
x.ladoA = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a medida B:  ");
x.ladoB = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a medida C:  ");
x.ladoC = double.Parse(Console.ReadLine());


Console.WriteLine("Digite as medidadas do triangulo Y ");
Console.WriteLine("Digite a medida A ");
y.ladoA = double.Parse(ReadLine());
Console.WriteLine("Digite a medida B ");
y.ladoB = double.Parse(ReadLine());
Console.WriteLine("Digite a medida C ");
y.ladoC = double.Parse(ReadLine());

//saida de dados 
Console.WriteLine($"A área do triangulo x é  de {x.Area():F}");
Console.WriteLine($"A área do triangulo y é  de {y.Area():F}");

ReadKey();

