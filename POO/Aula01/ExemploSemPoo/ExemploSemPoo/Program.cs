//Entrada de dados 
using static System.Console;
Title = "Calculadora de triangulo";

Console.WriteLine("Digite o as medidas do triangulo x : ");
Console.WriteLine("Digite o valor de A:  ");
double ax = double.Parse(ReadLine());
Console.WriteLine("Digite o valor de B: ");
double  bx = double.Parse(ReadLine());
Console.WriteLine("Digite o valor de C: ");
double  cx = double.Parse(ReadLine());

Console.WriteLine("Digite o valor do triangulo y :");
Console.WriteLine("Digite o valor de A:  ");
double ay = double.Parse(ReadLine());
Console.WriteLine("Digite o valor de B: ");
double by = double.Parse(ReadLine());
Console.WriteLine("Digite o valor de C: ");
double cy = double.Parse(ReadLine());

//processamento de dados 

double px = (ax +  bx + cx) / 2;
double py = (ay + by + cy) / 2;

double areax = Math.Sqrt(px * (px - ax) * (px - bx) * (px - cx));
double areay = Math.Sqrt(py * (py - ay) * (py - by) * (py - cy));

//saida de dados 
Console.WriteLine($"A area do triangulo X é de {areax:F2}");
Console.WriteLine($"A area do triangulo Y é de {areay:F2}");

if (areax > areay)
{
    Console.WriteLine("Maior área é do triângulo X : ");

}
else if (areay > areax)
{
    Console.WriteLine("Maior área é do triangulo Y : ");

}
else
{
    Console.WriteLine("Os triangulos de áreas são iguais... ");
}

        
ReadKey();

