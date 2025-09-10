using SIGO.Objects.Dtos.Entities;
using SIGO.Objects.Models;

namespace SIGO.Services.Interfaces
{
    public interface IClienteService : IGenericService<Cliente, ClienteDTO>
    {
        Task Update(ClienteJ entityJ, int id);
        Task Update(ClienteF entityF, int id);
    }
}
