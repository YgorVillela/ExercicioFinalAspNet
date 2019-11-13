using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAspCore
{
    public class Jogo
    {
        [Key]
        public int JogoId { get; set; }
        
        [Required]
        public string Nome { get; set; }

        [Required,DataType(DataType.Date), Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }
        [Required]
        public Plataforma Plataforma { get; set; }
        public bool Disponivel { get; set; }
        public Genero Genero { get; set; }
        public int GeneroId { get; set; }
    }
}
