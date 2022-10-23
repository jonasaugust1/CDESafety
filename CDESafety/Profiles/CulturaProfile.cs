using AutoMapper;
using CDESafety.Data.Dtos.CulturaDto;
using CDESafety.Models;

namespace CDESafety.Profiles
{
    public class CulturaProfile : Profile
    {
        public CulturaProfile()
        {
            CreateMap<CreateCulturaDto, Cultura>();
            CreateMap<Cultura, ReadCulturaDto>();
        }
    }
}
