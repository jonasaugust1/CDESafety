﻿using CDESafety.Data.Dtos.PistaDto;
using CDESafety.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace CDESafety.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PistaController : ControllerBase
    {
        private PistaService _pistaService;

        public PistaController(PistaService pistaService)
        {
            _pistaService = pistaService;
        }

        [HttpPost]
        public IActionResult AdicionaPista([FromBody] CreatePistaDto createDto)
        {
            ReadPistaDto readDto = _pistaService.AdicionaPista(createDto);

            return CreatedAtAction(nameof(RecuperarPistaPorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult RecuperarPista()
        {
            List<ReadPistaDto> readDto = _pistaService.RecuperarPista();

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarPistaPorId(int id)
        {
            ReadPistaDto readDto = _pistaService.RecuperarPistaPorId(id);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaPista(int id)
        {
            Result result = _pistaService.DeletaPista(id);

            if (result == null) return NotFound();

            return NoContent();
        }
    }
}
