
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
    case 3 :
        System.Console.WriteLine($"O valor total é : {quantidade *3.75}");
        break;
    case 4 :
        System.Console.WriteLine($"O valor total é : {quantidade *8.99}");
        break;
    case 5 :
        System.Console.WriteLine($"O valor total é : {quantidade *11.33}");
        break;
}