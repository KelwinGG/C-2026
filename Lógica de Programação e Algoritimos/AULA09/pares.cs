 using static System.Console;
 int numero, valor;
 try
{
    System.Console.Write("Quantos números você vai digitar? ");
    numero = int.Parse(ReadLine());
    for (int i = 0; i<numero; i++) 
    {
        System.Console.Write("Digite um número: ");
        valor = int.Parse(ReadLine());
        if (valor < 0)
        {
            WriteLine("Negativo");

        }
        else if (valor > 0)
        {
            WriteLine("Positivo");
        }
        else
        {
            WriteLine("Nulo");
        }

        if ((valor % 2 )==0)
        {
            System.Console.WriteLine("PAR");
        }
        else if ((valor% 2 )!= 0)
        {
            System.Console.WriteLine("IMPAR");
        }
    }

}
catch (Exception ex)
{
    System.Console.WriteLine("Valor invalido, erro = ", ex.Message );
}