﻿using CDESafety.Data.Dtos.PilotoDto;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace CDESafety.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PilotoController : ControllerBase
    {
        private PilotoService _pilotoService;

        public PilotoController(PilotoService pilotoService)
        {
            _pilotoService = pilotoService;
        }

        [HttpPost]
        public IActionResult AdicionaPiloto([FromBody] CreatePilotoDto createDto)
        {
            ReadPilotoDto readDto = _pilotoService.AdicionaPiloto(createDto);

            return CreatedAtAction(nameof(RecuperarPilotoPorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult RecuperarPiloto([FromQuery] string? nomeDoFilme, string? estado)
        {
            List<ReadPilotoDto> readDto = _pilotoService.RecuperarPiloto(nomeDoFilme, estado);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarPilotoPorId(int id)
        {
            ReadPilotoDto readDto = _pilotoService.RecuperarCinemaPorId(id);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaPiloto(int id, [FromBody] UpdatePilotoDto updateDto)
        {
            Result result = _pilotoService.AtualizaCinema(id, updateDto);

            if (result.IsFailed) return NotFound();

            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaPiloto(int id)
        {
            Result result = _pilotoService.DeletaCinema(id);

            if (result == null) return NotFound();

            return NoContent();
        }
    }
}
