using System.Diagnostics;
using static System.Console;

 int codigo, quantidade;

 System.Console.WriteLine("Digite o codigo do produto:  ");
 codigo = int.Parse(ReadLine());
 System.Console.WriteLine("Digite a quantidade:  ");
 quantidade = int.Parse(ReadLine());
switch(codigo)
{
    case 1 :
    System.Console.WriteLine($"O valor total é: {quantidade*5.00}");
    break;
    case 2 :
    System.Console.WriteLine($"O valor total é : {quantidade *4.50}");
    break;
}