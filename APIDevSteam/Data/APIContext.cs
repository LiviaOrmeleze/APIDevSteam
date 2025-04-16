using APIDevSteam.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APIDevSteam.Data
{
    public class APIContext : IdentityDbContext<Usuario>
    {
        public APIContext(DbContextOptions<APIContext> options) : base(options)
        {
        }
        // DbSet
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<JogoCategoria> JogosCategorias { get; set; }
        public DbSet<JogoMidia> jogoMidias { get; set; }




        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Tabelas
            builder.Entity<Jogo>().ToTable("Jogos");
            builder.Entity<Categoria>().ToTable("Categorias");
            builder.Entity<JogoCategoria>().ToTable("JogosCategorias");
            builder.Entity<JogoMidia>().ToTable("JogoMidias");


        }
    }
}