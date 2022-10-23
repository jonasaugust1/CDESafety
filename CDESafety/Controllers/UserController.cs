using CDESafety.Data.Dtos.UserDto;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace CDESafety.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult AdicionaUser([FromBody] CreateUserDto createDto)
        {
            ReadUserDto readDto = _userService.AdicionaUser(createDto);

            return CreatedAtAction(nameof(RecuperarUserPorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult RecuperarUser([FromQuery] string? nomeDoFilme, string? estado)
        {
            List<ReadUserDto> readDto = _userService.RecuperarUser(nomeDoFilme, estado);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarUserPorId(int id)
        {
            ReadUserDto readDto = _userService.RecuperarCinemaPorId(id);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaUser(int id, [FromBody] UpdateUserDto updateDto)
        {
            Result result = _userService.AtualizaCinema(id, updateDto);

            if (result.IsFailed) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaUser(int id)
        {
            Result result = _userService.DeletaCinema(id);

            if (result == null) return NotFound();

            return NoContent();
        }
    }
}
