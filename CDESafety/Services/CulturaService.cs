using AutoMapper;
using CDESafety.Data.Dtos.CulturaDto;
using CDESafety.Data;
using CDESafety.Models;
using FluentResults;

namespace CDESafety.Services
{
    public class CulturaService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public CulturaService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadCulturaDto AdicionaCultura(CreateCulturaDto culturaDto)
        {
            Cultura cultura = _mapper.Map<Cultura>(culturaDto);
            _context.Culturas.Add(cultura);
            _context.SaveChanges();
            return _mapper.Map<ReadCulturaDto>(cultura);
        }

        public List<ReadCulturaDto> RecuperarCulturas()
        {
            List<Cultura> culturas = _context.Culturas.ToList();

            if (culturas == null) return null;

            List<ReadCulturaDto> readDto = _mapper.Map<List<ReadCulturaDto>>(culturas);

            return readDto;
        }


        public ReadCulturaDto RecuperarCulturaPorId(int id)
        {
            Cultura cultura = _context.Culturas.FirstOrDefault(cultura => cultura.Id == id);

            if (cultura != null)
            {
                ReadCulturaDto culturaDto = _mapper.Map<ReadCulturaDto>(cultura);

                return culturaDto;
            }

            return null;
        }

        public Result DeletaCultura(int id)
        {
            Cultura cultura = _context.Culturas.FirstOrDefault(cultura => cultura.Id == id);

            if (cultura == null) return Result.Fail("Cultura não encontrado");

            _context.Remove(cultura);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
