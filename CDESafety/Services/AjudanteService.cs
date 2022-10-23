using AutoMapper;
using CDESafety.Data.Dtos.AjudanteDto;
using CDESafety.Data;
using CDESafety.Models;
using FluentResults;

namespace CDESafety.Services
{
    public class AjudanteService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public AjudanteService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadAjudanteDto AdicionaAjudante(CreateAjudanteDto clienteDto)
        {
            Ajudante ajudante = _mapper.Map<Ajudante>(clienteDto);
            _context.Ajudantes.Add(ajudante);
            _context.SaveChanges();
            return _mapper.Map<ReadAjudanteDto>(ajudante);
        }

        public List<ReadAjudanteDto> RecuperarAjudante()
        {
            List<Ajudante> ajudantes = _context.Ajudantes.ToList();

            if (ajudantes == null) return null;

            List<ReadAjudanteDto> readDto = _mapper.Map<List<ReadAjudanteDto>>(ajudantes);

            return readDto;
        }


        public ReadAjudanteDto RecuperarAjudantePorId(int id)
        {
            Ajudante ajudante = _context.Ajudantes.FirstOrDefault(ajudante => ajudante.Id == id);

            if (ajudante != null)
            {
                ReadAjudanteDto ajudanteDto = _mapper.Map<ReadAjudanteDto>(ajudante);

                return ajudanteDto;
            }

            return null;
        }

        public Result DeletaAjudante(int id)
        {
            Ajudante ajudante = _context.Ajudantes.FirstOrDefault(ajudante => ajudante.Id == id);

            if (ajudante == null) return Result.Fail("Ajudante não encontrado");

            _context.Remove(ajudante);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
