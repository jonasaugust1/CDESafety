using AutoMapper;
using CDESafety.Data.Dtos.AjudanteDto;
using CDESafety.Models;

namespace CDESafety.Profiles
{
    public class AjudanteProfile : Profile
    {
        public AjudanteProfile()
        {
            CreateMap<CreateAjudanteDto, Ajudante>();
            CreateMap<Ajudante, ReadAjudanteDto>();
        }
    }
}
