﻿using System.ComponentModel.DataAnnotations;

namespace CDESafety.Models
{
    public class Propriedade
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        public List<Cliente> Clientes { get; set; }

        public List<RelatorioDeServico> RelatorioDeServicos { get; set; }
    }
}
