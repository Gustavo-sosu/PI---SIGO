using Microsoft.EntityFrameworkCore;
using SIGO.Objects.Models;

namespace SIGO.Data.Builders
{
    public class TelefoneBuilder
    {
        public static void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Telefone>().HasKey(t => t.Id);
            modelBuilder.Entity<Telefone>().Property(t => t.Numero).IsRequired().HasMaxLength(11);

            modelBuilder.Entity<Cliente>().HasMany(c => c.Telefones).WithOne(t => t.Clientes).HasForeignKey(t => t.ClienteId);
               
            modelBuilder.Entity<Telefone>().HasData(new List<Telefone>
            {
                new() { Id = 1, Numero = "11999999999", ClienteId = 1 },
                new() { Id = 2, Numero = "21988888888", ClienteId = 2 }
            });
        }
    }
}
