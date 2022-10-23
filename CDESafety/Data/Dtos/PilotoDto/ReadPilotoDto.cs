using System.ComponentModel.DataAnnotations;

namespace CDESafety.Data.Dtos.PilotoDto
{
    public class ReadPilotoDto
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        public int CodigoAnac { get; set; }
        public int Comissao { get; set; }
        public DateTime HoraDaConsulta { get; set; }
    }
}
