using SIGO.Data.Interfaces;
using SIGO.Objects.Models;

namespace SIGO.Data.Repositories
{
    public class TelefoneRepository : GenericRepository<Telefone>, ITelefoneRepository
    {
        private readonly AppDbContext _context;

        public TelefoneRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
