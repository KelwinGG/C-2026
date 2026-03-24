using System.Transactions;
using static System.Console;
using static System.ConsoleColor;


Title = "Calculadora 01";

//declaração de variaveis
double raio, circuferencia, volume;
const double PI = 3.14;

//entrada de dados 
Console.WriteLine("Entre com o valor do Raio da circuferencia :  ");
ForegroundColor = Red;
raio = double.Parse(ReadLine());
ResetColor();

//saida de Dados
Console.WriteLine($"Circunferencia : {Circuferencia(raio):F2}");
Console.WriteLine($"Volume : {Volume(raio):F2}");
Console.WriteLine($"PI : {PI}");


//calculo da circunferencia 
double Circuferencia(double r)
{
    return 2 * PI * r;
}

double Volume(double r)
{
    return (4/3) * PI * r; 
}
