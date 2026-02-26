using static System.Console;

double a, b, c, area, triangulo, p , i, areaT;

System.Console.WriteLine("BEM-VINDO A TASK DO TRIANGULO");
System.Console.WriteLine("Digite o valor de A");
a = double.Parse(ReadLine());

System.Console.WriteLine("Digite o valor de B");
b = double.Parse(ReadLine());

System.Console.WriteLine("Digite o valor de C");
c = double.Parse(ReadLine());

//
if (a+b > c & a+c > b & b+c > a)
{
    p = (a+b+c) / 2;
    area = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
    System.Console.WriteLine($"Area triangulo utilizando forma de heron: {area}");
    
}
else
{
    System.Console.WriteLine("Triangulo invalido");
    System.Console.WriteLine("Porém será calculado o trapezio");
    areaT = ((a+b)* c)/2;
    System.Console.WriteLine($"Area Trapezio: {areaT}");
}


