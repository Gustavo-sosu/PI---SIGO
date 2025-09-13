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
            modelBuilder.Entity<Telefone>().Property(t => t.DDD).IsRequired().HasMaxLength(5);
            modelBuilder.Entity<Cliente>().HasMany(c => c.Telefones).WithOne(t => t.Clientes).HasForeignKey(t => t.ClienteId);
     
        }
    }
}
