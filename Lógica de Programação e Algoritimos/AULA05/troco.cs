using static System.Console;
 
double precoU, quantidade, dinheirorecebido, troco;

System.Console.WriteLine("Preço unitario do produto: ");
precoU = double.Parse(ReadLine());
System.Console.WriteLine("Quantidade comprada: ");
quantidade = double.Parse(ReadLine());
System.Console.WriteLine("Dinehiro Recebido: ");
dinheirorecebido = double.Parse(ReadLine());

troco = dinheirorecebido-(precoU*quantidade);


      Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"O troco recebido é: {troco}");
        Console.ResetColor();