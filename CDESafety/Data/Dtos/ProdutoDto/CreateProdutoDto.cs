using System.ComponentModel.DataAnnotations;

namespace CDESafety.Data.Dtos.ProdutoDto
{
    public class CreateProdutoDto
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }
    }
}
