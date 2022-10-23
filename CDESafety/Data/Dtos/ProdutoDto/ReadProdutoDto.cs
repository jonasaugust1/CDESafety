using System.ComponentModel.DataAnnotations;

namespace CDESafety.Data.Dtos.ProdutoDto
{
    public class ReadProdutoDto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime HoraDaConsulta { get; set; }
    }
}
