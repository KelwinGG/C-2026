 using static System.Console;
try{
    double a , b, c , areaQuadrado, areaTriangulo, areaTrapezio;
    
    //entrada de dados 
    System.Console.WriteLine("Digite a medida A:");
    a = double.Parse (ReadLine());
    System.Console.WriteLine("Digite a medida B: ");
    b = double.Parse(ReadLine());
    System.Console.WriteLine("Digite a medida C");
    c = double.Parse(ReadLine());
    //Processamento de dados 
    areaQuadrado = a*a;
    areaTriangulo = (a*b) / 2;
    areaTrapezio = ((a + b) * c)/2;

    //saida de dados 
    System.Console.WriteLine($"Area do quadrado: {areaQuadrado:F4}");
    System.Console.WriteLine($"Area do Triangulo: {areaTriangulo:F4}");
    System.Console.WriteLine($"Area do Trapezio: {areaTrapezio:F4}");

}
catch(Exception)
{
    System.Console.WriteLine("Valores inseridos invalidos, programa encerrado");
}
