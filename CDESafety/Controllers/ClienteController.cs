using CDESafety.Data.Dtos.ClienteDto;
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
        public IActionResult RecuperarCliente([FromQuery] string? nomeDoFilme, string? estado)
        {
            List<ReadClienteDto> readDto = _clienteService.RecuperarCliente(nomeDoFilme, estado);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarClientePorId(int id)
        {
            ReadClienteDto readDto = _clienteService.RecuperarCinemaPorId(id);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaCliente(int id)
        {
            Result result = _clienteService.DeletaCinema(id);

            if (result == null) return NotFound();

            return NoContent();
        }
    }
}
