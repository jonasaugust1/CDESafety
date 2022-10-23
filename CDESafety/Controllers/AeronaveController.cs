using CDESafety.Data.Dtos.AeronaveDto;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace CDESafety.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AeronaveController : ControllerBase
    {
        private AeronaveService _aeronaveService;

        public AeronaveController(AeronaveService aeronaveService)
        {
            _aeronaveService = aeronaveService;
        }

        [HttpPost]
        public IActionResult AdicionaAeronave([FromBody] CreateAeronaveDto createDto)
        {
            ReadAeronaveDto readDto = _aeronaveService.AdicionaAeronave(createDto);

            return CreatedAtAction(nameof(RecuperarAeronavePorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult RecuperarAeronave([FromQuery] string? nomeDoFilme, string? estado)
        {
            List<ReadAeronaveDto> readDto = _aeronaveService.RecuperarAeronave(nomeDoFilme, estado);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarAeronavePorId(int id)
        {
            ReadAeronaveDto readDto = _aeronaveService.RecuperarCinemaPorId(id);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaAeronave(int id)
        {
            Result result = _aeronaveService.DeletaCinema(id);

            if (result == null) return NotFound();

            return NoContent();
        }
    }
}
