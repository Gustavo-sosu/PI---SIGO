using SIGO.Objects.Dtos.Entities;
using SIGO.Objects.Models;

namespace SIGO.Services.Interfaces
{
    public interface IClienteService : IGenericService<Cliente, ClienteDTO>
    {
        Task Update(ClienteJ entityJ, int id);
        Task Update(ClienteF entityF, int id);
        Task Create(Cliente cliente);
        Task Create(ClienteF entityF);
        Task Create(ClienteJ entityJ);
        Task<IEnumerable<ClienteDTO>> GetByName(string nome);
        Task<ClienteDTO?> GetByIdWithDetails(int id);
    }
}
