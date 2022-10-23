using System.ComponentModel.DataAnnotations;

namespace CDESafety.Data.Dtos.AeronaveDto
{
    public class CreateAeronaveDto
    {
        [Required(ErrorMessage = "O campo Prefixo é obrigatório")]
        public string Prefixo { get; set; }
    }
}
