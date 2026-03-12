using static System.Console;
try{
System.Console.WriteLine("produto 1 : 5.00 \nproduto 2 : 3.50 \nproduto 3 : 4.80 \nproduto 4 : 8.90 \nproduto 5 : 7.32");

    Dictionary<int, double> produtos = new Dictionary<int, double>()
  
    
    {
        {1, 5.00 },
        {2, 3.50 },
        {3, 4.80 },
        {4, 8.90 },
        {5, 7.32 }
    };
     System.Console.WriteLine("Digite o codigo do produto:  ");
     int codigo = int.Parse(ReadLine());
     Beep(800,100);
    
    System.Console.WriteLine("Digite a quantidade:  ");
    int quantidade = int.Parse(ReadLine());
    Beep(800,100);


    double Total = quantidade*produtos[codigo];
    System.Console.WriteLine($"O valor total é : {Total:F2}");
    Beep(800,100);
}
catch (Exception ex)
{
    System.Console.WriteLine($"Digite um um numero : {ex.Message}");
}



