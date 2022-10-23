using CDESafety.Data.Dtos.CulturaDto;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace CDESafety.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CulturaController : ControllerBase
    {
        private CulturaService _culturaService;

        public CulturaController(CulturaService culturaService)
        {
            _culturaService = culturaService;
        }

        [HttpPost]
        public IActionResult AdicionaCultura([FromBody] CreateCulturaDto createDto)
        {
            ReadCulturaDto readDto = _culturaService.AdicionaCultura(createDto);

            return CreatedAtAction(nameof(RecuperarCulturaPorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult RecuperarCultura([FromQuery] string? nomeDoFilme, string? estado)
        {
            List<ReadCulturaDto> readDto = _culturaService.RecuperarCultura(nomeDoFilme, estado);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarCulturaPorId(int id)
        {
            ReadCulturaDto readDto = _culturaService.RecuperarCinemaPorId(id);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaCultura(int id)
        {
            Result result = _culturaService.DeletaCinema(id);

            if (result == null) return NotFound();

            return NoContent();
        }
    }
}
