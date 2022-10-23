using CDESafety.Models;
using System.ComponentModel.DataAnnotations;

namespace CDESafety.Data.Dtos.ClienteDto
{
    public class UpdateClienteDto
    {

        [Required(ErrorMessage = "O campo Propriedade é obrigatório")]
        public List<Propriedade> Propriedades { get; set; }
    }
}
