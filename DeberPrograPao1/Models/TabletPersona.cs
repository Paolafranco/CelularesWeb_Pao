using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DeberPrograPao1.Models
{
    public class TabletPersona
    {
        [ForeignKey("Tablet")]
        public int TabletId { get; set; }
        public Tablet Tablet { get; set; }

        [ForeignKey("Personas")]
        public int PersonaId { get; set; }
        public Persona Personas { get; set; }
    }
}

