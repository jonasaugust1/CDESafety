using CDESafety.Data.Dtos.AjudanteDto;
using CDESafety.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace CDESafety.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AjudanteController : ControllerBase
    {
        private AjudanteService _ajudanteService;

        public AjudanteController(AjudanteService ajudanteService)
        {
            _ajudanteService = ajudanteService;
        }

        [HttpPost]
        public IActionResult AdicionaAjudante([FromBody] CreateAjudanteDto createDto)
        {
            ReadAjudanteDto readDto = _ajudanteService.AdicionaAjudante(createDto);

            return CreatedAtAction(nameof(RecuperarAjudantePorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult RecuperarAjudante([FromQuery] string? nomeDoFilme, string? estado)
        {
            List<ReadAjudanteDto> readDto = _ajudanteService.RecuperarAjudante(nomeDoFilme, estado);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarAjudantePorId(int id)
        {
            ReadAjudanteDto readDto = _ajudanteService.RecuperarCinemaPorId(id);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaAjudante(int id)
        {
            Result result = _ajudanteService.DeletaCinema(id);

            if (result == null) return NotFound();

            return NoContent();
        }
    }
}
