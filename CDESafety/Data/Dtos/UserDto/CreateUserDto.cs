using System.ComponentModel.DataAnnotations;

namespace CDESafety.Data.Dtos.UserDto
{
    public class CreateUserDto
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Data de Nascimento é obrigatório")]
        public DateTime BirthDate { get; set; }
    }
}
