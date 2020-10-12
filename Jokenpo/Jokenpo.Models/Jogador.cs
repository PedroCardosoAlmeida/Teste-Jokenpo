using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace Jokenpo.Models
{
    public class Jogador
    {
        public int id { get; set; }
        [Required(ErrorMessage ="O Nome deve conter pelo menos um caractere")]
        [MinLength(1,ErrorMessage ="O Nome deve conter pelo menos um caractere.")]
        public string Nome { get; set; }

        [Required (ErrorMessage ="Sobrenome obrigatório")]
        public string SobreNome { get; set; }
        public Movementos movementos { get; set; }

        public string CaminhoFoto { get; set; }
    }
}
