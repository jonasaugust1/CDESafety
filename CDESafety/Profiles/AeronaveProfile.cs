using AutoMapper;
using CDESafety.Data.Dtos.AeronaveDto;
using CDESafety.Models;

namespace CDESafety.Profiles
{
    public class AeronaveProfile : Profile
    {
        public AeronaveProfile()
        {
            CreateMap<CreateAeronaveDto, Aeronave>();
            CreateMap<Aeronave, ReadAeronaveDto>();
        }
    }
}
