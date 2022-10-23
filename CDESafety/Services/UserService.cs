using AutoMapper;
using CDESafety.Data.Dtos.UserDto;
using CDESafety.Data;
using CDESafety.Models;
using FluentResults;

namespace CDESafety.Services
{
    public class UserService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public UserService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadUserDto AdicionaUser(CreateUserDto userDto)
        {
            User user = _mapper.Map<User>(userDto);
            _context.Users.Add(user);
            _context.SaveChanges();
            return _mapper.Map<ReadUserDto>(user);
        }

        public List<ReadUserDto> RecuperarUser()
        {
            List<User> users = _context.Users.ToList();

            if (users == null) return null;

            List<ReadUserDto> readDto = _mapper.Map<List<ReadUserDto>>(users);

            return readDto;
        }


        public ReadUserDto RecuperarUserPorId(int id)
        {
            User user = _context.Users.FirstOrDefault(user => user.Id == id);

            if (user != null)
            {
                ReadUserDto userDto = _mapper.Map<ReadUserDto>(user);

                return userDto;
            }

            return null;
        }

        public Result AtualizaUser(int id, UpdateUserDto userDto)
        {
            User user = _context.Users.FirstOrDefault(user => user.Id == id);

            if (user == null) return Result.Fail("User não encontrado");

            _mapper.Map(userDto, user);

            _context.SaveChanges();

            return Result.Ok();
        }

        public Result DeletaUser(int id)
        {
            User user = _context.Users.FirstOrDefault(user => user.Id == id);

            if (user == null) return Result.Fail("User não encontrado");

            _context.Remove(user);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
