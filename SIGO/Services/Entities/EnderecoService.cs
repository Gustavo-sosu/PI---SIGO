using AutoMapper;
using SIGO.Data.Interfaces;
using SIGO.Objects.Dtos.Entities;
using SIGO.Objects.Models;
using SIGO.Services.Interfaces;

namespace SIGO.Services.Entities
{
    public class EnderecoService : GenericService<Endereco, EnderecoDTO>, IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;
        private readonly IMapper _mapper;

        public EnderecoService(IEnderecoRepository enderecoRepository, IMapper mapper)
            : base(enderecoRepository, mapper)
        {
            _enderecoRepository = enderecoRepository;
            _mapper = mapper;
        }

    }
}
