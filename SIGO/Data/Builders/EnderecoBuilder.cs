using Microsoft.EntityFrameworkCore;
using SIGO.Objects.Models;

namespace SIGO.Data.Builders
{
    public class EnderecoBuilder
    {
        public static void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Endereco>().HasKey(e => e.Id);
            modelBuilder.Entity<Endereco>().Property(e => e.Numero).IsRequired();
            modelBuilder.Entity<Endereco>().Property(e => e.Rua).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Endereco>().Property(e => e.Cidade).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Endereco>().Property(e => e.Cep).IsRequired().HasMaxLength(8);
            modelBuilder.Entity<Endereco>().Property(e => e.Bairro).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Endereco>().Property(e => e.Estado).IsRequired().HasMaxLength(2);
            modelBuilder.Entity<Endereco>().Property(e => e.Pais).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Endereco>().Property(e => e.Complemento).IsRequired().HasMaxLength(100);


            modelBuilder.Entity<Cliente>().HasMany(c => c.Enderecos).WithOne(e => e.Cliente).HasForeignKey(e => e.ClienteId).OnDelete(DeleteBehavior.Cascade);


        }
    }
}
