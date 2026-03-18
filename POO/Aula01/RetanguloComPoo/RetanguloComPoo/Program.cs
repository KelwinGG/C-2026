using RetanguloComPoo;
using static System.Console;


Retangulo x = new Retangulo();
Retangulo y = new Retangulo();


Console.WriteLine("Digite as informções do Retangulo X");
Console.WriteLine("Digite a Altura de X ");
 x.altura = double.Parse(ReadLine());
Console.WriteLine("Digite a Largura de X ");
 x.largura = double.Parse(ReadLine());

Console.WriteLine("Digite as informções do Retangulo Y");
Console.WriteLine("Digite a Altura de Y ");
y.altura = double.Parse(ReadLine());
Console.WriteLine("Digite a Largura de Y ");
y.largura = double.Parse(ReadLine());


Console.WriteLine($"A area do Retangulo X é: {x.Area()}");
Console.WriteLine($"O Perimetro do Retangulo X é: {x.Perimetro()} ");
Console.WriteLine($"A Diagonal do Retangulo X é : {x.Diagonal()}");


Console.WriteLine($"A area do Retangulo Y é: {y.Area()}");
Console.WriteLine($"O Perimetro do Retangulo Y é: {y.Perimetro()} ");
Console.WriteLine($"A Diagonal do Retangulo Y é : {y.Diagonal()}");