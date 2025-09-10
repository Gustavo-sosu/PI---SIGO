using Microsoft.EntityFrameworkCore;
using SIGO.Objects.Enums;
using SIGO.Objects.Models;

namespace SIGO.Data.Builders
{
    public class ClienteFBuilder
    {
        public static void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClienteF>().ToTable("clientef");
            modelBuilder.Entity<ClienteF>().HasBaseType<Cliente>();
            modelBuilder.Entity<ClienteF>().Property(c => c.Cpf).IsRequired().HasMaxLength(11);
            modelBuilder.Entity<ClienteF>().Property(c => c.DataNasc).IsRequired();
            modelBuilder.Entity<ClienteF>().Property(c => c.Sexo).IsRequired().HasMaxLength(1);
            modelBuilder.Entity<ClienteF>().Property(c => c.Obs).HasMaxLength(500);

            modelBuilder.Entity<ClienteF>().HasData(
                new ClienteF
                {
                    Id = 1,
                    Nome = "João Pereira",
                    Email = "joao@email.com",
                    Senha = "123456",
                    Data = new DateOnly(2025, 6, 1),
                    Situacao = Situacao.ATIVO,
                    Cpf = "12345678901",
                    DataNasc = new DateOnly(1990, 5, 12),
                    Sexo = "M",
                    Obs = "Cliente antigo"
                }
            );
        }
    }
}
