 
using static System.Console;

static void Total(int qtd, double valor)
{
     System.Console.WriteLine($"O valor total é: {qtd*valor}");
}

 int codigo, quantidade;

try{
 System.Console.WriteLine("Digite o codigo do produto:  ");
 codigo = int.Parse(ReadLine());
 System.Console.WriteLine("Digite a quantidade:  ");
 quantidade = int.Parse(ReadLine());
switch(codigo)
{
    case 1 :
        Total(quantidade, 5.00);
        //System.Console.WriteLine($"O valor total é: {quantidade*5.00}");
        break;
    case 2 :
        Total(quantidade, 4.50);
        //System.Console.WriteLine($"O valor total é : {quantidade *4.50}");
        break;
    case 3 :
        Total(quantidade, 3.75);
        //System.Console.WriteLine($"O valor total é : {quantidade *3.75}");
        break;
    case 4 :
        Total(quantidade, 8.99);
        //System.Console.WriteLine($"O valor total é : {quantidade *8.99}");
        break;
    case 5 :
        Total(quantidade, 11.33);
        //System.Console.WriteLine($"O valor total é : {quantidade *11.33}");
        break;
    default:
    System.Console.WriteLine("Codigo do produto não cadastrado");
    break;
}
}
catch(Exception ex)
{
    System.Console.WriteLine($"Digite valores validos, erro:{ex.Message}");
}