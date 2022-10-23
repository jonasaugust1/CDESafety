using System.ComponentModel.DataAnnotations;

namespace CDESafety.Data.Dtos.EquipamentoDto
{
    public class CreateEquipamentoDto
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }
    }
}
