using static System.Console;
using static System.ConsoleColor;
using circuferencia2;

//entrada de dados 
Console.WriteLine("Digite o raios da circuferencia: ");
ForegroundColor = Gray;
double raio = double.Parse(ReadLine());
ResetColor();

Calculadora c1 = new Calculadora(raio);


Console.WriteLine($"Circuferencia {c1.Circunferencia(double.r):F2}");
Console.WriteLine($"Volume : {c1.Volume}");
Console.WriteLine($"PI : {c1.PI}");