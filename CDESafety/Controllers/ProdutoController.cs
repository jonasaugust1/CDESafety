using CDESafety.Data.Dtos.ProdutoDto;
using CDESafety.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace CDESafety.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private ProdutoService _produtoService;

        public ProdutoController(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpPost]
        public IActionResult AdicionaProduto([FromBody] CreateProdutoDto createDto)
        {
            ReadProdutoDto readDto = _produtoService.AdicionaProduto(createDto);

            return CreatedAtAction(nameof(RecuperarProdutoPorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult RecuperarProduto()
        {
            List<ReadProdutoDto> readDto = _produtoService.RecuperarProduto();

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarProdutoPorId(int id)
        {
            ReadProdutoDto readDto = _produtoService.RecuperarProdutoPorId(id);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaProduto(int id)
        {
            Result result = _produtoService.DeletaProduto(id);

            if (result == null) return NotFound();

            return NoContent();
        }
    }
}
