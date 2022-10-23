using System.ComponentModel.DataAnnotations;

namespace CDESafety.Data.Dtos.CulturaDto
{
    public class ReadCulturaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime HoraDaConsulta { get; set; }
    }
}
