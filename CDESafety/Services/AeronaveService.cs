using AutoMapper;
using CDESafety.Data;
using CDESafety.Data.Dtos.AeronaveDto;
using CDESafety.Models;
using FluentResults;

namespace CDESafety.Services
{
    public class AeronaveService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public AeronaveService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadAeronaveDto AdicionaAeronave(CreateAeronaveDto aeronaveDto)
        {
            Aeronave aeronave = _mapper.Map<Aeronave>(aeronaveDto);
            _context.Aeronaves.Add(aeronave);
            _context.SaveChanges();
            return _mapper.Map<ReadAeronaveDto>(aeronave);
        }

        public List<ReadAeronaveDto> RecuperarAeronaves()
        {
            List<Aeronave> aeronaves = _context.Aeronaves.ToList();

            if (aeronaves == null) return null;

            List<ReadAeronaveDto> readDto = _mapper.Map<List<ReadAeronaveDto>>(aeronaves);

            return readDto;
        }


        public ReadAeronaveDto RecuperarAeronavePorId(int id)
        {
            Aeronave aeronave = _context.Aeronaves.FirstOrDefault(aeronave => aeronave.Id == id);

            if (aeronave != null)
            {
                ReadAeronaveDto aeronaveDto = _mapper.Map<ReadAeronaveDto>(aeronave);

                return aeronaveDto;
            }

            return null;
        }

        public Result DeletaAeronave(int id)
        {
            Aeronave aeronave = _context.Aeronaves.FirstOrDefault(aeronave => aeronave.Id == id);

            if (aeronave == null) return Result.Fail("Aeronave não encontrado");

            _context.Remove(aeronave);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
