using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioBookStore_Back.Domain.Entities;
using DesafioBookStore_Back.Infrastructure.Data.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace DesafioBookStore_Back.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            if (Database.GetPendingMigrations().Count() > 0)
                Database.Migrate();
        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Assunto> Assunto { get; set; }
        public DbSet<Autor> Autor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração para o relacionamento muitos-para-muitos entre Livro e Autor
            modelBuilder.Entity<Livro>()
                .HasMany(l => l.Autores)
                .WithMany(a => a.Livros)
                .UsingEntity<Dictionary<string, object>>(
                    "LivroAutor", // Nome da tabela intermediária
                    j => j.HasOne<Autor>().WithMany().HasForeignKey("AutorCodAu"),
                    j => j.HasOne<Livro>().WithMany().HasForeignKey("LivroCod")
                );

            // Configuração para o relacionamento muitos-para-muitos entre Livro e Assunto
            modelBuilder.Entity<Livro>()
                .HasMany(l => l.Assuntos)
                .WithMany(a => a.Livros)
                .UsingEntity<Dictionary<string, object>>(
                    "LivroAssunto", // Nome da tabela intermediária
                    j => j.HasOne<Assunto>().WithMany().HasForeignKey("AssuntoCodAs"),
                    j => j.HasOne<Livro>().WithMany().HasForeignKey("LivroCod")
                );
        }
    }
}
