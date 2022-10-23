using AutoMapper;
using CDESafety.Data.Dtos.PropriedadeDto;
using CDESafety.Data;
using CDESafety.Models;
using FluentResults;

namespace CDESafety.Services
{
    public class PropriedadeService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public PropriedadeService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadPropriedadeDto AdicionaPropriedade(CreatePropriedadeDto propriedadeDto)
        {
            Propriedade propriedade = _mapper.Map<Propriedade>(propriedadeDto);
            _context.Propriedades.Add(propriedade);
            _context.SaveChanges();
            return _mapper.Map<ReadPropriedadeDto>(propriedade);
        }

        public List<ReadPropriedadeDto> RecuperarPropriedade()
        {
            List<Propriedade> propriedades = _context.Propriedades.ToList();

            if (propriedades == null) return null;

            List<ReadPropriedadeDto> readDto = _mapper.Map<List<ReadPropriedadeDto>>(propriedades);

            return readDto;
        }


        public ReadPropriedadeDto RecuperarPropriedadePorId(int id)
        {
            Propriedade propriedade = _context.Propriedades.FirstOrDefault(propriedade => propriedade.Id == id);

            if (propriedade != null)
            {
                ReadPropriedadeDto propriedadeDto = _mapper.Map<ReadPropriedadeDto>(propriedade);

                return propriedadeDto;
            }

            return null;
        }

        public Result DeletaPropriedade(int id)
        {
            Propriedade propriedade = _context.Propriedades.FirstOrDefault(propriedade => propriedade.Id == id);

            if (propriedade == null) return Result.Fail("Propriedade não encontrado");

            _context.Remove(propriedade);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
