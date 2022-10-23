using System.ComponentModel.DataAnnotations;

namespace CDESafety.Models
{
    public class Aeronave
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Prefixo é obrigatório")]
        public string Prefixo { get; set; }

        public List<RelatorioDeServico> RelatorioDeServicos { get; set; }
    }
}
