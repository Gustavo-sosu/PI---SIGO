using Microsoft.EntityFrameworkCore;
using SIGO.Objects.Enums;
using SIGO.Objects.Models;

namespace SIGO.Data.Builders
{
    public class ClienteBuilder
    {
        public static void Build(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Cliente>().HasKey(c => c.Id);
            modelBuilder.Entity<Cliente>().Property(c => c.Nome).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Cliente>().Property(c => c.Email).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Cliente>().Property(c => c.Senha).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Cliente>().Property(c => c.Data).IsRequired();
            modelBuilder.Entity<Cliente>().Property(c => c.CNPJ_CPF).IsRequired().HasMaxLength(14);
            modelBuilder.Entity<Cliente>().Property(c => c.Obs).IsRequired().HasMaxLength(500);
            modelBuilder.Entity<Cliente>().Property(c => c.Razao).IsRequired().HasMaxLength(500);
            modelBuilder.Entity<Cliente>().Property(c => c.Situacao).IsRequired();
        }
    }
}
