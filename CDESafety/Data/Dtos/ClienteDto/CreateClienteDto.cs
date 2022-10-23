using CDESafety.Models;
using System.ComponentModel.DataAnnotations;

namespace CDESafety.Data.Dtos.ClienteDto
{
    public class CreateClienteDto
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "O campo Propriedade é obrigatório")]
        public List<Propriedade> Propriedades { get; set; }
    }
}
