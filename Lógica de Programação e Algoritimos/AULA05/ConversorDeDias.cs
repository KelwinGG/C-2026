using static System.Console;

int anos, meses, dias;

System.Console.WriteLine("Digite a sua idade em dias:");
dias = int.Parse(ReadLine());

// Texto em Vermelho
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Aguardando...");
        Console.ResetColor();

anos = dias/365;
meses = (dias%365) / 30 ; 
dias = (dias%365) % 30;

System.Console.WriteLine($"Anos: {anos}");
System.Console.WriteLine($"Meses: {meses}");
System.Console.WriteLine($"Dias: {dias}");