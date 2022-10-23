using CDESafety.Data.Dtos.PropriedadeDto;
using CDESafety.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace CDESafety.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropriedadeController : ControllerBase
    {
        private PropriedadeService _propriedadeService;

        public PropriedadeController(PropriedadeService propriedadeService)
        {
            _propriedadeService = propriedadeService;
        }

        [HttpPost]
        public IActionResult AdicionaPropriedade([FromBody] CreatePropriedadeDto createDto)
        {
            ReadPropriedadeDto readDto = _propriedadeService.AdicionaPropriedade(createDto);

            return CreatedAtAction(nameof(RecuperarPropriedadePorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult RecuperarPropriedade()
        {
            List<ReadPropriedadeDto> readDto = _propriedadeService.RecuperarPropriedade();

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarPropriedadePorId(int id)
        {
            ReadPropriedadeDto readDto = _propriedadeService.RecuperarPropriedadePorId(id);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaPropriedade(int id)
        {
            Result result = _propriedadeService.DeletaPropriedade(id);

            if (result == null) return NotFound();

            return NoContent();
        }
    }
}
