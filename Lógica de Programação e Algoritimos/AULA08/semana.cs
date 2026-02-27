//o usuario vai digitar um valor de de 1 a 7 e esse codigo e para mostar que dia da semana sera 
using static System.Console;

//declaração de variaveis 
int valor;
//entrada de dados 
System.Console.Write("Digite um número de 1 a 7 :");
valor = int.Parse(Console.ReadLine());
if (valor==1)
{
    System.Console.WriteLine("Domingo");
}
else if (valor==2)
{
    System.Console.WriteLine("Segunda-Feira");
}
else if (valor==3)
{
    System.Console.WriteLine("Terça-Feira");
}
else if (valor == 4)
{
    System.Console.WriteLine("Quarta-feira");
}
else if (valor == 5)
{
    System.Console.WriteLine("Quinta-Feira");
}
else if (valor == 6 )
{
    System.Console.WriteLine("Sexta-Feira");
}
else if (valor == 7)
{
    System.Console.WriteLine("Sabado LINDÃO");
}
else
{
    System.Console.WriteLine("Numero fora do intervalo");
}