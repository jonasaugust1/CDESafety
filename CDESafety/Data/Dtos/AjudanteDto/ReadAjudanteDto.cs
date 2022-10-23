using System.ComponentModel.DataAnnotations;

namespace CDESafety.Data.Dtos.AjudanteDto
{
    public class ReadAjudanteDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime HoraDaConsulta { get; set; }
    }
}
