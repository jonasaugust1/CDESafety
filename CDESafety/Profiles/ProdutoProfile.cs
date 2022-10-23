using AutoMapper;
using CDESafety.Data.Dtos.ProdutoDto;
using CDESafety.Models;

namespace CDESafety.Profiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<CreateProdutoDto, Produto>();
            CreateMap<Produto, ReadProdutoDto>();
        }
    }
}
