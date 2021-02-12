using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Services.Models
{
    public class CalculaParcelaModel
    {
        [Required]
        [Range(1, 999, ErrorMessage = "Por favor, Digite um número Inteiro, entre 1 e 999")]
        public int prazo { get; set; }
        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Por favor Digite um valor válido")]
        public double valor { get; set; }
        
    }
}
