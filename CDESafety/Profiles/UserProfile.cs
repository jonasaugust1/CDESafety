using AutoMapper;
using CDESafety.Data.Dtos.UserDto;
using CDESafety.Models;

namespace CDESafety.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserDto, User>();
            CreateMap<User, ReadUserDto>();
            CreateMap<UpdateUserDto, User>();
        }
    }
}
