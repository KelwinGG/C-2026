 using static System.Console;

//Declaração de variavel 
int numero;
//entrada de dados 
numero = int.Parse(ReadLine());
//processamento de dados 
for (int i = 0; i<1000; i++)
{
    System.Console.WriteLine($"{numero}X{i+1} = {numero * (i+1)}");
    Beep(1000,100);
}
