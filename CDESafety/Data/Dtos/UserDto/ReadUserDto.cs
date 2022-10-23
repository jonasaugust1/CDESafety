using System.ComponentModel.DataAnnotations;

namespace CDESafety.Data.Dtos.UserDto
{
    public class ReadUserDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HoraDaConsulta { get; set; }
    }
}
