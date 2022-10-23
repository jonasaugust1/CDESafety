using AutoMapper;
using CDESafety.Data.Dtos.PilotoDto;
using CDESafety.Models;

namespace CDESafety.Profiles
{
    public class PilotoProfile : Profile
    {
        public PilotoProfile()
        {
            CreateMap<CreatePilotoDto, Piloto>();
            CreateMap<Piloto, ReadPilotoDto>();
            CreateMap<UpdatePilotoDto, Piloto>();
        }
    }
}
