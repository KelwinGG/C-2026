using Aula03;
using static System.Console;


Funcionario x = new Funcionario();



Console.WriteLine("Digite o nome do funcionario ");
x.nome = Console.ReadLine();
Console.WriteLine("Digite o valor do salário bruto do funcionario: ");
x.salariobruto = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor total de imposto a ser pago pelo funcionario: ");
x.imposto = double.Parse(Console.ReadLine());


Console.WriteLine($"Dados do funcionario \n Nome do Funcionrio = {x.nome} \n Salario Liquido {x.salarioliquido()}");


Console.WriteLine($"Digite a porcentagem de aumento do salario do funcionario :");
double porcentagem = double.Parse(Console.ReadLine());
x.aumentarsalario(porcentagem);


Console.WriteLine($"Salario do funcionario aumentado {porcentagem}%");
                                      
Console.WriteLine($"Dados do funcionario atualizado \n Nome do funcionario :{x.nome}\n Salario  : {x.salariobruto}");

ReadKey();