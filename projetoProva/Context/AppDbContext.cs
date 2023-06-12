using Microsoft.EntityFrameworkCore;
using projetoProva.model;

namespace projetoProva.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .Property(e => e.Nome)
                .HasMaxLength(80);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Valor)
                .HasPrecision(10,2);

            modelBuilder.Entity<Produto>()
                .HasData(
                new Produto { Id = 1, Nome = "Produto1", Valor = 1.89M, Quantidade = 10, Descricao = "Descricao", CodBarras = 512 },
                new Produto { Id = 2, Nome = "Produto2", Valor = 2.76M, Quantidade = 5, Descricao = "Descricao", CodBarras = 215 }
                );
        }
    }
}
