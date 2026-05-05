using Estudantes.Classes.Dados;
using Microsoft.EntityFrameworkCore;
using Estudantes.Classes.Dados.Entidades;


using var context = new AlunoContext();

context.Database.EnsureCreated();

Aluno pessoa1 = new Aluno("Clodoaldo", 12345 , "DEV");
context.Alunos.Add(pessoa1);
context.SaveChanges();

var pessoas = context.Alunos.FirstOrDefault(c => c.Id == 1);
pessoas.ExibirDados();

