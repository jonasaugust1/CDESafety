using CDESafety.Models;
using System.ComponentModel.DataAnnotations;

namespace CDESafety.Data.Dtos.RelatorioDeServicoDto
{
    public class CreateRelatorioDeServicoDto
    {
        [Required(ErrorMessage = "O campo Numero é obrigatório")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "O campo Data de Emissão é obrigatório")]
        public DateTime DataDeEmissao { get; set; }

        [Required(ErrorMessage = "O campo PistaId é obrigatório")]
        public int PistaId { get; set; }

        [Required(ErrorMessage = "O campo Volume é obrigatório")]
        public int Volume { get; set; }

        [Required(ErrorMessage = "O campo Tipo é obrigatório")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "O campo Engenheiro Agrônomo é obrigatório")]
        public string EngAgronomo { get; set; }

        [Required(ErrorMessage = "O campo Receituário Número é obrigatório")]
        public int NumeroReceituario { get; set; }

        [Required(ErrorMessage = "O campo Receituário Emissão é obrigatório")]
        public DateTime ReceituarioEmissao { get; set; }

        [Required(ErrorMessage = "O campo AeronaveId Emissão é obrigatório")]
        public int AeronaveId { get; set; }

        public DateTime AplicacaoMatutinoInicio { get; set; }
        public DateTime AplicacaoMatutinoFim { get; set; }
        public DateTime AplicacaoVespertinoInicio { get; set; }
        public DateTime AplicacaoVespertinoFim { get; set; }

        [Required(ErrorMessage = "O campo Horímetro Inicial é obrigatório")]
        public float HorimetroInicial { get; set; }

        [Required(ErrorMessage = "O campo Horimetro Final é obrigatório")]
        public float HorimetroFinal { get; set; }

        [Required(ErrorMessage = "O campo Translado é obrigatório")]
        public float Translado { get; set; }

        [Required(ErrorMessage = "O campo PilotoId é obrigatório")]
        public int PilotoId { get; set; }

        [Required(ErrorMessage = "O campo Altura do Voo é obrigatório")]
        public float AlturaVoo { get; set; }

        [Required(ErrorMessage = "O campo Área é obrigatório")]
        public float Area { get; set; }

        [Required(ErrorMessage = "O campo Talhao é obrigatório")]
        public float Talhao { get; set; }

        [Required(ErrorMessage = "O campo Faixa é obrigatório")]
        public float Faixa { get; set; }

        [Required(ErrorMessage = "O campo Carga é obrigatório")]
        public float Carga { get; set; }

        [Required(ErrorMessage = "O campo Vazao é obrigatório")]
        public float Vazao { get; set; }

        [Required(ErrorMessage = "O campo Uso do GPS é obrigatório")]
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

        [Required(ErrorMessage = "O campo Combustível é obrigatório")]
        public string Combustivel { get; set; }

        [Required(ErrorMessage = "O campo Combustível Quantidade é obrigatório")]
        public int CombustivelQtd { get; set; }

        [Required(ErrorMessage = "O campo Combustível Origem é obrigatório")]
        public int CombustivelOrigem { get; set; }

        public float PrecoHora { get; set; }
    }
}
