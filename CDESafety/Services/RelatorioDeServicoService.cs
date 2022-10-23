using AutoMapper;
using CDESafety.Data.Dtos.RelatorioDeServicoDto;
using CDESafety.Data;
using CDESafety.Models;
using FluentResults;
using CDESafety.Data.Dtos.UserDto;

namespace CDESafety.Services
{
    public class RelatorioDeServicoService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public RelatorioDeServicoService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadRelatorioDeServicoDto AdicionaRelatorioDeServico(CreateRelatorioDeServicoDto relatorioDeServicoDto)
        {
            RelatorioDeServico relatorioDeServico = _mapper.Map<RelatorioDeServico>(relatorioDeServicoDto);
            _context.RelatorioDeServicos.Add(relatorioDeServico);
            _context.SaveChanges();
            return _mapper.Map<ReadRelatorioDeServicoDto>(relatorioDeServico);
        }

        public List<ReadRelatorioDeServicoDto> RecuperarRelatorioDeServico()
        {
            List<RelatorioDeServico> relatorioDeServicos = _context.RelatorioDeServicos.ToList();

            if (relatorioDeServicos == null) return null;

            List<ReadRelatorioDeServicoDto> readDto = _mapper.Map<List<ReadRelatorioDeServicoDto>>(relatorioDeServicos);

            return readDto;
        }


        public ReadRelatorioDeServicoDto RecuperarRelatorioDeServicoPorId(int id)
        {
            RelatorioDeServico relatorioDeServico = _context.RelatorioDeServicos.FirstOrDefault(relatorioDeServico => relatorioDeServico.Id == id);

            if (relatorioDeServico != null)
            {
                ReadRelatorioDeServicoDto relatorioDeServicoDto = _mapper.Map<ReadRelatorioDeServicoDto>(relatorioDeServico);

                return relatorioDeServicoDto;
            }

            return null;
        }

        public Result AtualizaRelatorioDeServico(int id, UpdateRelatorioDeServicoDto updateDto)
        {
            RelatorioDeServico relatorioDeServico = _context.RelatorioDeServicos.FirstOrDefault(rs => rs.Id == id);

            if (relatorioDeServico == null) return Result.Fail("User não encontrado");

            _mapper.Map(updateDto, relatorioDeServico);

            _context.SaveChanges();

            return Result.Ok();
        }

        public Result DeletaRelatorioDeServico(int id)
        {
            RelatorioDeServico relatorioDeServico = _context.RelatorioDeServicos.FirstOrDefault(relatorioDeServico => relatorioDeServico.Id == id);

            if (relatorioDeServico == null) return Result.Fail("Relatorio De Servico não encontrado");

            _context.Remove(relatorioDeServico);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
