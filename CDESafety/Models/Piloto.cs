using System.ComponentModel.DataAnnotations;

namespace CDESafety.Models
{
    public class Piloto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Código ANAC é obrigatório")]
        public int CodigoAnac { get; set; }

        [Required(ErrorMessage = "O campo Comissao é obrigatório")]
        public int Comissao { get; set; }

        public List<RelatorioDeServico> RelatorioDeServico { get; set; }
    }
}
