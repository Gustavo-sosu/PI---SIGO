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
            modelBuilder.Entity<Cliente>().Property(c => c.Data).IsRequired();
            modelBuilder.Entity<Cliente>().Property(c => c.Situacao).IsRequired();

            modelBuilder.Entity<Cliente>()
            .HasMany(c => c.Telefones)
            .WithOne(t => t.Clientes)
            .HasForeignKey(t => t.ClienteId)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Telefone>().HasKey(t => t.Id);
            modelBuilder.Entity<Telefone>().Property(t => t.Numero).IsRequired().HasMaxLength(11);

            modelBuilder.Entity<Cliente>()
            .HasMany(c => c.Enderecos)
            .WithOne(t => t.Clientes)
            .HasForeignKey(t => t.ClienteId)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Endereco>().HasKey(e => e.Id);
            modelBuilder.Entity<Endereco>().Property(e => e.Numero).IsRequired();
            modelBuilder.Entity<Endereco>().Property(e => e.Rua).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Endereco>().Property(e => e.Cidade).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Endereco>().Property(e => e.Cep).IsRequired().HasMaxLength(8);
            modelBuilder.Entity<Endereco>().Property(c => c.Bairro).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Endereco>().Property(b => b.Estado).IsRequired().HasMaxLength(2);


            modelBuilder.Entity<Cliente>().HasData(new List<Cliente>
            {
                 new (1, "Miguel Silva", "miguelsilva@gmail.com", "123456", new DateOnly(2025, 1, 1), Situacao.ATIVO),
                 new (2, "Gabriel Oliveira", "gabrieloliveira@gmail.com", "123456", new DateOnly(2025, 2, 1), Situacao.INATIVO),
                 new (3, "Marco Brito", "marcobrito@gmail.com", "123456", new DateOnly(2025, 3, 1), Situacao.ATIVO)
            });

            modelBuilder.Entity<Telefone>()
            .HasData(new List<Telefone>
            {
                new() { Id = 1, Numero = "17995361829", ClienteId = 1 },
                new() { Id = 2, Numero = "17996125387", ClienteId = 2 },
                new() { Id = 3, Numero = "17996579012", ClienteId = 3 }
            });
        }
    }
}
