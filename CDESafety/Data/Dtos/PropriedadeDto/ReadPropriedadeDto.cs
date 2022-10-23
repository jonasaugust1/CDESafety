using System.ComponentModel.DataAnnotations;

namespace CDESafety.Data.Dtos.PropriedadeDto
{
    public class ReadPropriedadeDto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime HoraDaConsulta { get; set; }
    }
}
