using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Jokenpo.Models
{
   public class JogadorModelo
    {
        public int id { get; set; }
        [Required(ErrorMessage = "O Nome deve conter pelo menos um caractere")]
        [MinLength(1, ErrorMessage = "O Nome deve conter pelo menos um caractere.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Sobrenome obrigatório")]
        public string SobreNome { get; set; }
        public Movementos movementos { get; set; }

        public string CaminhoFoto { get; set; }

        public bool vencedor { get; set; }

    }
}
