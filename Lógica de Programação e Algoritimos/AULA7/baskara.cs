 using static System.Console;
 // problema baskara-----


double a, b, c, delta, x1, x2;
//entrada de dados
System.Console.WriteLine("Digite o valor de A: ");
a = double.Parse(ReadLine());
System.Console.WriteLine("Digite o valor de B: ");
b = double.Parse(ReadLine());
System.Console.WriteLine("Digite o valor de C: ");
c = double.Parse(ReadLine());
//
delta = b*b - (4  *  a  *  c  );
// decisão 
if (delta < 0)
{
    System.Console.WriteLine("Raizes impossiveis");

}
else if (delta == 0)
{
    x1 = -b/ (2*a);
    x2 = x1; 
    System.Console.WriteLine($"X1 = {x1}\n X2 = {x2}");
}
else
{
    x1 =(-b -Math.Sqrt(delta)) / (2 * a);
    x2 = (-b + Math.Sqrt(delta)) / (2*a);
    System.Console.WriteLine($"X1 = {x1}\n X2 = {x2}");
}
