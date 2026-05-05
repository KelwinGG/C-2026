using SistemaBancario.Classes.bancoContexto;

using SistemaBancario.Classes.Entidades;

Console.WriteLine("=== Sistema Bancário ===\n");

using var context = new BancoContexto();

// Verifica se o banco de dados existe e cria se necessário
context.Database.EnsureCreated();

bool continuar = true;

while (continuar)
{
    Console.WriteLine("\n--- MENU PRINCIPAL ---");
    Console.WriteLine("1 - Cadastrar nova conta");
    Console.WriteLine("2 - Consultar conta existente");
    Console.WriteLine("3 - Sair");
    Console.Write("\nEscolha uma opção: ");

    string opcao = Console.ReadLine()!;
    Console.WriteLine();

    switch (opcao)
    {
        case "1":
            CadastrarConta(context);
            break;

        case "2":
            ConsultarConta(context);
            break;

        case "3":
            continuar = false;
            Console.WriteLine("Encerrando sistema...");
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

static void CadastrarConta(BancoContexto context)
{
    Console.WriteLine("=== CADASTRO DE CONTA ===\n");

    Console.Write("Digite o número da conta: ");
    int numeroConta = int.Parse(Console.ReadLine()!);

    var contaExistente = context.Contas
        .FirstOrDefault(c => c.NumeroConta == numeroConta);

    if (contaExistente != null)
    {
        Console.WriteLine($"\nErro: Já existe uma conta com o número {numeroConta}!");
        return;
    }

    Console.Write("Digite o nome do titular: ");
    string titular = Console.ReadLine()!;

    Console.Write("Haverá depósito inicial (s/n)? ");
    bool temDepositoInicial = Console.ReadLine()!.ToLower() == "s";

    Banco conta;

    if (temDepositoInicial)
    {
        Console.Write("Digite o valor do depósito inicial: ");
        decimal depositoInicial = decimal.Parse(Console.ReadLine()!);

        conta = new Banco(numeroConta, titular, depositoInicial);
    }
    else
    {
        conta = new Banco(numeroConta, titular);
    }

    context.Contas.Add(conta);
    context.SaveChanges();

    Console.WriteLine("\n✓ Conta cadastrada com sucesso!");
    conta.ExibirDados();
}

static void ConsultarConta(BancoContexto context)
{
    Console.WriteLine("=== CONSULTA DE CONTA ===\n");

    Console.Write("Digite o número da conta: ");
    int numeroConta = int.Parse(Console.ReadLine()!);

    var conta = context.Contas
        .FirstOrDefault(c => c.NumeroConta == numeroConta);

    if (conta == null)
    {
        Console.WriteLine($"\nConta {numeroConta} não encontrada!");
        return;
    }

    conta.ExibirDados();

    bool voltarMenu = false;

    while (!voltarMenu)
    {
        Console.WriteLine("--- OPERAÇÕES ---");
        Console.WriteLine("1 - Depositar");
        Console.WriteLine("2 - Sacar");
        Console.WriteLine("3 - Alterar titular");
        Console.WriteLine("4 - Voltar ao menu principal");
        Console.Write("\nEscolha uma opção: ");

        string opcao = Console.ReadLine()!;
        Console.WriteLine();

        switch (opcao)
        {
            case "1":
                Console.Write("Digite o valor para depósito: ");
                decimal valorDeposito = decimal.Parse(Console.ReadLine()!);

                conta.Deposito(valorDeposito);
                context.SaveChanges();
                conta.ExibirDados();
                break;

            case "2":
                Console.Write("Digite o valor para saque: ");
                decimal valorSaque = decimal.Parse(Console.ReadLine()!);

                conta.Saque(valorSaque);
                context.SaveChanges();
                conta.ExibirDados();
                break;

            case "3":
                Console.Write("Digite o novo nome do titular: ");
                string novoTitular = Console.ReadLine()!;

                conta.Titular = novoTitular;
                context.SaveChanges();

                Console.WriteLine("✓ Titular alterado com sucesso!");
                conta.ExibirDados();
                break;

            case "4":
                voltarMenu = true;
                break;

            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}