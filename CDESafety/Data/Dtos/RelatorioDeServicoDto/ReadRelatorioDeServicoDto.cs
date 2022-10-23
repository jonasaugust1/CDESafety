using CDESafety.Models;
using System.ComponentModel.DataAnnotations;

namespace CDESafety.Data.Dtos.RelatorioDeServicoDto
{
    public class ReadRelatorioDeServicoDto
    {
        public int Id { get; set; }

        public int Numero { get; set; }

        public DateTime DataDeEmissao { get; set; }

        public List<Cliente> Clientes { get; set; }

        public List<Propriedade> Propriedades { get; set; }

        public Pista Pista { get; set; }

        public int PistaId { get; set; }

        public List<Cultura> Culturas { get; set; }

        public List<Equipamento> Equipamentos { get; set; }

        public int Volume { get; set; }

        public string Tipo { get; set; }

        public string EngAgronomo { get; set; }

        public int NumeroReceituario { get; set; }

        public DateTime ReceituarioEmissao { get; set; }

        public Aeronave Aeronave { get; set; }

        public int AeronaveId { get; set; }

        public DateTime AplicacaoMatutinoInicio { get; set; }
        public DateTime AplicacaoMatutinoFim { get; set; }
        public DateTime AplicacaoVespertinoInicio { get; set; }
        public DateTime AplicacaoVespertinoFim { get; set; }

        public float HorimetroInicial { get; set; }

        public float HorimetroFinal { get; set; }

        public float Translado { get; set; }

        public Piloto Piloto { get; set; }

        public int PilotoId { get; set; }

        public List<Ajudante> Ajudantes { get; set; }

        public float AlturaVoo { get; set; }

        public float Area { get; set; }

        public float Talhao { get; set; }

        public float Faixa { get; set; }

        public float Carga { get; set; }

        public float Vazao { get; set; }

        public bool UsoGPS { get; set; }

        public int TemperaturaMatutinoInicial { get; set; }
        public int TemperaturaMatutinoFinal { get; set; }
        public int UmidadeArMatutinoInicial { get; set; }
        public int UmidadeArMatutinoFinal { get; set; }
        public int VentoMatutinoInicial { get; set; }
        public int VentoMatutinoFinal { get; set; }
        public int TemperaturaVespertinoInicial { get; set; }
        public int TemperaturaVespertinoFinal { get; set; }
        public int UmidadeArVespertinoInicial { get; set; }
        public int UmidadeArVespertinoFinal { get; set; }
        public int VentoVespertinoInicial { get; set; }
        public int VentoVespertinoFinal { get; set; }

        public string Combustivel { get; set; }

        public int CombustivelQtd { get; set; }

        public int CombustivelOrigem { get; set; }

        public float PrecoHora { get; set; }
    }
}
