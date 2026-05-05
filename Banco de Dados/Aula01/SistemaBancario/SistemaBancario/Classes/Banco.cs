using System.Security.Cryptography.X509Certificates;

namespace SistemaBancario.Classes.Entidades
{
    /// <summary>
    /// Classe que representa uma conta bancária com operações básicas
    /// Implementa as regras de negócio
    /// </summary>
    internal class Banco
    {
        // Campo
        /// <summary>
        /// Taxa fixa cobrada em cada operação de saque
        /// </summary>
        private const decimal taxaSaque = 5.00m;

        // Propriedades

        /// <summary>
        /// Identificador único da conta bancária no banco de dados (gerado automaticamente)
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Número da conta bancária
        /// 'init' garante que o valor só pode ser atribuído na criação (imutável após construção)
        /// </summary>
        public int NumeroConta { get; init; }

        /// <summary>
        /// Nome do titular da conta
        /// </summary>
        public string Titular { get; set; }

        /// <summary>
        /// Saldo atual da conta
        /// 'private set' impede alteração direta - só pode mudar através de depósito ou saque
        /// </summary>
        public decimal Saldo { get; private set; }

        // Construtores

        public Banco()
        {
        }

        /// <summary>
        /// Construtor principal para criar uma nova conta bancária
        /// </summary>
        /// <param name="numeroConta"></param>
        /// <param name="titular"></param>
        /// <param name="saldo"></param>
        public Banco(int numeroConta, string titular, decimal saldo = 0)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldo;
        }

        public void Deposito(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de depósito deve ser positivo");
                return;
            }

            Saldo += valor;
            Console.WriteLine($"Depósito de {valor:C} realizado com sucesso");
        }

        /// <summary>
        /// Realiza um saque na conta, diminuindo o saldo
        /// Cobra automaticamente uma taxa de R$5,00 por saque
        /// IMPORTANTE: Permite saldo negativo se não houver fundos
        /// </summary>
        /// <param name="valor">
        /// Valor a ser sacado (deve ser positivo, não inclui a taxa)
        /// </param>
        public void Saque(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de saque deve ser positivo");
                return;
            }

            Saldo -= valor + taxaSaque;
            Console.WriteLine($"Saque de {valor:C} realizado com sucesso. Taxa de {taxaSaque:C} cobrada");
        }

        /// <summary>
        /// Exibe dados da conta no console
        /// Mostra número da conta, titular e saldo atual
        /// </summary>
        public void ExibirDados()
        {
            Console.WriteLine("\nDados da conta");
            Console.WriteLine($"Conta: {NumeroConta}");
            Console.WriteLine($"Titular: {Titular}");
            Console.WriteLine($"Saldo: {Saldo:C}");
            Console.WriteLine("------------\n");
        }
    }
}