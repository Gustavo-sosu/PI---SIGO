using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using SIGO.Objects.Enums;
using SIGO.Objects.Models;

namespace SIGO.Data.Builders
{
    public class ClienteJBuilder
    {
        public static void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClienteJ>().ToTable("clientej");
            modelBuilder.Entity<ClienteJ>().HasBaseType<Cliente>();
            modelBuilder.Entity<ClienteJ>().Property(c => c.Razao).IsRequired().HasMaxLength(150);
            modelBuilder.Entity<ClienteJ>().Property(c => c.Cnpj).IsRequired().HasMaxLength(14);

            modelBuilder.Entity<ClienteJ>().HasData(
                new ClienteJ
                {
                    Id = 2,
                    Nome = "Empresa ABC",
                    Email = "contato@empresaabc.com",
                    Senha = "123456",
                    Data = new DateOnly(2025, 6, 3),
                    Situacao = Situacao.ATIVO,
                    Razao = "Empresa ABC Ltda",
                    Cnpj = "12345678000199"
                }
            );
        }
    }
}
