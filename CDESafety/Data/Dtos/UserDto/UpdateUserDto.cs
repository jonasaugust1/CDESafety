using System.ComponentModel.DataAnnotations;

namespace CDESafety.Data.Dtos.UserDto
{
    public class UpdateUserDto
    {
        [Required(ErrorMessage = "O campo Email é obrigatório")]
        public string Email { get; set; }
    }
}
