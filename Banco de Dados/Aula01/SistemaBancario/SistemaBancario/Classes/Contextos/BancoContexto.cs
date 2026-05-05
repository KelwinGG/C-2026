using Microsoft.EntityFrameworkCore;
using SistemaBancario.Classes.Entidades;
namespace SistemaBancario.Classes.bancoContexto
{
    internal class BancoContexto : DbContext
    {
        /// <summary>
        /// Representa a tabela de contas bancarias no banco de dados
        /// </summary>
        public DbSet<Banco> Contas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // string verbatim: use uma única barra '\'
            optionsBuilder.UseSqlServer(
     @"Server=ECFP507D1319378\SQLEXPRESS;Database=Banco;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Banco>();
        }
    }
}