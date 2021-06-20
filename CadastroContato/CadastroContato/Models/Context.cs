using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CadastroContato.Models
{
    public class Context : DbContext
    {
        public DbSet<Contato> Contatos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CadastroContato;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Contato>(entity => {
                entity.HasIndex(e => e.email).IsUnique();
            });

            builder.Entity<Contato>(entity => {
                entity.HasIndex(e => e.cpf).IsUnique();
            });
        }
    }
}
