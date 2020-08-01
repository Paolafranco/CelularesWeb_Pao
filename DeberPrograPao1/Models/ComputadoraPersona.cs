using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeberPrograPao1.Models
{
    public class ComputadoraPersona
    {
        [ForeignKey("Computadoras")]
        public int ComputadoraId { get; set; }
        public Computadora Computadoras { get; set; }

        [ForeignKey("Personas")]
        public int PersonaId { get; set; }
        public Persona Personas { get; set; }
    }
}
