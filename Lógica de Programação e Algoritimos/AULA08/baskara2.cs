
using static System.Console;
//funções
static double delta(double a,double b,double c)
{
    return   (b*b) - (4 * a * c);
}


static void saida(double x1,double x2)
{
    System.Console.WriteLine($"X1 = {x1}\n X2 = {x2}");

}
static void raizes(double a, double b, double delta)
{
    double x1 = (-b  - Math.Sqrt(delta))/(2*a);
    double x2 = (-b  + Math.Sqrt(delta))/(2*a);
    saida (x1, x2);
}
//----declarar variaveis 
double a,b,c, delta1;
const string TEXTO = "Digite o valor de ";
//entrada de dados 
System.Console.WriteLine(TEXTO + "a");
a = double.Parse(ReadLine());
System.Console.WriteLine(TEXTO + "b");
b = double.Parse(ReadLine());
System.Console.WriteLine(TEXTO + "c");
c = double.Parse(ReadLine());
//processamento de Dados 
delta1 = delta (a,b,c);
//------ estrutura de controle de decição 
if (delta1 < 0)
{
    System.Console.WriteLine("Raizes impossíveis");
}
else if (delta1 == 0)
{
  raizes(a, b, delta1);
}


else
{
     raizes(a, b, delta1);
}