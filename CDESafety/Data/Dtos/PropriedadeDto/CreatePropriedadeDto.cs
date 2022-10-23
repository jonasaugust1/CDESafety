using System.ComponentModel.DataAnnotations;

namespace CDESafety.Data.Dtos.PropriedadeDto
{
    public class CreatePropriedadeDto
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }
    }
}
