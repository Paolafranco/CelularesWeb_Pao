using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeberPrograPao1.Models
{
    public class Bodega
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Persona Bodeguero { get; set; }
        public List<Computadora> Computadora { get; set; }
        public List<Mouse> Mouses { get; set; }
        public List<Tablet> Tablets { get; set; }
        public List<Impresora> Impresoras { get; set; }
        public List<Celular> Celulares { get; set; }

    }
}
