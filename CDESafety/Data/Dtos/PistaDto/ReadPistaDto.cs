using System.ComponentModel.DataAnnotations;

namespace CDESafety.Data.Dtos.PistaDto
{
    public class ReadPistaDto
    {
        public int Id { get; set; }

        public string Indicativo { get; set; }

        public DateTime HoraDaConsulta { get; set; }
    }
}
