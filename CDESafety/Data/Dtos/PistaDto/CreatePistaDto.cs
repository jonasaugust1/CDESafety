using System.ComponentModel.DataAnnotations;

namespace CDESafety.Data.Dtos.PistaDto
{
    public class CreatePistaDto
    {
        [Required(ErrorMessage = "O campo Indicativo é obrigatório")]
        public string Indicativo { get; set; }
    }
}
