
using static System.Console;

int n = 0;

do
{
    Write (n);
    n++;
    Task.Delay(1000).Wait();
}while(n < 5);
System.Console.WriteLine("Fim de programa ");
n = 0;
while (n < 5)
{
    System.Console.WriteLine(n);
    n++;
    Task.Delay(1000).Wait();

}
 
 System.Console.WriteLine("Fim de ");