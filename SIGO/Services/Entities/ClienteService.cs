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

        public async Task Create(ClienteF entityF)
        {
                await _clienteRepository.Add(entityF);
        }

        public async Task Create(Cliente cliente)
        {
            await _clienteRepository.Add(cliente);
        }

        public async Task Create(ClienteJ entityJ)
        {
                await _clienteRepository.Add(entityJ);
        }

        public async Task<IEnumerable<ClienteDTO>> GetByName(string nome)
        {
            var entities = await _clienteRepository.GetByName(nome);
            return _mapper.Map<IEnumerable<ClienteDTO>>(entities);
        }

        public async Task<ClienteDTO?> GetByIdWithDetails(int id)
        {
            var entity = await _clienteRepository.GetByIdWithDetails(id);
            return _mapper.Map<ClienteDTO?>(entity);
        }

        public override async Task<IEnumerable<ClienteDTO>> GetAll()
        {
            var entities = await _clienteRepository.Get();
            return _mapper.Map<IEnumerable<ClienteDTO>>(entities);
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