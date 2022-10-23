using CDESafety.Data.Dtos.ClienteDto;
using CDESafety.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace CDESafety.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private ClienteService _clienteService;

        public ClienteController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        public IActionResult AdicionaCliente([FromBody] CreateClienteDto createDto)
        {
            ReadClienteDto readDto = _clienteService.AdicionaCliente(createDto);

            return CreatedAtAction(nameof(RecuperarClientePorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult RecuperarCliente()
        {
            List<ReadClienteDto> readDto = _clienteService.RecuperarCliente();

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarClientePorId(int id)
        {
            ReadClienteDto readDto = _clienteService.RecuperarClientePorId(id);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaCliente(int id)
        {
            Result result = _clienteService.DeletaCliente(id);

            if (result == null) return NotFound();

            return NoContent();
        }
    }
}
