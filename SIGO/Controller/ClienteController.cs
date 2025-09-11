using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIGO.Objects.Contracts;
using SIGO.Objects.Dtos.Entities;
using SIGO.Objects.Models;
using SIGO.Services.Interfaces;

namespace SIGO.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        private readonly Response _response;
        private readonly IMapper _mapper;

        public ClienteController(IClienteService clienteService, IMapper mapper)
        {
            _clienteService = clienteService;
            _mapper = mapper;
            _response = new Response();
        }

        [HttpGet]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var clienteDto = await _clienteService.GetAll();

            _response.Code = ResponseEnum.SUCCESS;
            _response.Data = clienteDto;
            _response.Message = "Clientes listados com sucesso";

            return Ok(_response);
        }

        [HttpGet("nome/{nome}")]
        public async Task<IActionResult> GetByName(string nome)
        {
            var clienteDto = await _clienteService.GetByName(nome);

            if (clienteDto is null)
            {
                _response.Code = ResponseEnum.NOT_FOUND;
                _response.Data = null;
                _response.Message = "Cliente não encontrado";

                return NotFound(_response);
            }

            _response.Code = ResponseEnum.SUCCESS;
            _response.Data = clienteDto;
            _response.Message = "Cliente listado com sucesso";

            return Ok(_response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var clienteDto = await _clienteService.GetByIdWithDetails(id);

            if (clienteDto is null)
            {
                _response.Code = ResponseEnum.NOT_FOUND;
                _response.Data = null;
                _response.Message = "Cliente não encontrado";
                return NotFound(_response);
            }

            _response.Code = ResponseEnum.SUCCESS;
            _response.Data = clienteDto;
            _response.Message = "Cliente encontrado com sucesso";

            return Ok(_response);
        }


        [HttpPost]
        public async Task<IActionResult> Post(ClienteDTO clienteDTO)
        {
            //Modifique aqui Cestonaro e remova o return
            return NoContent();
        }

        [HttpPut("f/{id}")]
        public async Task<IActionResult> PutF([FromRoute] int id, [FromBody] ClienteFDTO clienteFDTO)
        {
            if (clienteFDTO is null)
            {
                _response.Code = ResponseEnum.INVALID;
                _response.Data = null;
                _response.Message = "Dados inválidos para Cliente F";
                return BadRequest(_response);
            }

            try
            {

                var entityF = _mapper.Map<ClienteF>(clienteFDTO);

                await _clienteService.Update(entityF, id);

                _response.Code = ResponseEnum.SUCCESS;
                _response.Data = clienteFDTO;
                _response.Message = "Cliente F atualizado com sucesso";
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.Code = ResponseEnum.ERROR;
                _response.Message = "Ocorreu um erro ao atualizar Cliente F";
                _response.Data = new
                {
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace ?? "No stack trace disponível"
                };
                return StatusCode(StatusCodes.Status500InternalServerError, _response);
            }
        }

        [HttpPut("j/{id}")]
        public async Task<IActionResult> PutJ([FromRoute] int id, [FromBody] ClienteJDTO clienteJDTO)
        {
            if (clienteJDTO is null)
            {
                _response.Code = ResponseEnum.INVALID;
                _response.Data = null;
                _response.Message = "Dados inválidos para Cliente J";
                return BadRequest(_response);
            }

            try
            {
                var entityJ = _mapper.Map<ClienteJ>(clienteJDTO);

                await _clienteService.Update(entityJ, id);

                _response.Code = ResponseEnum.SUCCESS;
                _response.Data = clienteJDTO;
                _response.Message = "Cliente J atualizado com sucesso";
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.Code = ResponseEnum.ERROR;
                _response.Message = "Ocorreu um erro ao atualizar Cliente J";
                _response.Data = new
                {
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace ?? "No stack trace disponível"
                };
                return StatusCode(StatusCodes.Status500InternalServerError, _response);
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            //Modifique aqui Cristiano e remova o return
            return NoContent();
        }
    }
}
