using CDESafety.Data.Dtos.RelatorioDeServicoDto;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace CDESafety.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RelatorioDeServicoController : ControllerBase
    {
        private RelatorioDeServicoService _relatorioDeServicoService;

        public RelatorioDeServicoController(RelatorioDeServicoService relatorioDeServicoService)
        {
            _relatorioDeServicoService = relatorioDeServicoService;
        }

        [HttpPost]
        public IActionResult AdicionaRelatorioDeServico([FromBody] CreateRelatorioDeServicoDto createDto)
        {
            ReadRelatorioDeServicoDto readDto = _relatorioDeServicoService.AdicionaRelatorioDeServico(createDto);

            return CreatedAtAction(nameof(RecuperarRelatorioDeServicoPorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult RecuperarRelatorioDeServico([FromQuery] string? nomeDoFilme, string? estado)
        {
            List<ReadRelatorioDeServicoDto> readDto = _relatorioDeServicoService.RecuperarRelatorioDeServico(nomeDoFilme, estado);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarRelatorioDeServicoPorId(int id)
        {
            ReadRelatorioDeServicoDto readDto = _relatorioDeServicoService.RecuperarCinemaPorId(id);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaRelatorioDeServico(int id, [FromBody] UpdateRelatorioDeServicoDto updateDto)
        {
            Result result = _relatorioDeServicoService.AtualizaCinema(id, updateDto);

            if (result.IsFailed) return NotFound();

            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaRelatorioDeServico(int id)
        {
            Result result = _relatorioDeServicoService.DeletaCinema(id);

            if (result == null) return NotFound();

            return NoContent();
        }
    }
}
