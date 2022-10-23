using AutoMapper;
using CDESafety.Data.Dtos.PropriedadeDto;
using CDESafety.Models;

namespace CDESafety.Profiles
{
    public class PropriedadeProfile : Profile
    {
        public PropriedadeProfile()
        {
            CreateMap<CreatePropriedadeDto, Propriedade>();
            CreateMap<Propriedade, ReadPropriedadeDto>();
        }
    }
}
