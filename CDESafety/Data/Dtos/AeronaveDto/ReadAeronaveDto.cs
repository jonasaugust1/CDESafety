using CDESafety.Models;
using System.ComponentModel.DataAnnotations;

namespace CDESafety.Data.Dtos.AeronaveDto
{
    public class ReadAeronaveDto
    {
        public int Id { get; set; }
        public string Prefixo { get; set; }

        public DateTime HoraDaConsulta { get; set; }
    }
}
