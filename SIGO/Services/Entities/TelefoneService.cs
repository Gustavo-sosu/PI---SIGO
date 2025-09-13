using AutoMapper;
using SIGO.Data.Interfaces;
using SIGO.Objects.Dtos.Entities;
using SIGO.Services.Interfaces;
using SIGO.Objects.Models;

namespace SIGO.Services.Entities
{
    public class TelefoneService : GenericService<Telefone, TelefoneDTO>, ITelefoneService
    {
        private readonly ITelefoneRepository _telefoneRepository;
        private readonly IMapper _mapper;

        public TelefoneService(ITelefoneRepository telefoneRepository, IMapper mapper)
            : base(telefoneRepository, mapper)
        {
            _telefoneRepository = telefoneRepository;
            _mapper = mapper;
        }
    }
}
