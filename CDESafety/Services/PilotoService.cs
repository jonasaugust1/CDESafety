using AutoMapper;
using CDESafety.Data.Dtos.PilotoDto;
using CDESafety.Data;
using CDESafety.Models;
using FluentResults;

namespace CDESafety.Services
{
    public class PilotoService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public PilotoService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadPilotoDto AdicionaPiloto(CreatePilotoDto pilotoDto)
        {
            Piloto piloto = _mapper.Map<Piloto>(pilotoDto);
            _context.Pilotos.Add(piloto);
            _context.SaveChanges();
            return _mapper.Map<ReadPilotoDto>(piloto);
        }

        public List<ReadPilotoDto> RecuperarPilotos()
        {
            List<Piloto> pilotos = _context.Pilotos.ToList();

            if (pilotos == null) return null;

            List<ReadPilotoDto> readDto = _mapper.Map<List<ReadPilotoDto>>(pilotos);

            return readDto;
        }


        public ReadPilotoDto RecuperarPilotoPorId(int id)
        {
            Piloto piloto = _context.Pilotos.FirstOrDefault(piloto => piloto.Id == id);

            if (piloto != null)
            {
                ReadPilotoDto pilotoDto = _mapper.Map<ReadPilotoDto>(piloto);

                return pilotoDto;
            }

            return null;
        }

        public Result DeletaPiloto(int id)
        {
            Piloto piloto = _context.Pilotos.FirstOrDefault(piloto => piloto.Id == id);

            if (piloto == null) return Result.Fail("Piloto não encontrado");

            _context.Remove(piloto);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
