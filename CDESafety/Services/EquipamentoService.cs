using AutoMapper;
using CDESafety.Data.Dtos.EquipamentoDto;
using CDESafety.Data;
using CDESafety.Models;
using FluentResults;

namespace CDESafety.Services
{
    public class EquipamentoService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public EquipamentoService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadEquipamentoDto AdicionaEquipamento(CreateEquipamentoDto equipamentoDto)
        {
            Equipamento equipamento = _mapper.Map<Equipamento>(equipamentoDto);
            _context.Equipamentos.Add(equipamento);
            _context.SaveChanges();
            return _mapper.Map<ReadEquipamentoDto>(equipamento);
        }

        public List<ReadEquipamentoDto> RecuperarEquipamento()
        {
            List<Equipamento> equipamentos = _context.Equipamentos.ToList();

            if (equipamentos == null) return null;

            List<ReadEquipamentoDto> readDto = _mapper.Map<List<ReadEquipamentoDto>>(equipamentos);

            return readDto;
        }


        public ReadEquipamentoDto RecuperarEquipamentoPorId(int id)
        {
            Equipamento equipamento = _context.Equipamentos.FirstOrDefault(equipamento => equipamento.Id == id);

            if (equipamento != null)
            {
                ReadEquipamentoDto equipamentoDto = _mapper.Map<ReadEquipamentoDto>(equipamento);

                return equipamentoDto;
            }

            return null;
        }

        public Result DeletaEquipamento(int id)
        {
            Equipamento equipamento = _context.Equipamentos.FirstOrDefault(equipamento => equipamento.Id == id);

            if (equipamento == null) return Result.Fail("Equipamento não encontrado");

            _context.Remove(equipamento);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
