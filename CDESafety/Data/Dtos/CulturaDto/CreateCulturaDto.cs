using System.ComponentModel.DataAnnotations;

namespace CDESafety.Data.Dtos.CulturaDto
{
    public class CreateCulturaDto
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }
    }
}
