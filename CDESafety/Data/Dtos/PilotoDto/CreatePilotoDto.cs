using System.ComponentModel.DataAnnotations;

namespace CDESafety.Data.Dtos.PilotoDto
{
    public class CreatePilotoDto
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Código ANAC é obrigatório")]
        public int CodigoAnac { get; set; }

        [Required(ErrorMessage = "O campo Comissao é obrigatório")]
        public int Comissao { get; set; }
    }
}
