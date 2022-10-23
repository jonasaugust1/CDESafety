using AutoMapper;
using CDESafety.Data.Dtos.PistaDto;
using CDESafety.Data;
using CDESafety.Models;
using FluentResults;

namespace CDESafety.Services
{
    public class PistaService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public PistaService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadPistaDto AdicionaPista(CreatePistaDto pistaDto)
        {
            Pista pista = _mapper.Map<Pista>(pistaDto);
            _context.Pistas.Add(pista);
            _context.SaveChanges();
            return _mapper.Map<ReadPistaDto>(pista);
        }

        public List<ReadPistaDto> RecuperarPista()
        {
            List<Pista> pistas = _context.Pistas.ToList();

            if (pistas == null) return null;

            List<ReadPistaDto> readDto = _mapper.Map<List<ReadPistaDto>>(pistas);

            return readDto;
        }


        public ReadPistaDto RecuperarPistaPorId(int id)
        {
            Pista pista = _context.Pistas.FirstOrDefault(pista => pista.Id == id);

            if (pista != null)
            {
                ReadPistaDto pistaDto = _mapper.Map<ReadPistaDto>(pista);

                return pistaDto;
            }

            return null;
        }

        public Result DeletaPista(int id)
        {
            Pista pista = _context.Pistas.FirstOrDefault(pista => pista.Id == id);

            if (pista == null) return Result.Fail("Pista não encontrado");

            _context.Remove(pista);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
