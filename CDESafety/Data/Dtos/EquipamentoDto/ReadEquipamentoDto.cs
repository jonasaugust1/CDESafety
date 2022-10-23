using System.ComponentModel.DataAnnotations;

namespace CDESafety.Data.Dtos.EquipamentoDto
{
    public class ReadEquipamentoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime HoraDaConsulta { get; set; }
    }
}
