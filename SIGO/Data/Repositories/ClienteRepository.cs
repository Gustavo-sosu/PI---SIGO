using Microsoft.EntityFrameworkCore;
using SIGO.Data.Interfaces;
using SIGO.Objects.Models;
using System.Security.Cryptography.X509Certificates;

namespace SIGO.Data.Repositories
{
    public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
    {
        private readonly AppDbContext _context;

        public ClienteRepository(AppDbContext context) : base(context)
        {
          _context = context;  
        }
        public override async Task<IEnumerable<Cliente>> Get()
        {
            return await _context.Clientes
                .Include(c => c.Enderecos)
                .Include(c => c.Telefones)
                .ToListAsync();
        }
        public async Task<IEnumerable<Cliente>> GetByName(string nome)
        {
            return await _context.Clientes
                .Include(c => c.Enderecos)
                .Include(c => c.Telefones)
                .Where(c => c.Nome.Contains(nome))
                .ToListAsync();
        }
        public async Task<Cliente?> GetByIdWithDetails(int id)
        {
            return await _context.Clientes
                .Include(c => c.Enderecos)
                .Include(c => c.Telefones)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

    }
}
