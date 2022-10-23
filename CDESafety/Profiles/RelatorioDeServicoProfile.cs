using AutoMapper;
using CDESafety.Data.Dtos.RelatorioDeServicoDto;
using CDESafety.Models;

namespace CDESafety.Profiles
{
    public class RelatorioDeServicoProfile : Profile
    {
        public RelatorioDeServicoProfile()
        {
            CreateMap<CreateRelatorioDeServicoDto, RelatorioDeServico>();
            CreateMap<RelatorioDeServico, ReadRelatorioDeServicoDto>();
            CreateMap<UpdateRelatorioDeServicoDto, RelatorioDeServico>();
        }
    }
}
