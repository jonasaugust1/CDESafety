using System.ComponentModel.DataAnnotations;

namespace CDESafety.Data.Dtos.PilotoDto
{
    public class UpdatePilotoDto
    {
        [Required(ErrorMessage = "O campo Comissao é obrigatório")]
        public int Comissao { get; set; }
    }
}
