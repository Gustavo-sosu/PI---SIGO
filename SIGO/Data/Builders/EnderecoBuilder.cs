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

            modelBuilder.Entity<Cliente>().HasMany(c => c.Enderecos).WithOne(e => e.Clientes).HasForeignKey(e => e.ClienteId).OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Endereco>().HasData(new List<Endereco>
            {
                new() { Id = 1, Rua = "Rua das Flores", Numero = 123, Cidade = "São Paulo", Bairro = "Centro", Cep = 01001000, Estado = "SP", ClienteId = 1 },
                new() { Id = 2, Rua = "Av. Brasil", Numero = 456, Cidade = "Rio de Janeiro", Bairro = "Copacabana", Cep = 22041001, Estado = "RJ", ClienteId = 2 }
            });
        }
    }
}
