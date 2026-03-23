using Atividade3;
using static System.Console;

Aluno x = new Aluno();

Console.WriteLine("Digite o nome do Aluno: ");
x.NomeDoAluno = (ReadLine());
Console.WriteLine("Digite a Nota 1 : ");
x.Nota1 = double.Parse(ReadLine());
Console.WriteLine("Digite a Nota 2 : ");
x.Nota2 = double.Parse(ReadLine());
Console.WriteLine("Digite a Nota 3 : ");
x.Nota3 = double.Parse(ReadLine());





Console.WriteLine($"Nota Final do Aluno : {x.NotaFinal()}");
Console.WriteLine($"Situação do Aluno:");
x.AprovadoOuReprovado();

ReadKey();