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
        public async Task<IEnumerable<Cliente>> GetByName(string nome)
        {
            return await _context.Clientes
                .Where(c => c.Nome.Contains(nome))
                .ToListAsync();
        }

    }
}
