
using static System.Console;
try{
//declaração de variaveis 
double nota1 , nota2, resultado;


 System.Console.WriteLine("Digite a primeira nota: ");
 nota1 = double.Parse(ReadLine());
 System.Console.WriteLine("Digite a segunda nota:");
 nota2 = double.Parse(ReadLine());

//processamento de dados 
resultado = nota1+nota2;
if (resultado < 60)
{
    System.Console.WriteLine($"Nota Final = {resultado:F2}");
            Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Reprovado");
        Console.ResetColor();
    
}
else
{
    System.Console.WriteLine($"Nota Final = {resultado:F2}");
            Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Aprovado");
        Console.ResetColor();
}
}
catch  (Exception) {
    System.Console.WriteLine("Digite um numero por favor.");
}

