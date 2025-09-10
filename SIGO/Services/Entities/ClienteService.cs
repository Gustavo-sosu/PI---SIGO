using AutoMapper;
using SIGO.Data.Interfaces;
using SIGO.Objects.Dtos.Entities;
using SIGO.Objects.Models;
using SIGO.Services.Interfaces;

namespace SIGO.Services.Entities
{
    public class ClienteService : GenericService<Cliente, ClienteDTO>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository clienteRepository, IMapper mapper)
            : base(clienteRepository, mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public async Task Update(ClienteF entityF, int id)
        {
            var existing = await _clienteRepository.GetById(id) as ClienteF;
            if (existing is null)
                throw new KeyNotFoundException("Cliente F não encontrado");

            existing.Nome = entityF.Nome;
            existing.Email = entityF.Email;
            existing.Senha = entityF.Senha;
            existing.Situacao = entityF.Situacao;
            existing.Cpf = entityF.Cpf;
            existing.DataNasc = entityF.DataNasc;
            existing.Sexo = entityF.Sexo;
            existing.Obs = entityF.Obs;

            await _clienteRepository.Update(existing);
        }

        public async Task Update(ClienteJ entityJ, int id)
        {
            var existing = await _clienteRepository.GetById(id) as ClienteJ;
            if (existing is null)
                throw new KeyNotFoundException("Cliente J não encontrado");

            existing.Nome = entityJ.Nome;
            existing.Email = entityJ.Email;
            existing.Senha = entityJ.Senha;
            existing.Situacao = entityJ.Situacao;
            existing.Cnpj = entityJ.Cnpj;
            existing.Razao = entityJ.Razao;

            await _clienteRepository.Update(existing);
        }
    }
}
