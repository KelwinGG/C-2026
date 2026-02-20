using System.Reflection;
using static System.Console;
//Entrada de dados e saida de dados 
double Base, altura, area, perimetro, diagonal;

System.Console.WriteLine("Digite a base do retângulo : ");
Base = double.Parse(ReadLine());
System.Console.WriteLine("Digite a altura do retângulo");
altura = double.Parse(ReadLine());

area = Base*altura;
perimetro = 2*Base + 2*altura;
diagonal = Math.Sqrt((Base*Base)+(altura*altura));

System.Console.WriteLine($"Área é = {area}");
System.Console.WriteLine($"O Perimetro é ={perimetro}");
System.Console.WriteLine($"O Valor da diagonal é = {diagonal}");

System.Console.WriteLine("Parabens desafio concluido!!!");