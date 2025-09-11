using Microsoft.EntityFrameworkCore;
using SIGO.Objects.Models;

namespace SIGO.Data.Interfaces
{
    public interface IClienteRepository : IGenericRepository<Cliente>
    {
        Task<IEnumerable<Cliente>> GetByName(string nome);
        Task<Cliente?> GetByIdWithDetails(int id);
    }
}
