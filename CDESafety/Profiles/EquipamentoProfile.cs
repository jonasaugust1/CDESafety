using AutoMapper;
using CDESafety.Data.Dtos.EquipamentoDto;
using CDESafety.Models;

namespace CDESafety.Profiles
{
    public class EquipamentoProfile : Profile
    {
        public EquipamentoProfile()
        {
            CreateMap<CreateEquipamentoDto, Equipamento>();
            CreateMap<Equipamento, ReadEquipamentoDto>();
        }
    }
}
