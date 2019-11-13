using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAspCore
{
    public class Genero
    {
        [Key]
        public int GeneroId { get; set; }
        
        [Required]
        public string Nome { get; set; }
        public IList<Jogo> Jogos { get; set; }
    }
}
