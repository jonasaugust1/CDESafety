using AutoMapper;
using CDESafety.Data.Dtos.ClienteDto;
using CDESafety.Models;

namespace CDESafety.Profiles
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<CreateClienteDto, Cliente>();
            CreateMap<Cliente, ReadClienteDto>();
            CreateMap<UpdateClienteDto, Cliente>();
        }
    }
}
