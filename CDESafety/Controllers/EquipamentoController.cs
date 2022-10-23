using CDESafety.Data.Dtos.EquipamentoDto;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace CDESafety.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquipamentoController : ControllerBase
    {
        private EquipamentoService _equipamentoService;

        public EquipamentoController(EquipamentoService equipamentoService)
        {
            _equipamentoService = equipamentoService;
        }

        [HttpPost]
        public IActionResult AdicionaEquipamento([FromBody] CreateEquipamentoDto createDto)
        {
            ReadEquipamentoDto readDto = _equipamentoService.AdicionaEquipamento(createDto);

            return CreatedAtAction(nameof(RecuperarEquipamentoPorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult RecuperarEquipamento([FromQuery] string? nomeDoFilme, string? estado)
        {
            List<ReadEquipamentoDto> readDto = _equipamentoService.RecuperarEquipamento(nomeDoFilme, estado);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarEquipamentoPorId(int id)
        {
            ReadEquipamentoDto readDto = _equipamentoService.RecuperarCinemaPorId(id);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaEquipamento(int id)
        {
            Result result = _equipamentoService.DeletaCinema(id);

            if (result == null) return NotFound();

            return NoContent();
        }
    }
}

