using AutoMapper;
using CDESafety.Data.Dtos.PistaDto;
using CDESafety.Models;

namespace CDESafety.Profiles
{
    public class PistaProfile : Profile
    {
        public PistaProfile()
        {
            CreateMap<CreatePistaDto, Pista>();
            CreateMap<Pista, ReadPistaDto>();
        }
    }
}
