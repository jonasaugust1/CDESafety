using System.ComponentModel.DataAnnotations;

namespace CDESafety.Data.Dtos.AjudanteDto
{
    public class CreateAjudanteDto
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }
    }
}
