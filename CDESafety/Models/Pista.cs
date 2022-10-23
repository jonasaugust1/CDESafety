using System.ComponentModel.DataAnnotations;

namespace CDESafety.Models
{
    public class Pista
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Indicativo é obrigatório")]
        public string Indicativo { get; set; }

        public List<RelatorioDeServico> RelatorioDeServicos { get; set; }
    }
}
